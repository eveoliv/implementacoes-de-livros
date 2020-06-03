#pragma checksum "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Discente\Views\Academico\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752c5d72b607b96f449fee580a2a1ef42322cfe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Discente_Views_Academico_Details), @"mvc.1.0.view", @"/Areas/Discente/Views/Academico/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"752c5d72b607b96f449fee580a2a1ef42322cfe8", @"/Areas/Discente/Views/Academico/Details.cshtml")]
    public class Areas_Discente_Views_Academico_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modelo.Discente.Academico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Discente\Views\Academico\Details.cshtml"
  
    Layout = "_LayoutIES";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <environment include=\"Development\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "752c5d72b607b96f449fee580a2a1ef42322cfe83896", async() => {
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
                WriteLiteral(@"
    </environment>
    <environment exclude=""Development"">
        <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css""
              asp-fallback-href=""~/lib/font-awesome/css/font-awesome.min.css""
              asp-fallback-test-class=""sr-only"" asp-fallback-test-property=""position"" asp-fallback-test-value=""absolute"" />
    </environment>
");
            }
            );
            WriteLiteral(@"
<div class=""card-block"">
    <div class=""card-header text-white bg-secondary text-center h1"">Exibindo um acadêmico existente</div>

    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-9"">
                <div class=""form-group"">
                    <label asp-for=""AcademicoID"" class=""control-label""></label>
                    <br />
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">
                                <i class=""fa fa-key"" aria-hidden=""true""></i>
                            </span>
                        </div>
                        <input asp-for=""AcademicoID"" class=""form-control"" disabled=""disabled"" />
                    </div>
                    <label asp-for=""RegistroAcademico"" class=""control-label""></label>
                    <br />
                    <div class=""input-group"">
                        <div class=""input-gro");
            WriteLiteral(@"up-prepend"">
                            <span class=""input-group-text"">
                                <i class=""fa fa-address-card-o"" aria-hidden=""true""></i>
                            </span>
                        </div>
                        <input asp-for=""RegistroAcademico"" class=""form-control"" disabled=""disabled"" />
                    </div>
                    <label asp-for=""Nome"" class=""control-label""></label>
                    <br />
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">
                                <i class=""fa fa-user-circle-o"" aria-hidden=""true""></i>
                            </span>
                        </div>
                        <input asp-for=""Nome"" class=""form-control"" disabled=""disabled"" />
                    </div>
                    <label asp-for=""Nascimento"" class=""control-label""></label>
                    <br />
      ");
            WriteLiteral(@"              <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text"">
                                <i class=""fa fa-address-card-o"" aria-hidden=""true""></i>
                            </span>
                        </div>
                        <input asp-for=""Nascimento"" class=""form-control"" disabled=""disabled"" />
                    </div>
                </div>
            </div>
            <div class=""col-3"">
                <img class=""img-thumbnail""");
            BeginWriteAttribute("src", " src=\"", 3238, "\"", 3311, 1);
#nullable restore
#line 67 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Discente\Views\Academico\Details.cshtml"
WriteAttributeValue("", 3244, Url.Action("GetFoto", "Academico", new { id = Model.AcademicoID }), 3244, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:block; margin-left:auto;margin-right:auto;\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer bg-info text-center text-white\">\r\n        <a asp-action=\"Edit\" class=\"btn btn-warning\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3538, "\"", 3571, 1);
#nullable restore
#line 72 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Discente\Views\Academico\Details.cshtml"
WriteAttributeValue("", 3553, Model.AcademicoID, 3553, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a> |\r\n        <a asp-action=\"Index\" class=\"btn btn-warning\">Retornar à listagem de acadêmicos</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modelo.Discente.Academico> Html { get; private set; }
    }
}
#pragma warning restore 1591
