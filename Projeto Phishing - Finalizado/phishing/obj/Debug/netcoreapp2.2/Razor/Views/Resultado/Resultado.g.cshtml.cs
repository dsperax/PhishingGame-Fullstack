#pragma checksum "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\Resultado\Resultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f91e49a36a7b1af0414135d52fe90f37dbb3e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resultado_Resultado), @"mvc.1.0.view", @"/Views/Resultado/Resultado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Resultado/Resultado.cshtml", typeof(AspNetCore.Views_Resultado_Resultado))]
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
#line 1 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\_ViewImports.cshtml"
using phishing;

#line default
#line hidden
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\_ViewImports.cshtml"
using phishing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f91e49a36a7b1af0414135d52fe90f37dbb3e3", @"/Views/Resultado/Resultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f75807451ffeda2f4e54ecbdf141c1d16f844eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Resultado_Resultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<phishing.Models.ViewModels.ResultadoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\Resultado\Resultado.cshtml"
  
    ViewData["Title"] = "Resultado";

#line default
#line hidden
            BeginContext(100, 124, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"texto-principal\">\r\n        <p class=\"resultado-quiz\">\r\n            Bom trabalho, ");
            EndContext();
            BeginContext(225, 18, false);
#line 9 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\Resultado\Resultado.cshtml"
                     Write(Model.Usuario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(243, 28, true);
            WriteLiteral("! Você acertou\r\n            ");
            EndContext();
            BeginContext(272, 13, false);
#line 10 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\Resultado\Resultado.cshtml"
       Write(Model.Acertos);

#line default
#line hidden
            EndContext();
            BeginContext(285, 475, true);
            WriteLiteral(@"
        <p class=""resultado-quiz"">
            do total de 8.
        </p>
        <p>A prática leva à perfeição, e quanto mais você sabe o que analisar, mais se protege contra os ataques de phishing. Você também pode tomar algumas precauções simples para melhorar a segurança das suas contas on-line.</p>
    </div>
    <button class=""botao-entrar"" onclick=""autenticacao()"">FAZER O TESTE NOVAMENTE</button>
    <div class=""imagem-phishing"">

    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(777, 87, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n    $(function () {\r\n           imagemResultado(");
                EndContext();
                BeginContext(865, 13, false);
#line 25 "C:\Users\diogo.xavier\Desktop\Projeto Phishing - Finalizado\phishing\Views\Resultado\Resultado.cshtml"
                      Write(Model.Acertos);

#line default
#line hidden
                EndContext();
                BeginContext(878, 507, true);
                WriteLiteral(@");
        });

    function autenticacao() {
        window.location.href = ""/home/autenticacao""
    }

    function imagemResultado(qtdAcertos) {
        if (qtdAcertos < 8) {
            $('.imagem-phishing').html(""<img src='/static/final.gif' alt='Mão com linha e anzol simbolizando pescaria'>"")
        } else {
            $('.imagem-phishing').html(""<img src='/static/final-pass.gif' alt='Mão com linha e anzol simbolizando pescaria'>"")
        }                  
    }
    </script>
");
                EndContext();
            }
            );
            BeginContext(1388, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<phishing.Models.ViewModels.ResultadoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
