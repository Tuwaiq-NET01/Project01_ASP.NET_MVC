#pragma checksum "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90134e0c7627bdd3a7ec95214a68a88f1d17215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventor_Details), @"mvc.1.0.view", @"/Views/Inventor/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90134e0c7627bdd3a7ec95214a68a88f1d17215", @"/Views/Inventor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dcf299bd1084a1a5a173a9d7233d5db5ed0a59", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventor_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
  
    var inventor = (Inventor)ViewData["Inventor"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
                          Write(inventor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
                        Write(inventor.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Birth Date: ");
#nullable restore
#line 26 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
                                    Write(inventor.BirthDate.Date.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Death Date: ");
#nullable restore
#line 27 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
                                    Write(inventor.DeathDate.Date.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\"><small class=\"text-muted\">Last updated 3 mins ago</small></p>\r\n        <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
                        Write(inventor.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n    <img class=\"card-img-bottom\"");
            BeginWriteAttribute("src", " src=\"", 1335, "\"", 1356, 1);
#nullable restore
#line 32 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Inventor\Details.cshtml"
WriteAttributeValue("", 1341, inventor.Image, 1341, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n</div>");
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
