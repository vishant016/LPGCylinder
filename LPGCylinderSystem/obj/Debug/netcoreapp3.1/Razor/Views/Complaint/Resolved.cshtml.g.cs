#pragma checksum "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801518fb86825eae44e615562a0b206dccc72d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complaint_Resolved), @"mvc.1.0.view", @"/Views/Complaint/Resolved.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801518fb86825eae44e615562a0b206dccc72d2d", @"/Views/Complaint/Resolved.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62efaadd6ea989c58047208d60664bfac5ab79be", @"/Views/_ViewImports.cshtml")]
    public class Views_Complaint_Resolved : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LPGCylinderSystem.Models.Complaint>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
  
    ViewData["Title"] = "Resolved";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Resolved</h1>\n");
            WriteLiteral("<div>\n    <h4>Complaint</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n           Complaint_Id\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 20 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Complaint_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Category\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 26 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Description\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 32 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n       \n        <dt class = \"col-sm-2\">\n            Remark\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 39 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Booking_Id\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 45 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"
       Write(item.Booking_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n");
#nullable restore
#line 49 "H:\SEM 6 session 1\SDP\updated\Cylinder-Booking-master\LPGCylinderSystem\Views\Complaint\Resolved.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LPGCylinderSystem.Models.Complaint>> Html { get; private set; }
    }
}
#pragma warning restore 1591
