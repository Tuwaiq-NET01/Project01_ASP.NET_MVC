#pragma checksum "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95684de29c6f8c2ae707379eaa109b61eadda327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95684de29c6f8c2ae707379eaa109b61eadda327", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20dcf299bd1084a1a5a173a9d7233d5db5ed0a59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\96655\OneDrive\Desktop\Tuwaiq\ASP.NET\Project\Project01_ASP.NET_MVC\Inventors\Inventors\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div ");
            WriteLiteral(@">
    <h5 class=""display-4 "">Welcome!</h5>
    <hr>
    <small class=""text-muted"">
        Fascinated with inventions stories? This is the place for you!
    </small>
    <br><br>
        <div class=""container"">
            <div class=""row"">
                <div class=""container"">
                    <blockquote class=""quote-card yellow-card"">
");
            WriteLiteral(@"                        <p class=""mb-0"" id=""qoute"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                        <footer class=""blockquote-footer"" id=""footer"">Someone famous</footer>
                    </blockquote>
                </div>
            </div>
        </div>

                    <script type=""text/javascript"">
    fetch(""https://type.fit/api/quotes"")
    .then(function(response) {
    return response.json();
    })
    .then(function(data) {
        console.log(data);
        showQoute(data);
    });
        showQoute = qoutes => {
            const qoutePElement = document.querySelector('#qoute');
            const footerElement = document.querySelector('#footer');
            var randomQoute = qoutes[Math.floor(Math.random() * qoutes.length)];
            qoutePElement.innerText = `${randomQoute.text}`;
            footerElement.innerText = `${randomQoute.author}`;
            //qoutePElement.append(qoutePElement);

");
            WriteLiteral("        }\r\n                    </script>\r\n");
            WriteLiteral("            </div>\r\n");
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
