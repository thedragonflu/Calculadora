#pragma checksum "C:\Users\erick\Source\Repos\thedragonflu\Calculadora\Prueba1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ad701ccb46eb829f384bd87946a2b46f2c63ab9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Prueba1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Prueba1.Pages
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
#line 1 "C:\Users\erick\Source\Repos\thedragonflu\Calculadora\Prueba1\Pages\_ViewImports.cshtml"
using Prueba1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ad701ccb46eb829f384bd87946a2b46f2c63ab9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9e5bd26354907ccc2725f5114993910a20cec5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("calculator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\erick\Source\Repos\thedragonflu\Calculadora\Prueba1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Calculadora";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center container row"">
    <!-- <form name=""calculator"">
        <br />
        <div class=""form-group"">
            <h3>Calculadora</h3>
            <input class=""col-sm-6"" type=""textfield"" name=""ans"" value="""">
        </div>

        <input class=""col-sm-3"" type=""button"" value=""1"" onClick=""document.calculator.ans.value+='1'"">
        <input class=""col-sm-3"" type=""button"" value=""2"" onClick=""document.calculator.ans.value+='2'"">
        <input class=""col-sm-3"" type=""button"" value=""3"" onClick=""document.calculator.ans.value+='3'"">
        <input class=""col-sm-2 bg-secondary text-light"" type=""button"" value=""+"" onClick=""document.calculator.ans.value+='+'"">

        <input class=""col-sm-3"" type=""button"" value=""4"" onClick=""document.calculator.ans.value+='4'"">
        <input class=""col-sm-3"" type=""button"" value=""5"" onClick=""document.calculator.ans.value+='5'"">
        <input class=""col-sm-3"" type=""button"" value=""6"" onClick=""document.calculator.ans.value+='6'"">
        <input class=""");
            WriteLiteral(@"col-sm-2 bg-secondary text-light"" type=""button"" value=""-"" onClick=""document.calculator.ans.value+='-'"">

        <input class=""col-sm-3"" type=""button"" value=""7"" onClick=""document.calculator.ans.value+='7'"">
        <input class=""col-sm-3"" type=""button"" value=""8"" onClick=""document.calculator.ans.value+='8'"">
        <input class=""col-sm-3"" type=""button"" value=""9"" onClick=""document.calculator.ans.value+='9'"">
        <input class=""col-sm-2 bg-secondary text-light"" type=""button"" value=""*"" onClick=""document.calculator.ans.value+='*'"">

        <input class=""col-sm-3 bg-danger text-light"" type=""reset"" value=""c"">
        <input class=""col-sm-3"" type=""button"" value=""0"" onClick=""document.calculator.ans.value+='0'"">
        <input class=""col-sm-3 bg-secondary text-light"" type=""button"" value=""/"" onClick=""document.calculator.ans.value+='/'"">
        <input class=""col-sm-2 bg-secondary text-light"" type=""button"" value=""="" onClick=""document.calculator.ans.value=eval(document.calculator.ans.value)"">
    </form> -");
            WriteLiteral("->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ad701ccb46eb829f384bd87946a2b46f2c63ab95825", async() => {
                WriteLiteral(@"
        <br />
        <div class=""form-group"">
            <h1 class=""text-center"">Calculadora</h1>
            <div class=""row"">
                <div class=""col-sm-3"">
                    <label>Número 1:</label>
                </div>
                <div class=""col-sm-3"">
                    <input type=""text"" name=""num1"" onkeypress=""document.calculator.resul.value+=document.calculator.num1.value""/>
                </div>
            </div>
            <br />
            <input class=""col-sm-2"" type=""button"" value=""+"" onclick=""document.calculator.resul.value+='+'"" />
            <input class=""col-sm-2"" type=""button"" value=""-"" onclick=""document.calculator.resul.value+='-'"" />
            <input class=""col-sm-2"" type=""button"" value=""*"" onclick=""document.calculator.resul.value+='*'"" />
            <input class=""col-sm-2"" type=""button"" value=""/"" onclick=""document.calculator.resul.value+='/'"" />
            <br />
            <br />
            <div class=""row"">
                <div class=");
                WriteLiteral(@"""col-sm-3"">
                    <label>Número 2:</label>
                </div>
                <div class=""col-sm-3"">
                    <input type=""text"" name=""num2"" onkeypress=""document.calculator.resul.value+=document.calculator.num2.value""/>
                </div>
            </div>
            <br />
            <input class=""col-sm-2"" type=""button"" value=""="" onclick=""document.calculator.resul.value=eval(document.calculator.resul.value)"" />
            <br />
            <br />
            <div class=""row"">
                <div class=""col-sm-3"">
                    <label>Operación:</label>
                </div>
                <div class=""col-sm-3"">
                    <input type=""text"" name=""resul"" />
                </div>
            </div>
            <br />
            <input class=""col-sm-2 btn-danger"" type=""reset"" value=""C"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
