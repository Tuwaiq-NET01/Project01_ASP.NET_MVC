#pragma checksum "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48210ba0d721f5557dc9f18fc82d9ebc3ef3ca37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entertainment_details), @"mvc.1.0.view", @"/Views/Entertainment/details.cshtml")]
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
#line 1 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\_ViewImports.cshtml"
using City_Guide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\_ViewImports.cshtml"
using City_Guide.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48210ba0d721f5557dc9f18fc82d9ebc3ef3ca37", @"/Views/Entertainment/details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f3e061a16f88ade358ca31e4f0cc26d5723dea", @"/Views/_ViewImports.cshtml")]
    public class Views_Entertainment_details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml"
  
    var e = (EntertainmentModel)ViewData["ent"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card align-item-center\" style=\"width:60%; margin-left:230px\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 7 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml"
                          Write(e.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 8 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml"
                        Write(e.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">Location: ");
#nullable restore
#line 11 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml"
                                         Write(e.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <img class=\"card-img-bottom\"");
            BeginWriteAttribute("src", " src=\"", 422, "\"", 436, 1);
#nullable restore
#line 13 "C:\Users\Reema\source\repos\Project01_ASP.NET_MVC\City_Guide\City_Guide\Views\Entertainment\details.cshtml"
WriteAttributeValue("", 428, e.image, 428, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"restaurant image\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
