#pragma checksum "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0df9240c52196ab79119d28ef479637e68ec34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0df9240c52196ab79119d28ef479637e68ec34", @"/Views/User/Profile.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TareaKiut.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 158, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"col-lg-12 col-sm-12 col-md-12\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"text-primary\">Gracias, ");
            EndContext();
            BeginContext(189, 10, false);
#line 7 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(199, 224, true);
            WriteLiteral("</h1>\r\n            <div>\r\n                Gracias por elegirnos, aunque no somos nadie, solos unos simpels estudiantes que quieren pasar la materia.\r\n            </div>\r\n\r\n            <h1 class=\"text-dark\">He aqui sus datos ");
            EndContext();
            BeginContext(424, 10, false);
#line 12 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(434, 71, true);
            WriteLiteral("</h1>\r\n            <h6 class=\"text-dark\">Numero Nacional de Identidad: ");
            EndContext();
            BeginContext(506, 16, false);
#line 13 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                                           Write(Model.IdNational);

#line default
#line hidden
            EndContext();
            BeginContext(522, 49, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">Nombre: ");
            EndContext();
            BeginContext(572, 10, false);
#line 14 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(582, 51, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">Apellido: ");
            EndContext();
            BeginContext(634, 14, false);
#line 15 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(648, 48, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\"> Edad: ");
            EndContext();
            BeginContext(697, 9, false);
#line 16 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                    Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(706, 61, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">Correo Electronico: ");
            EndContext();
            BeginContext(768, 11, false);
#line 17 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                                 Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(779, 49, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">Genero: ");
            EndContext();
            BeginContext(829, 12, false);
#line 18 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                     Write(Model.Genero);

#line default
#line hidden
            EndContext();
            BeginContext(841, 50, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">Estado:  ");
            EndContext();
            BeginContext(892, 12, false);
#line 19 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                                      Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(904, 67, true);
            WriteLiteral("</h6>\r\n            <h6 class=\"text-dark\">\r\n                Hobbys: ");
            EndContext();
#line 21 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                         for (var x = 0; x < Model.Hobbys.Length; x++)
                {
                    if (@Model.Hobbys[x] != "false")
                    {
                        

#line default
#line hidden
            BeginContext(1140, 15, false);
#line 25 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                   Write(Model.Hobbys[x]);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 40, true);
            WriteLiteral("                        <spam>,</spam>\r\n");
            EndContext();
#line 27 "C:\Users\colon\OneDrive\Escritorio\Cosas\or\TareaKiut\Views\User\Profile.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1239, 53, true);
            WriteLiteral("            </h6>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TareaKiut.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
