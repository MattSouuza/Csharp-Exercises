#pragma checksum "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agendamento_Agendar2), @"mvc.1.0.view", @"/Views/Agendamento/Agendar2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agendamento/Agendar2.cshtml", typeof(AspNetCore.Views_Agendamento_Agendar2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f", @"/Views/Agendamento/Agendar2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Agendamento_Agendar2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Finfo-you"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Agendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agendar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("information"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cancel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 172, true);
            WriteLiteral("<main>\r\n\r\n    <section id=\"titles\">\r\n\r\n            <h1><em><strong> Insira As Informações Do Evento </strong></em></h1>\r\n\r\n            <div class=\"h2s\">\r\n\r\n                ");
            EndContext();
            BeginContext(172, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f5944", async() => {
                BeginContext(256, 127, true);
                WriteLiteral("\r\n\r\n                <button type=\"submit\" id=\"Binfo-you\"><h2>Suas Informações</h2></button>\r\n                \r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(390, 1978, true);
            WriteLiteral(@"

                <button><h2>Informações Do Evento</h2></button>
                <button><h2>Pagamento</h2></button>

            </div>

    </section>

    <section id=""important"">
            <h1>Informações Importantes!</h1>
    
            <p>Adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna. Enim lobortis scelerisque fermentum dui faucibus.
            Faucibus purus in massa tempor nec feugiat. Sed viverra tellus in hac habitasse platea dictumst vestibulum.
            Risus pretium quam vulputate dignissim suspendisse in est ante in. Pretium aenean pharetra magna ac placerat vestibulum lectus mauris.
            Varius morbi enim nunc faucibus a. Nisl nisi scelerisque eu ultrices.
            Non curabitur gravida arcu ac tortor. Id ornare arcu odio ut sem nulla.
            Nec ultrices dui sapien eget mi proin sed libero enim. Tempor orci eu lobortis elementum nibh tellus
            molestie nunc non. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tinci");
            WriteLiteral(@"dunt ornare.
            In hendrerit gravida rutrum quisque non tellus orci ac. Aliquam faucibus purus in massa tempor.
            Morbi non arcu risus quis varius quam. Vel fringilla est ullamcorper eget nulla facilisi etiam.
            Suspendisse interdum consectetur libero id faucibus. Eu augue ut lectus arcu bibendum at varius vel pharetra.
            Diam vel quam elementum pulvinar etiam non. Faucibus in ornare quam viverra orci sagittis eu volutpat.
            Eu sem integer vitae justo eget magna. Eu feugiat pretium nibh ipsum consequat nisl vel pretium.
            Urna molestie at elementum eu facilisis sed odio morbi. Sed risus ultricies tristique nulla.
            Ornare lectus sit amet est. Dolor sit amet consectetur adipiscing elit duis tristique sollicitudin.
            Porttitor leo a diam sollicitudin. Pulvinar mattis nunc sed blandit libero.</p>

    </section>

    <section id=""abraco"">

            ");
            EndContext();
            BeginContext(2368, 4464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f10230", async() => {
                BeginContext(2468, 622, true);
                WriteLiteral(@" <!-- Mudar o Action para o que faz o registro do agendamento em si -->

                <fieldset id=""name-section"">

                    <label for=""name-text"">Nome Do Evento:</label>
                    <input type=""text"" name=""nName"" id=""name-text"" maxlength=""100"" required>
                
                </fieldset>

                <div id=""alinha-select"">

                    <fieldset id=""type-section"">
    
                            <label for=""type-select"">Tipo De Evento:</label>
                            <select name=""nType"" id=""type-select"" required> 
                                ");
                EndContext();
                BeginContext(3090, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f11257", async() => {
                    BeginContext(3098, 6, true);
                    WriteLiteral("Balada");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3113, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3147, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f12546", async() => {
                    BeginContext(3155, 9, true);
                    WriteLiteral("Casamento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3173, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3207, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f13838", async() => {
                    BeginContext(3215, 5, true);
                    WriteLiteral("Festa");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3229, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3263, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f15126", async() => {
                    BeginContext(3271, 4, true);
                    WriteLiteral("Show");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3284, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3318, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f16413", async() => {
                    BeginContext(3326, 9, true);
                    WriteLiteral("Convenção");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3344, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3378, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f17705", async() => {
                    BeginContext(3386, 8, true);
                    WriteLiteral("Palestra");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3403, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3437, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f18996", async() => {
                    BeginContext(3445, 20, true);
                    WriteLiteral("Outros (Especificar)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3474, 328, true);
                WriteLiteral(@"
                            </select>

                    </fieldset>
        
                    <fieldset id=""status-section"">
    
                        <label for=""status-select"">Status Do Evento:</label>
                        <select name=""nStatus"" id=""status-select"" required> 
                            ");
                EndContext();
                BeginContext(3802, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f20602", async() => {
                    BeginContext(3810, 14, true);
                    WriteLiteral("Evento Privado");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3833, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3863, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f21896", async() => {
                    BeginContext(3871, 14, true);
                    WriteLiteral("Evento Público");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3894, 308, true);
                WriteLiteral(@"
                        </select>

                    </fieldset>  

                    <fieldset id=""plan-section"">

                            <label for=""plan-select"">Planos:</label>
                            <select name=""nPlan"" id=""plan-select"" required> 
                                ");
                EndContext();
                BeginContext(4202, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f23476", async() => {
                    BeginContext(4210, 6, true);
                    WriteLiteral("Nenhum");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4225, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4259, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f24765", async() => {
                    BeginContext(4267, 19, true);
                    WriteLiteral("Plano De Iluminação");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4295, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4329, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f26068", async() => {
                    BeginContext(4337, 12, true);
                    WriteLiteral("Plano De Som");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4358, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4392, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f27364", async() => {
                    BeginContext(4400, 28, true);
                    WriteLiteral("Plano De Iluminação E De Som");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4437, 2225, true);
                WriteLiteral(@"
                            </select>

                    </fieldset>

                </div>

                </fieldset>
    
                <fieldset id=""number-section"">

                        <label for=""number"">Número De Pessoas No Evento (Aproximadamente):</label>
                        <input type=""number"" name=""nNumber"" id=""number"" min=""10"" max=""250"" step=""10"" placeholder=""Mín. 10, Máx. 250"" required>
                    
                </fieldset>

                <fieldset id=""date-section"">

                        <label for=""date"">Data Do Evento:</label>
                        <input type=""date"" name=""nDate"" id=""date"" min=""2019-12-01"" max=""2020-12-31"" required>
                    
                </fieldset>

                <fieldset id=""timeS-section"">

                        <label for=""time-start"">Horário De Inicialização:</label>
                        <input type=""time"" name=""nTimeS"" id=""time-start"" required>
                
                </fieldse");
                WriteLiteral(@"t>

                <fieldset id=""timeE-section"">

                        <label for=""time-end"">Horário De Termino:</label>
                        <input type=""time"" name=""nTimeE"" id=""time-end"" required>
                
                </fieldset>

                <fieldset id=""mesage"">

                        <label for=""mesage-camp"">Descreva o Evento:</label>
                        <textarea name=""nMesage"" id=""mesage-camp"" cols=""35"" rows=""10"" required></textarea>
                    
                </fieldset>

                <fieldset id=""value"">

                    <label for=""value-text"">Valor Total:</label>
                    <input type=""text"" name=""nValue"" id=""value-text"" value=""R$10.000,00"" readonly>
                    
                </fieldset>

                <fieldset id=""check-section"">

                        <Label for=""check"">Li E Concordo Com Os <a href=""termos.html"">Termos De Contrato</a></Label>
                        <input type=""checkbox"" name=""nCh");
                WriteLiteral("eck\" id=\"check\" required>\r\n                \r\n                </fieldset>\r\n\r\n\r\n<div id=\"alinha\">\r\n\r\n                <div id=\"button\">\r\n\r\n                    <button type=\"submit\"");
                EndContext();
                BeginWriteAttribute("action", " action=\'", 6662, "\'", 6709, 1);
#line 151 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
WriteAttributeValue("", 6671, Url.Action("Agendar3", "Agendamento"), 6671, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6710, 115, true);
                WriteLiteral(">Confirmar</button>\r\n                    \r\n                </div>\r\n                \r\n                \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 45 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
AddHtmlAttributeValue("", 2402, Url.Action("AgendamentoProcesso2", "Agendamento"), 2402, 50, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6832, 28, true);
            WriteLiteral("\r\n            \r\n            ");
            EndContext();
            BeginContext(6860, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3c0c99c2c1eaa927ba930da291a5c2e8bb19c4f33475", async() => {
                BeginContext(6938, 93, true);
                WriteLiteral("\r\n\r\n                    <button type=\"submit\">Voltar</button>\r\n                \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 158 "C:\Users\Pichau\Desktop\Csharp-Exercises\RoleTopMVC\Views\Agendamento\Agendar2.cshtml"
AddHtmlAttributeValue("", 6886, Url.Action("Agendar", "Agendamento"), 6886, 37, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7038, 39, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n    </section>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591