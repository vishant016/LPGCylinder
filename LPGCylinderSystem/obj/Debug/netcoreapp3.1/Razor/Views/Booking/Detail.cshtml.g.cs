#pragma checksum "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d2fb17b1857b26da5cdfbb1b2acca7906b0e83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Detail), @"mvc.1.0.view", @"/Views/Booking/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\_ViewImports.cshtml"
using LPGCylinderSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d2fb17b1857b26da5cdfbb1b2acca7906b0e83", @"/Views/Booking/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62efaadd6ea989c58047208d60664bfac5ab79be", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LPGCylinderSystem.Models.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Complaint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Resolved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
  
    ViewData["Title"] = "Your Bookings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
 if (ViewBag.Error == "Eroor")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No bookings yet!!!!</h1>\n");
#nullable restore
#line 10 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
}
else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Your Bookings</h1>\n<hr />\n<hr />\n");
#nullable restore
#line 15 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    <h4>Booking</h4>\n    <hr />\n    \n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 22 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.Booking_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 25 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.Booking_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 28 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.PaymentMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 31 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 34 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.SubsidyAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 37 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.SubsidyAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 40 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 43 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 46 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.DAC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 49 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.DAC);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 52 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(Html.DisplayNameFor(item => item.BookingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 55 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
       Write(item.BookingDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d2fb17b1857b26da5cdfbb1b2acca7906b0e839797", async() => {
                WriteLiteral("Make Complaint for Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                                          WriteLiteral(item.Booking_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d2fb17b1857b26da5cdfbb1b2acca7906b0e8312440", async() => {
                WriteLiteral("Resolved Complaint for Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
                                                                                   WriteLiteral(item.Booking_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </dl>\n</div>\n");
#nullable restore
#line 61 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Booking\Detail.cshtml"
 

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LPGCylinderSystem.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
