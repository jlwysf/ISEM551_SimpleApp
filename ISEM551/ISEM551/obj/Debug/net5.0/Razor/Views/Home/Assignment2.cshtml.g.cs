#pragma checksum "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c665816dca5350d95f9f3cacd4c7a0e7f80430"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Assignment2), @"mvc.1.0.view", @"/Views/Home/Assignment2.cshtml")]
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
#line 1 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/_ViewImports.cshtml"
using ISEM551;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/_ViewImports.cshtml"
using ISEM551.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
using GridMvc.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c665816dca5350d95f9f3cacd4c7a0e7f80430", @"/Views/Home/Assignment2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb893d6e6b8a1004fcd97e1c84e00525bfbe633", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Assignment2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.DemographicInformation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
  
    ViewData["Title"] = "Assignment2";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 8 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
            WriteLiteral("\n<div>\n    <table>\n        <tr>\n            <th>Firstname</th>\n            <th>Lastname</th>\n            <th>Sex</th>\n            <th>Address</th>\n        </tr>\n        <tr>\n");
#nullable restore
#line 34 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
             foreach (var m in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>");
#nullable restore
#line 37 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
                   Write(m.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 38 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
                   Write(m.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 39 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
                   Write(m.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 40 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
                   Write(m.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                </tr>\n");
#nullable restore
#line 42 "/Users/ywang2143/Projects/ISEM551/ISEM551/Views/Home/Assignment2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.DemographicInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591