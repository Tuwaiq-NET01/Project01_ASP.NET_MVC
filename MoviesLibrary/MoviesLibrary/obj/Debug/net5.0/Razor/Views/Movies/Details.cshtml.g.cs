#pragma checksum "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae758cc5fef70b951dcc651755530e90a7c59686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#line 1 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\_ViewImports.cshtml"
using MoviesLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\_ViewImports.cshtml"
using MoviesLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae758cc5fef70b951dcc651755530e90a7c59686", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ed328b0317bdcdaaecd6425e5eeefcf7b9c5f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml"
  

    var movie = (MovieModel) ViewData["Movie"];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"align-middle\" style=\"color: white\">ID is ");
#nullable restore
#line 4 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml"
                                                   Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Name is ");
#nullable restore
#line 4 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml"
                                                                      Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Year is ");
#nullable restore
#line 4 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml"
                                                                                           Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(". <img");
            BeginWriteAttribute("src", " src=\"", 168, "\"", 186, 1);
#nullable restore
#line 4 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\Movies\Details.cshtml"
WriteAttributeValue("", 174, movie.Image, 174, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\" alt=\"Not supported\"></h1>\r\n");
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
