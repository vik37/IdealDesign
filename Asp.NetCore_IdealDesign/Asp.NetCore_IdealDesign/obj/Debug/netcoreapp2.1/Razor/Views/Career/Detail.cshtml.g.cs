#pragma checksum "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d06ab99355c36045a81c9c7ac4503cdc934d2cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Career_Detail), @"mvc.1.0.view", @"/Views/Career/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Career/Detail.cshtml", typeof(AspNetCore.Views_Career_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d06ab99355c36045a81c9c7ac4503cdc934d2cd", @"/Views/Career/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d11fed54bc6cfc6dc5a0f5bfe5fdbec42bb42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Career_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CareerVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resume"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(59, 115, true);
            WriteLiteral("\r\n<h2>Detail</h2>\r\n\r\n<div class=\"container my-container\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n");
            EndContext();
            BeginContext(220, 106, true);
            WriteLiteral("            <div class=\"col-md-1 container-model container-model-first\">\r\n                <h3>NAME: <span>");
            EndContext();
            BeginContext(327, 15, false);
#line 13 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
                           Write(Model.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(342, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(344, 14, false);
#line 13 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
                                            Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(358, 78, true);
            WriteLiteral("</span> </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
            BeginContext(482, 85, true);
            WriteLiteral("            <div class=\"col-md-1 container-model\">\r\n                <h3>PHONE: <span>");
            EndContext();
            BeginContext(568, 11, false);
#line 19 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
                            Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(579, 78, true);
            WriteLiteral("</span> </h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
            BeginContext(703, 164, true);
            WriteLiteral("            <div class=\"col-md-1 container-model container-model-description\">\r\n                <h3>DESCRIPTION: </h3>\r\n                <p class=\"text-description\">");
            EndContext();
            BeginContext(868, 17, false);
#line 26 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(885, 201, true);
            WriteLiteral("</p>\r\n            </div>\r\n\r\n            \r\n            <div class=\"col-md-3\"></div>\r\n            \r\n            <div class=\"col-md-1 container-resume\">\r\n                <h3>RESUME:</h3>\r\n                ");
            EndContext();
            BeginContext(1086, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33ab1876c2fb4eaaa13f48c07a1d217d", async() => {
                BeginContext(1150, 12, false);
#line 34 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
                                                                          Write(ViewBag.file);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1110, "~/data/resumes/", 1110, 15, true);
#line 34 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\Detail.cshtml"
AddHtmlAttributeValue("", 1125, ViewBag.file, 1125, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("download", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1166, 1610, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<style type=""text/css"">
    .my-container {
        /*border: 3px solid black;*/
        /*padding: 50px;*/
        margin-top: 210px;
        width: 100%;
        height: auto;
        background-color: #969696;
        padding-left:100px;
    }
    .container-model {
        width: 400px;
        border-bottom: 2px double #ffffff;
        border-top:dashed 1px #fff;
        border-radius:30px;
        margin:2px 0 4px 0;
    }
    .container-model > * {
        color: #1e8294;
        font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
        font-size:32px;
        letter-spacing:1.1px;
    }
    .container-model-description {
        
    }
    .text-description {
        width:340px;
        height: 130px;
        overflow:scroll;
        overflow: auto;
        font-size: 18px;
        color: black;
        text-decoration: underline;
        
        background-color:rgb(225, 221, 225");
            WriteLiteral(@");

    }
    .container-model-first {
        border-top: none;
    }
    
    .container-resume{
        width:auto;
        background-color:black;
        border:2px solid white;
        border-radius:14px;
        box-shadow:rgba(254, 254, 254, 0.80) 15px 10px 70px;
        color:white;
        letter-spacing:0.8px;
        outline-width:medium;
        outline-style:double;
        
    }
    .resume{
        color:rgba(253, 250, 250, 0.80);
        font-size:16px;
    }
    .resume:hover{
        color:rgba(206, 252, 21, 0.79);
    }
 

</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CareerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591