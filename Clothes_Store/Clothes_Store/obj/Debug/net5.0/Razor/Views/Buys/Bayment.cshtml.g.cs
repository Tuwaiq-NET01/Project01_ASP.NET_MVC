#pragma checksum "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Buys\Bayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810e4db2faf132743d7aa9d90597d531d8deb1dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buys_Bayment), @"mvc.1.0.view", @"/Views/Buys/Bayment.cshtml")]
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
#line 1 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\_ViewImports.cshtml"
using Clothes_Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\_ViewImports.cshtml"
using Clothes_Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"810e4db2faf132743d7aa9d90597d531d8deb1dd", @"/Views/Buys/Bayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7f14554e3ab91fc48f9abcd75dbab036dc15f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Buys_Bayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Buys\Bayment.cshtml"
   
    var info = (BuyModel)ViewData["Info"];


#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h4 class=\"alert-success\">\r\n    Your order has been received\r\n</h4>\r\n<br />\r\n<hr />\r\n\r\n\r\n<div style=\"margin-top:70px;\">\r\n\r\n    <h4 style=\"margin-bottom:20px;\">here your information</h4>\r\n    <h5 style=\"margin-left:50px;\">");
#nullable restore
#line 16 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Buys\Bayment.cshtml"
                             Write(info.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5 style=\"margin-left:50px;\">");
#nullable restore
#line 17 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Buys\Bayment.cshtml"
                             Write(info.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5 style=\"margin-left:50px;\">");
#nullable restore
#line 18 "C:\Users\temx3\source\repos\Clothes_Store\Clothes_Store\Views\Buys\Bayment.cshtml"
                             Write(info.PhoneN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n</div>\r\n\r\n");
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
