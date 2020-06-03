#pragma checksum "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Instituicao\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1955b2bf2e46122b933f6910d2f4ada51c2de043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cadastros_Views_Instituicao_Delete), @"mvc.1.0.view", @"/Areas/Cadastros/Views/Instituicao/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1955b2bf2e46122b933f6910d2f4ada51c2de043", @"/Areas/Cadastros/Views/Instituicao/Delete.cshtml")]
    public class Areas_Cadastros_Views_Instituicao_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Modelo.Cadastros.Instituicao>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Instituicao\Delete.cshtml"
  
    Layout = "~/Views/Shared/_LayoutIES.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <environment include=\"Development\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1955b2bf2e46122b933f6910d2f4ada51c2de0433955", async() => {
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
              asp-fallback-href=""~/lib/font-awesome/css/all.css""
              asp-fallback-test-class=""sr-only"" asp-fallback-test-property=""position"" asp-fallback-test-value=""absolute"" />
    </environment>
");
            }
            );
            WriteLiteral("\r\n<div class=\"card-block\">\r\n    <div class=\"card-header text-white bg-secondary text-center h1\">Exibindo uma instituição existente</div>\r\n    \r\n");
#nullable restore
#line 21 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Instituicao\Delete.cshtml"
      await Html.RenderPartialAsync("~/Areas/Cadastros/Views/Instituicao/_PartialDetailsContentCard.cshtml", Model); 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card-footer bg-info text-center text-white"">
        <form asp-action=""Delete"">
            <input type=""hidden"" asp-for=""InstituicaoID"" />
            <input type=""submit"" value=""Remover Instituição"" class=""btn btn-light"" />
            <a asp-action=""Index"" class=""btn btn-info"">Retornar à listagem de instituições</a>
        </form>
    </div>
</div>

");
            DefineSection("ScriptPage", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\Everton\Documents\GitHub\implementacoes-de-livros\asp-net-core-mvc\SolucaoCapitulo08-Revisao02\Capitulo05\Areas\Cadastros\Views\Instituicao\Delete.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Modelo.Cadastros.Instituicao> Html { get; private set; }
    }
}
#pragma warning restore 1591
