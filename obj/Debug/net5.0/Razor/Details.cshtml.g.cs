#pragma checksum "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c276a162aecd98cab7af1ad913b717b7f98f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Details), @"mvc.1.0.view", @"/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c276a162aecd98cab7af1ad913b717b7f98f63", @"/Details.cshtml")]
    public class Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoKanban.Models.Projeto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagens/aissa-branco.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d7c276a162aecd98cab7af1ad913b717b7f98f633852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <button class=\"headerbutton\">&#9776</button>\r\n    <h4 class=\"cabecalhoProjeto\">Projeto ");
#nullable restore
#line 10 "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml"
                                    Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <div class=\"linksProjeto\">\r\n        <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 346, "\"", 370, 1);
#nullable restore
#line 12 "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml"
WriteAttributeValue("", 361, Model.Id, 361, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><font color=white><i class=""bi bi-pencil-fill""></i>Editar</font></a> |
        <a asp-action=""Index""><font color=white><i class=""bi bi-arrow-return-left""></i>Voltar</font></a>
    </div>

</header>
<div class=""container"">
    <main role=""main"" class=""pb-3"">
        <section>

");
            WriteLiteral(@"            <div class=""modal-overlay"" id=""overlay"">
                <div class=""modal"" id=""modal"">
                    <div class=""modal-header"">
                        
                    </div>
                    <div class=""modal-content"">
                        <div class=""modalDescricaoEditar"">
                            <label>Descrição</label>
                            <button class=""buttonSaveModal""><font color=white><i class=""bi bi-pencil-fill""></i> Editar </font></button>
                            <button class=""buttonSaveModal""><font color=white><i class=""bi bi-cloud-arrow-up-fill""></i> Salvar </font></button>
                        </div>
                        <input class=""descricaoTarefaModal"" />
                    </div>
                </div>
            </div>

");
            WriteLiteral(@"            <div class=""nova-tarefa-container"">
                <input type=""text"" maxlength=""20"" id=""tarefaText"" placeholder=""Nova Tarefa.."" onkeydown=""if (event.keyCode == 13) document.getElementById('add').click()""/>
                <button id=""add"" class=""button add-button"" onclick=""addTarefa()"">Adicionar</button> |
                <button id=""salvarEstadoProjeto"" class=""buttonSalvarKanban"" onclick=""salvarAlteracoes()""><font color=white><i class=""bi bi-cloud-arrow-up-fill""></i>Salvar</font></button>
               
            </div>

");
            WriteLiteral(@"            <div class=""projeto row"">

                <div class=""kanban"">
                    <h5>Backlog</h5>
                    <h5>Design</h5>
                    <h5>Desenvolvimento</h5>
                    <h5>Testes</h5>
                    <h5>Implantação</h5>
                    <h5>Conclusão</h5>
                </div>
                <div id=""tarefasProjeto"" class=""kanban"">
                    <div id=""backlog"" class=""coluna"">
                    </div>
                    <div id=""design"" class=""coluna"">
                    </div>
                    <div id=""desenvolvimento"" class=""coluna"">
                    </div>
                    <div id=""testes"" class=""coluna"">
                    </div>
                    <div id=""implantacao"" class=""coluna"">
                    </div>
                    <div id=""conclusao"" class=""coluna"">
                        <button class=""button del-button"" onclick=""limparConclusao()""><i class=""bi bi-trash3-fill""></i></button>
           ");
            WriteLiteral("         </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n</div>\r\n\r\n<div id=\"root\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7c276a162aecd98cab7af1ad913b717b7f98f638830", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n\r\n    /*Salvar alterações de estado do quadro*/\r\n    function salvarAlteracoes() {\r\n\r\n        var projetoHtml = document.getElementById(\"tarefasProjeto\").innerHTML;\r\n        var projetoId = \"");
#nullable restore
#line 85 "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";

        $.ajax({
            method: ""POST"",
            url: ""/Projetoes/EditState"",
            data: { conteudo: projetoHtml, id:projetoId },
            success: (e) => {
                alert('As alterações foram salvas com sucesso!')
            },
            error: (e) => {
                alert('Não foi possível salvar as alterações!')
            }
        });
    }

    /*Carregar primeiro ou último estado do quadro que foi salvo*/
    window.onload = function carregarEstado() {
        var stateOne = """);
#nullable restore
#line 102 "C:\Users\WIN10\Desktop\kanban\Projeto-Kanban\Views\Projetoes\Details.cshtml"
                   Write(Html.DisplayFor(model => model.StateConteudo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".replace(/&#xA;/g, """");
        var stateTwo = stateOne.replace(/&lt;/g, ""<"");
        var stateThree = stateTwo.replace(/&gt;/g, "">"");
        var stateFour = stateThree.replace(/&quot;/g, ""'"");
        if (stateFour !== """") {
            document.getElementById(""tarefasProjeto"").innerHTML = stateFour;
        }

        /*Arrastar e Soltar Tarefas no Kanban*/
        const colunas2 = document.querySelectorAll("".coluna"");

        document.addEventListener(""dragstart"", (e) => {
            e.target.classList.add(""dragging"");
        });

        document.addEventListener(""dragend"", (e) => {
            e.target.classList.remove(""dragging"");
        });

        colunas2.forEach((tarefa) => {
            tarefa.addEventListener(""dragover"", (e) => {
                const dragging = document.querySelector("".dragging"");
                const applyAfter = getNewPosition(tarefa, e.clientY);

                if (applyAfter) {
                    applyAfter.insertAdjacentElement(""afterend"",");
            WriteLiteral(@" dragging);
                } else {
                    tarefa.prepend(dragging);
                }
            });
        });

        function getNewPosition(coluna, posY) {
            const cards = coluna.querySelectorAll("".tarefa:not(.dragging)"");
            let result;
            for (let refer_card of cards) {
                const box = refer_card.getBoundingClientRect();
                const boxCenterY = box.y + box.height / 2;
                if (posY >= boxCenterY) result = refer_card;
            }
            return result;
        }
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoKanban.Models.Projeto> Html { get; private set; }
    }
}
#pragma warning restore 1591
