#pragma checksum "D:\Desenvolvimentos\Imc\Imc\Views\Home\Sobre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58169dbdbaf97122b74abb16a84990aa15996c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sobre), @"mvc.1.0.view", @"/Views/Home/Sobre.cshtml")]
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
#line 1 "D:\Desenvolvimentos\Imc\Imc\Views\_ViewImports.cshtml"
using Imc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desenvolvimentos\Imc\Imc\Views\_ViewImports.cshtml"
using Imc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58169dbdbaf97122b74abb16a84990aa15996c6", @"/Views/Home/Sobre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e036f6014f01e5c05fc39fb1330346676026399", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Sobre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Desenvolvimentos\Imc\Imc\Views\Home\Sobre.cshtml"
  
    ViewData["Title"] = "O que é IMC?";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Desenvolvimentos\Imc\Imc\Views\Home\Sobre.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p class=""textoSobreImc"">Criado no século 19 pelo matemático Lambert Quételet,
    o Índice de Massa Corporal, conhecido pela sigla IMC,
    é um cálculo simples que permite medir se alguém está
    ou não com o peso ideal. Ele aponta se o peso está adequado
    ou se está abaixo ou acima do peso.</p>

    <h5>O calculo funciona assim:</h5>
    <p> Peso / Altura²</p>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
