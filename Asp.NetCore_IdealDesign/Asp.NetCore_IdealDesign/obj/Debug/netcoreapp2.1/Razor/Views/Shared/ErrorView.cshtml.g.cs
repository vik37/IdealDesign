#pragma checksum "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Shared\ErrorView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f93baa056ed744304a1a7b2af1127338c40338b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorView), @"mvc.1.0.view", @"/Views/Shared/ErrorView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ErrorView.cshtml", typeof(AspNetCore.Views_Shared_ErrorView))]
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
#line 1 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using Asp.NetCore_IdealDesign;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using Asp.NetCore_IdealDesign.Models;

#line default
#line hidden
#line 3 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using IdealDesign_WebModels;

#line default
#line hidden
#line 4 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using IdealDesign_Domain.Models;

#line default
#line hidden
#line 5 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using IdealDesign_WebModels.VewModels;

#line default
#line hidden
#line 6 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using IdealDesign_WebModels.EnumsVM;

#line default
#line hidden
#line 7 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f93baa056ed744304a1a7b2af1127338c40338b", @"/Views/Shared/ErrorView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef4f3a02156cbf08c03b3f75fdad08ec9b640b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Shared\ErrorView.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
            BeginContext(48, 275, true);
            WriteLiteral(@"

    <div class=""container my-container"">
        <div id=""notfound"">
            <div class=""notfound"">
                <div class=""notfound-404"">
                    <h1>404</h1>
                    <h2>Page not found!</h2>
                </div>
                ");
            EndContext();
            BeginContext(323, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1f23e3e82b6478fab538fdd8c6e796a", async() => {
                BeginContext(387, 8, true);
                WriteLiteral("Homepage");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 807, true);
            WriteLiteral(@"
            </div>
        </div>

    </div>

    <style type=""text/css"">
        .my-container {
            /*border: 3px solid black;*/
            /*padding: 50px;*/
            margin-top: 250px;
            width: 100%;
            height: auto;
            background-color: #969696;
            text-align: center;
        }

        .notfound-404 {
            letter-spacing:2px;
            color: rgb(218, 0, 0);
        }
        h1 {
            font-size: 46px;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        }
        h2{
            font-size:38px;
            background-color:rgb(0, 0, 0);
            text-decoration:underline;
            text-shadow:1px 1px 1px rgb(255, 255, 255);
        }
    </style>
");
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
