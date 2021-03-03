﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LPGCylinderSystem.Data.Stores;
using LPGCylinderSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace LPGCylinderSystem.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {
        private readonly ClassRepository<ApplicationUser> _classRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public string SessionAmt1 = "_Amt1";
        public string SessionCyltype = "_Cyltype1";
        public string Sessioncard1 = "_Card1";
        public Dcard Sessioncardobj =new Dcard();
        public string SessionBookingid = "_Bookid1";
        public string SessionOtp1 = "_otp1";

        public BookingController(ClassRepository<ApplicationUser> classRepository, UserManager<ApplicationUser> userManager)
        {
            _classRepository = classRepository;
            _userManager = userManager;
        }

        public async Task<IActionResult> DetailAsync()
        {
           var user1 = await _userManager.FindByNameAsync(User.Identity.Name.ToUpper());
            if (user1.Bookings == null)
            {
                ViewData["Error"] = "Eroor";
                return View();
            }
           IEnumerable<Booking> booking= user1.Bookings;
           return View(booking);
        }

        public async Task<IActionResult> Index()
        {
            var user1 = await _userManager.FindByNameAsync(User.Identity.Name.ToUpper());
            List<Cylinder> cylinders= new List<Cylinder>();
            cylinders = _classRepository.FindCylindersAsync();
            ViewBag.Cylinders = cylinders;
            //var user = _classRepository.FindByConnectionIdAsync(87665.ToString());
            ViewBag.user = user1;
            return View();
        }



        public IActionResult ChooseMethod(string cylindertype, IFormCollection formCollection)
        {
            int amount ;
            amount = Int32.Parse(formCollection["cylindertype"]);
            HttpContext.Session.SetString(SessionCyltype, formCollection["hidden1"]);
            HttpContext.Session.SetInt32(SessionAmt1, amount);
            return View();
        }


        public IActionResult Dopayment(string payments)
        {
            int amount = (int)HttpContext.Session.GetInt32(SessionAmt1);
            ViewBag.total = amount;
            ViewBag.m = payments;
            if (payments == "card")
            {
                return View("DoPayment");
            }
            else if (payments == "cod")
            {
                return RedirectToAction("COD", "Booking", new { area = "" });
            }

            return View("Netbanking");
        }

        public async Task<IActionResult> COD()
        {
            var user1 = _userManager.FindByNameAsync(User.Identity.Name.ToUpper());
            var book = user1.Result.Bookings;
            if (book == null)
            {
              book = new List<Booking>();
            }
            string mailid = user1.Result.Email;
            Cylinder cylinder = await _classRepository.SetQuantityofCylinderAsync(HttpContext.Session.GetString(SessionCyltype).ToString());
            var book1 = new Booking { Booking_Id = ObjectId.GenerateNewId().ToString(),Cylinder_Id=cylinder.Cylinder_Id,Amount= Int32.Parse(HttpContext.Session.GetInt32(SessionAmt1).ToString()), BookingDate =  DateTime.Now, PaymentMethod = "Cash On Delivery", SubsidyAmount = cylinder.SubsidyAmount, OrderStatus = "Confirmed", DAC = "0" };
            //List<Booking> booking = new List<Booking>();

            book.Add(book1);
            user1.Result.Bookings = book;

            await _userManager.UpdateAsync(user1.Result);
            ViewBag.id1 = book1.Booking_Id;
            HttpContext.Session.SetString(SessionBookingid, book1.Booking_Id.ToString());

            string Subject = "Voila! Your Cylinder is booked ";
            string body = "   Your Cylinder is booked via Reference No." + book1.Booking_Id + ". You have to pay ₹" + HttpContext.Session.GetInt32(SessionAmt1).ToString() + " at Delivery time. Thanks for " +
                "using our service.";
            _classRepository.SendMailForPaper(mailid, Subject, body);


            return View();
        }


        public async Task<IActionResult> Cardpayment(string cardno, int mm, int yy, int cvv)
        {
            /* var card = await _context.Cards
                .FirstOrDefaultAsync(m => m.CardNumber == cardno);*/

            var card = await _classRepository.FindByCardAsync(cardno);
            HttpContext.Session.SetString(Sessioncard1, cardno);
            HttpContext.Session.SetString(Sessioncardobj.ToString(), card.ToString());


            /*var booking = _context.Bookings
                .OrderByDescending(a => a.BookingID)
                .First();*/
            //ViewBag.cd = card;
            //return View();


            ViewBag.paymentStatus = "fail";
            //ViewBag.pkgid = (int)TempData["packageid"];
            //HttpContext.Session.SetInt32(Sessionpkgid1, (int)TempData["packageid"]);
            if (card == null)
            {
                ViewBag.message1 = "Payment failed due to wrong card number!";
            }
            else
            {

                if (card.month != mm || (card.year != yy || card.CVV != cvv))
                {
                    ViewBag.message1 = "Payment failed due to wrong card Details!";
                }
                else if (card.balance < HttpContext.Session.GetInt32(SessionAmt1))
                {
                    ViewBag.message1 = "Payment failed due to insufficient balance!";
                }
                else
                {
                    var mailid = card.mailid;
                    ViewBag.mail = mailid;
                    var random = new Random();
                    int OTP = random.Next(100001, 999999);
                    HttpContext.Session.SetInt32(SessionOtp1, OTP);

                    string Subject = "OTP for your Debit Card Payment";
                    string body = "Your OTP Via Debit card Payment on Cylinder booking site is " + OTP;
                    _classRepository.SendMailForPaper(mailid, Subject, body);

                    return View("OTP");


                }
            }


            return View();
        }


        public async Task<IActionResult> OTPPayment(string otp1)
        {
            if (otp1 == (HttpContext.Session.GetInt32(SessionOtp1)).ToString())
            {
                /* var card = await _context.Cards
              .FirstOrDefaultAsync(m => m.CardNumber == HttpContext.Session.GetString(Sessioncard1));
                 var booking = _context.Bookings
                    .OrderByDescending(a => a.BookingID)
                    .First();*/
                string cardno = HttpContext.Session.GetString(Sessioncard1);
                var card = await _classRepository.FindByCardAsync(cardno);
                card.balance = (int)(card.balance - HttpContext.Session.GetInt32(SessionAmt1));

                var user1 = _userManager.FindByNameAsync(User.Identity.Name.ToUpper());
                List<Booking> book = user1.Result.Bookings;
                string mailid;
                int dac;
                Booking book1;
                if (book == null)
                {
                    List<Booking> bookings = new List<Booking>();

                     mailid = user1.Result.Email;
                    var random = new Random();
                     dac = random.Next(1001, 9999);
                    Cylinder cylinder = await _classRepository.SetQuantityofCylinderAsync(HttpContext.Session.GetString(SessionCyltype).ToString());
                    book1 = new Booking { Booking_Id = ObjectId.GenerateNewId().ToString(), Cylinder_Id = cylinder.Cylinder_Id, Amount = Int32.Parse(HttpContext.Session.GetInt32(SessionAmt1).ToString()), BookingDate = DateTime.Now, PaymentMethod = "Card", SubsidyAmount =cylinder.SubsidyAmount, OrderStatus = "Confirmed-Payment Received", DAC = dac.ToString() };
                    bookings.Add(book1);
                    user1.Result.Bookings = bookings;
                }
                else
                {
                     mailid = user1.Result.Email;
                    var random = new Random();
                     dac = random.Next(1001, 9999);
                    Cylinder cylinder = await _classRepository.SetQuantityofCylinderAsync(HttpContext.Session.GetString(SessionCyltype).ToString());
                    book1 = new Booking { Booking_Id = ObjectId.GenerateNewId().ToString(), Cylinder_Id = cylinder.Cylinder_Id, Amount = Int32.Parse(HttpContext.Session.GetInt32(SessionAmt1).ToString()), BookingDate = DateTime.Now, PaymentMethod = "Card", SubsidyAmount = cylinder.SubsidyAmount, OrderStatus = "Confirmed-Payment Received", DAC = dac.ToString() };
                    book.Add(book1);
                    user1.Result.Bookings = book;
                }
               
                


                await _userManager.UpdateAsync(user1.Result);
               //string cards= HttpContext.Session.GetString(Sessioncardobj.ToString());
               // System.Diagnostics.Debug.Print(cards+cards[1]);
                


                ViewBag.id1 = book1.Booking_Id;
                ViewBag.paymentStatus = "success";
             
                ViewBag.message1 = "woohoo! Your payment is successful. Now sit back. we will Deliver your cylinder at your door.";
                string Subject = "Voila! Your Cylinder is booked ";
                string body = "   Your Cylinder is booked via Reference No." + book1.Booking_Id + ". Your Payment ₹" + HttpContext.Session.GetInt32(SessionAmt1).ToString() + " is received.Your DAC is " + dac.ToString() + " .Which you have to give our Delivery partener at Delivery time. Thanks for " +
                    "using our service.";
                _classRepository.SendMailForPaper(mailid, Subject, body);
                _classRepository.updateCard(card);
                return View("Cardpayment");
            }
            else
            {
                //ViewBag.pkgid = HttpContext.Session.GetInt32(Sessionpkgid1);
                ViewBag.paymentStatus = "fail";
                ViewBag.message1 = "Payment failed due to Wrong OTP! Please Try again";
                return View("Cardpayment");
            }


        }

        public async Task<IActionResult> Netbankingpayment(string bank, string uname, string passwd)
        {
            var bankuser = await _classRepository.FindNetbankingAsync(uname);

            if (bankuser == null)
            {
                ViewBag.message1 = "Payment failed because Invalid Username!";
            }
            else
            {
                if (bankuser.Password != passwd || bankuser.Bank != bank)
                {
                    ViewBag.message1 = "Payment failed due to Invalid password or Bank!";
                }
                else if (bankuser.balance < HttpContext.Session.GetInt32(SessionAmt1))
                {
                    ViewBag.message1 = "Payment failed due to insufficient balance!";
                }
                else
                {
                    var user1 = _userManager.FindByNameAsync(User.Identity.Name.ToUpper());
                    var book = user1.Result.Bookings;
                    string mailid = user1.Result.Email;
                    var random = new Random();
                    int dac = random.Next(1001, 9999);
                     Cylinder cylinder = await _classRepository.SetQuantityofCylinderAsync(HttpContext.Session.GetString(SessionCyltype).ToString());
                    var book1 = new Booking { Booking_Id = ObjectId.GenerateNewId().ToString(), Cylinder_Id = cylinder.Cylinder_Id, Amount = Int32.Parse(HttpContext.Session.GetInt32(SessionAmt1).ToString()), BookingDate = DateTime.Now, PaymentMethod = "Netbanking", SubsidyAmount = cylinder.SubsidyAmount, OrderStatus = "Confirmed-Payment Received", DAC = dac.ToString() };
                    ViewBag.id1 = book1.Booking_Id;
                    book.Add(book1);
                    user1.Result.Bookings = book;
                    bankuser.balance = (int)(bankuser.balance - HttpContext.Session.GetInt32(SessionAmt1));


                    await _userManager.UpdateAsync(user1.Result);

                    ViewBag.paymentStatus = "success";
                    _classRepository.updateNetbankingBalance(bankuser);
                    ViewBag.message1 = "woohoo! Your payment is successfull. Enjoy your Trip :)";
                    string Subject = "Voila! Your Cylinder is booked! ";
                    string body = "   Your Cylinder is booked via Reference No." + book1.Booking_Id + ". Your Payment ₹" + HttpContext.Session.GetInt32(SessionAmt1).ToString() + " is received.Your DAC is " + dac.ToString() + " .Which you have to give our Delivery partener at Delivery time. Thanks for " +
                    "using our service.";
                    _classRepository.SendMailForPaper(mailid, Subject, body);
                }
            }


            return View("Cardpayment");
        }


    }
}