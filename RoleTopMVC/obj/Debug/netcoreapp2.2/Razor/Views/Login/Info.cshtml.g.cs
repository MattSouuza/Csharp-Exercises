#pragma checksum "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05039d63a5a9a63261ac7fba0041bda3e7b9e92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Info), @"mvc.1.0.view", @"/Views/Login/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Info.cshtml", typeof(AspNetCore.Views_Login_Info))]
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
#line 1 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05039d63a5a9a63261ac7fba0041bda3e7b9e92c", @"/Views/Login/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.InfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("voltar-botao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
  
    ViewData["H2"] = "Informações Da Conta";

#line default
#line hidden
            BeginContext(97, 60, true);
            WriteLiteral("\r\n<main>\r\n\r\n    <header>\r\n        <hgroup>\r\n            <h1>");
            EndContext();
            BeginContext(158, 17, false);
#line 10 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
           Write(Model.UsuarioNome);

#line default
#line hidden
            EndContext();
            BeginContext(175, 23, true);
            WriteLiteral("</h1>\r\n            <h2>");
            EndContext();
            BeginContext(199, 14, false);
#line 11 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
           Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(213, 107, true);
            WriteLiteral("</h2>\r\n        </hgroup>\r\n    </header>\r\n\r\n\r\n    <div id=\"tabela\">\r\n        <div id=\"alinha\">\r\n            ");
            EndContext();
            BeginContext(320, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05039d63a5a9a63261ac7fba0041bda3e7b9e92c5020", async() => {
                BeginContext(400, 77, true);
                WriteLiteral("\r\n                <button type =\"submit\"><p>Voltar</p></button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 18 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
AddHtmlAttributeValue("", 352, Url.Action("PagUsuario","Login"), 352, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 319, true);
            WriteLiteral(@"

            <table>
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>Email</th>
                        <th>Telefone</th>
                        <th>CPF/CNPJ</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 32 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                     foreach( var cliente in Model.Clientes )
                    {

#line default
#line hidden
            BeginContext(889, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(952, 12, false);
#line 35 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                           Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(964, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1004, 13, false);
#line 36 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                           Write(cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1057, 16, false);
#line 37 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                           Write(cliente.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1113, 11, false);
#line 38 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                           Write(cliente.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(1124, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Login\Info.cshtml"
                    }

#line default
#line hidden
            BeginContext(1185, 89, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.InfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
