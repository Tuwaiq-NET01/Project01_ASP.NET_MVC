#pragma checksum "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b1b02b274ccd7d17d56241c6bf384353cbdef1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
#line 1 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/_ViewImports.cshtml"
using NatureEscapes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/_ViewImports.cshtml"
using NatureEscapes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1b02b274ccd7d17d56241c6bf384353cbdef1d", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018f63d0b5da91033f25bdb84cc878fbf1f23620", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
  
    var product = (ProductModel)ViewData["product"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""border-b border-black p-4 text-center text-5xl"">
    Nature Escapes
</div>
<div class=""border-b border-black p-4 text-center text-3xl"">
    Product Details
</div>

<div class=""grid grid-cols-2 gap-2 border-b border-black"">
    <div class=""border-r border-black""");
            BeginWriteAttribute("style", " style=\"", 331, "\"", 459, 9);
            WriteAttributeValue("", 339, "background-image:", 339, 17, true);
            WriteAttributeValue(" ", 356, "url(", 357, 5, true);
#nullable restore
#line 12 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
WriteAttributeValue("", 361, product.Image, 361, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 375, ");", 375, 2, true);
            WriteAttributeValue(" ", 377, "background-size:", 378, 17, true);
            WriteAttributeValue(" ", 394, "cover;", 395, 7, true);
            WriteAttributeValue(" ", 401, "background-repeat:", 402, 19, true);
            WriteAttributeValue(" ", 420, "no-repeat;", 421, 11, true);
            WriteAttributeValue(" ", 431, "background-position:center;", 432, 28, true);
            EndWriteAttribute();
            WriteLiteral(">\n    </div>\n    <div class=\"p-4 pl-9 pr-9\">\n        <a class=\"text-sm mb-9\" href=\"/shop/index\">← Back to Products</a>\n        <h1 class=\"text-6xl\">");
#nullable restore
#line 16 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
                        Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <h2 class=\"text-gray-500 text-lg mb-6\">");
#nullable restore
#line 17 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
                                          Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD</h2>\n        <p class=\"leading-relaxed text-sm\">\n            ");
#nullable restore
#line 19 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
       Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <h2 class=\"text-gray-500\">Size: ");
#nullable restore
#line 21 "/Users/hanans/Desktop/Tuwaiq/projects/Project01_ASP.NET_MVC/NatureEscapes/NatureEscapes/Views/Shop/Details.cshtml"
                                   Write(product.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral(" oz</h2>\n        <button class=\"bg-black text-white p-2 pl-16 pr-16 font-sans font-semibold mt-4\">\n            <a href=\"#\">BUY</a>\n        </button>\n    </div>\n</div>");
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
