#pragma checksum "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea622595d336d8544717047038f7bd1ebf973a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pergunta_Pergunta), @"mvc.1.0.view", @"/Views/Pergunta/Pergunta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pergunta/Pergunta.cshtml", typeof(AspNetCore.Views_Pergunta_Pergunta))]
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
#line 1 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\_ViewImports.cshtml"
using phishing;

#line default
#line hidden
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\_ViewImports.cshtml"
using phishing.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea622595d336d8544717047038f7bd1ebf973a7e", @"/Views/Pergunta/Pergunta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f75807451ffeda2f4e54ecbdf141c1d16f844eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Pergunta_Pergunta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<phishing.Models.Pergunta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/static/q1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
  
    ViewData["Title"] = "Pergunta";

#line default
#line hidden
            BeginContext(77, 70, true);
            WriteLiteral("\r\n<div class=\"numPergunta\">(<div id=\"numPergunta\" class=\"numPergunta\">");
            EndContext();
            BeginContext(148, 18, false);
#line 6 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
                                                               Write(Model.Num_Pergunta);

#line default
#line hidden
            EndContext();
            BeginContext(166, 121, true);
            WriteLiteral("</div>/8)</div>\r\n\r\n<div id=\"container\" class=\"container\">\r\n    <div id=\"workspace\" class=\"texto-principal\">\r\n        <h1>");
            EndContext();
            BeginContext(288, 12, false);
#line 10 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(300, 32, true);
            WriteLiteral("</h1>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(333, 15, false);
#line 12 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
       Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(348, 512, true);
            WriteLiteral(@"
        </p>
        <button id=""btnProxPergunta"" style=""display: none;"" class='botao-alternativa' onclick='avancaProximaPergunta()'>PRÓXIMA PERGUNTA</button>
        <div id=""respostas"">
            <button class=""botao-alternativa"" onclick=""clicou('P')"">PHISHING</button>
            <button class=""botao-alternativa"" onclick=""clicou('V')"">VERDADEIRO</button>
        </div>
    </div>
    <div id=""img-questao"" class=""formulario-questoes"">
        <a href=""drive--google.com"" onclick=""return false"">");
            EndContext();
            BeginContext(860, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea622595d336d8544717047038f7bd1ebf973a7e5865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(889, 28, true);
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(934, 424, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

    function clicou(ondeClicou) {

        var numPergunta = $('#numPergunta')[0].innerHTML;
        var respostaUsuario = ondeClicou;
        var acertou = false;

        var resposta = { NumPergunta: numPergunta, RespostaPergunta: respostaUsuario }; //não pega a resposta correta, pega a resposta do usuario

        $.ajax({
            type: ""POST"",
            url: '");
                EndContext();
                BeginContext(1359, 39, false);
#line 38 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
             Write(Url.Action("SalvaResposta", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(1398, 383, true);
                WriteLiteral(@"',
            data: JSON.stringify(resposta),
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            async: false
        }).done(function (retorno) {
            acertou = retorno.acertou;
        }).fail(function () {
            alert(""Error"");
        });

        $.ajax({
            type: ""POST"",
            url: '");
                EndContext();
                BeginContext(1782, 42, false);
#line 51 "C:\Users\diogo.xavier\Desktop\Projeto Campanha PHISHING\ASP_NET_CORE 6.0\phishing\phishing\Views\Pergunta\Pergunta.cshtml"
             Write(Url.Action("RespostaPergunta", "Pergunta"));

#line default
#line hidden
                EndContext();
                BeginContext(1824, 1503, true);
                WriteLiteral(@"',
            data: JSON.stringify(resposta),
            dataType: ""json"",
            contentType: ""application/json; charset=utf-8"",
            async: false
            }).done(function(retorno) {
                console.log('passou no segundo ajax');
                if (acertou) {
                    $('#workspace h1').html('ACERTOU');
                }
                else {
                    $('#workspace h1').html('ERROU!');
                }
                $('#workspace p').html(retorno.descricaoResposta);
                $('#respostas').hide();
                $('#btnProxPergunta').show();
            }).fail(function () {
                alert(""Error"");
            })

        }
    function avancaProximaPergunta() {
        var numPergunta = $('#numPergunta')[0].innerHTML;
        console.log(parseInt(numPergunta)); //colocar o maior numero de pergunta do banco
        if (parseInt(numPergunta) <= 7) {
            $.get(""/Pergunta/GetNextQuestion/"" + numPergunta, null,");
                WriteLiteral(@" function (data) {
                $('#workspace h1').html(data.titulo);
                $('#workspace p').html(data.descricao);
                $('#respostas').show();
                $('#btnProxPergunta').hide();
                $('#img-questao').html(data.srcImagem);
                $('#numPergunta').html(data.numPerguntaAtual);
            });
        } else {
            window.location.href = ""/resultado/resultado"";
        }
        
    }
    </script>
");
                EndContext();
            }
            );
            BeginContext(3330, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<phishing.Models.Pergunta> Html { get; private set; }
    }
}
#pragma warning restore 1591