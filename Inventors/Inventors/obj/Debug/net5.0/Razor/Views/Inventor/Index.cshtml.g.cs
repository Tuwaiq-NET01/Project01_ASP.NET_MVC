#pragma checksum "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a690d22b7d11bed32e2858fc6ef95955b3793c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventor_Index), @"mvc.1.0.view", @"/Views/Inventor/Index.cshtml")]
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
#line 1 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\_ViewImports.cshtml"
using Inventors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\_ViewImports.cshtml"
using Inventors.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a690d22b7d11bed32e2858fc6ef95955b3793c", @"/Views/Inventor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dcf299bd1084a1a5a173a9d7233d5db5ed0a59", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
  
    var inventors = (List<Inventor>)ViewData["InventorsList"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
     foreach (var inventor in inventors)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 337, "\"", 358, 1);
#nullable restore
#line 13 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
WriteAttributeValue("", 343, inventor.Image, 343, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" >\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
                                  Write(inventor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">Bitrht Date: ");
#nullable restore
#line 16 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
                                             Write(inventor.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Death Date: ");
#nullable restore
#line 17 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
                                            Write(inventor.DeathDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">Nationality: ");
#nullable restore
#line 18 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
                                             Write(inventor.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 869, 2);
            WriteAttributeValue("", 836, "Products/Details/?id=", 836, 21, true);
#nullable restore
#line 20 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
WriteAttributeValue("", 857, inventor.Id, 857, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a>\r\n            </div>\r\n        </div> \r\n");
#nullable restore
#line 23 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
