#pragma checksum "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8716657cfefbc476069c27a1fe00c795ee7b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personales_Index), @"mvc.1.0.view", @"/Views/Personales/Index.cshtml")]
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
#line 1 "C:\Users\lunaa\MVCTarea\Views\_ViewImports.cshtml"
using MVCTarea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lunaa\MVCTarea\Views\_ViewImports.cshtml"
using MVCTarea.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8716657cfefbc476069c27a1fe00c795ee7b16", @"/Views/Personales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d055270c539b6f118880a57e4cc0ce92e0bcca3", @"/Views/_ViewImports.cshtml")]
    public class Views_Personales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personales>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Pagina Personal </h1>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.nombre, "NOMBRE"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 3 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                                  Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.Apellidos, "APELLIDOS "));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 4 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                                         Write(Model.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.Edad,"EDAD"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 5 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                             Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.ce,"CORREO ELECTRONICO"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 6 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                                         Write(Model.ce);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.num,"NUMERO TELEFONICO"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 7 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                                         Write(Model.num);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
Write(Html.LabelFor(m=>m.direc,"DIRECCION"));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "C:\Users\lunaa\MVCTarea\Views\Personales\Index.cshtml"
                                   Write(Model.direc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personales> Html { get; private set; }
    }
}
#pragma warning restore 1591
