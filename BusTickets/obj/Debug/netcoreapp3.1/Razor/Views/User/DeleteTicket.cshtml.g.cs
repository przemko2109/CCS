#pragma checksum "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34f82ffbaae0361f314ac477f18fc84a50d18848"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DeleteTicket), @"mvc.1.0.view", @"/Views/User/DeleteTicket.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\_ViewImports.cshtml"
using BusTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\_ViewImports.cshtml"
using BusTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f82ffbaae0361f314ac477f18fc84a50d18848", @"/Views/User/DeleteTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a997fe1f4e5d51f1d8c695a34101ebb580a2e851", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DeleteTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusTickets.Models.Ticket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
  
    ViewBag.Title = "Delete the ticket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete the city</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 13 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 17 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 21 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayNameFor(model => model.ScheduleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 25 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayFor(model => model.ScheduleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n            ");
#nullable restore
#line 29 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayNameFor(model => model.AgeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 33 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.DisplayFor(model => model.AgeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n\n");
#nullable restore
#line 38 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n            ");
#nullable restore
#line 43 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
       Write(Html.ActionLink("Back to the list", "AdminIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 45 "C:\Users\Lenovo\Desktop\Moje pliki\BusTickets\BusTickets\Views\User\DeleteTicket.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusTickets.Models.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591