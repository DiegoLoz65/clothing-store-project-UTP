#pragma checksum "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\VectorOrd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f17499dece309df0958a705e01c6844ac5969e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VectorOrd), @"mvc.1.0.view", @"/Views/Home/VectorOrd.cshtml")]
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
#line 1 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\_ViewImports.cshtml"
using TiendaOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\_ViewImports.cshtml"
using TiendaOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f17499dece309df0958a705e01c6844ac5969e", @"/Views/Home/VectorOrd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7e8890325761288123e7747a12b1da9edd95c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VectorOrd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\VectorOrd.cshtml"
  
    ViewData["Title"] = "Vector Ordenado";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"font-weight-bold display-4\">VECTOR ORDENADO</h2>\r\n\r\n\r\n<table class=\"table\">\r\n  <thead class=\"thead-dark\">\r\n    <tr>\r\n      <th scope=\"col\">Palabras generadas aleatoriamente y ordenadas.</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\VectorOrd.cshtml"
 foreach (string item in Model)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 19 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\VectorOrd.cshtml"
     Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\diego\Documents\Proyectos-PC-Antiguo\TiendaOnline\Views\Home\VectorOrd.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
