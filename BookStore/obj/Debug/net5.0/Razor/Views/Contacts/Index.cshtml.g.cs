#pragma checksum "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b92fecd393c7d389169d29705937ccc232b3f1e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
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
#line 1 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92fecd393c7d389169d29705937ccc232b3f1e7", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Contacts\Index.cshtml"
   
    var c = (ContactModel)ViewData["contact"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid bg-grey"">
    <h2 class=""text-center"">CONTACT</h2>
    <div class=""row"">
        <div class=""col-sm-5"">
            <p>Contact us and we'll get back to you within 24 hours.</p>
            <p><span class=""glyphicon glyphicon-map-marker""><img src=""https://img.icons8.com/material/24/000000/worldwide-location--v1.png"" width=""20"" height=""20"" />   </span>");
#nullable restore
#line 11 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Contacts\Index.cshtml"
                                                                                                                                                                          Write(c.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"glyphicon glyphicon-phone\"><img src=\"https://img.icons8.com/android/24/000000/phone.png\" width=\"20\" height=\"20\" />    </span>");
#nullable restore
#line 12 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Contacts\Index.cshtml"
                                                                                                                                                    Write(c.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><span class=\"glyphicon glyphicon-envelope\"><img src=\"https://img.icons8.com/pastel-glyph/64/000000/email--v3.png\" width=\"20\" height=\"20\" />   </span> ");
#nullable restore
#line 13 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Contacts\Index.cshtml"
                                                                                                                                                                Write(c.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
        <div class=""col-sm-7"">
            <div class=""row"">
                <div class=""col-sm-6 form-group"">
                    <input class=""form-control"" id=""name"" name=""name"" placeholder=""Name"" type=""text"" required>
                </div>
                <div class=""col-sm-6 form-group"">
                    <input class=""form-control"" id=""email"" name=""email"" placeholder=""Email"" type=""email"" required>
                </div>
            </div>
            <textarea class=""form-control"" id=""comments"" name=""comments"" placeholder=""Comment"" rows=""5""></textarea><br>
            <div class=""row"">
                <div class=""col-sm-12 form-group"">
                    <button class=""btn btn-dark"" type=""submit"">Send</button>
                </div>
            </div>
        </div>
    </div>
</div>");
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
