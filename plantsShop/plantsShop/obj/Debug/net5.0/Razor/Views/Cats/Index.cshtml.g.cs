#pragma checksum "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81986c4ca796f2c1b748e74367a6d5802d78dd0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats_Index), @"mvc.1.0.view", @"/Views/Cats/Index.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81986c4ca796f2c1b748e74367a6d5802d78dd0f", @"/Views/Cats/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bed17f141cbaace2d3d2bf9f6f7ab96a3149756", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
  
    var cat = (List<CatModel>)ViewData["Cats"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container ml-5 pl-5\" id=\"cards\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
         foreach (var c in cat)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\r\n                <div class=\"card-body\">\r\n                    <img class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=\"", 346, "\"", 360, 1);
#nullable restore
#line 13 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
WriteAttributeValue("", 352, c.image, 352, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
                                      Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\"> ");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
                                     Write(c.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 523, "\"", 549, 2);
            WriteAttributeValue("", 530, "/cats/details/", 530, 14, true);
#nullable restore
#line 16 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"
WriteAttributeValue("", 544, c.id, 544, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">More Info</button></a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Batool Alghamdi\source\repos\plantsShop\plantsShop\Views\Cats\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
