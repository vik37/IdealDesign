#pragma checksum "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1339e6a9bd31c8f762d9d1424ddcabfa21cb1ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Career_DeleteById), @"mvc.1.0.view", @"/Views/Career/DeleteById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Career/DeleteById.cshtml", typeof(AspNetCore.Views_Career_DeleteById))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1339e6a9bd31c8f762d9d1424ddcabfa21cb1ff8", @"/Views/Career/DeleteById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d11fed54bc6cfc6dc5a0f5bfe5fdbec42bb42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Career_DeleteById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CareerVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-yes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Career", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(59, 362, true);
            WriteLiteral(@"
<h2>Delete</h2>

<div class=""container my-container"">
    <div class=""col-md-12"">
        <div class=""col-md-3""></div>
        <div class=""col-md-1 container-questionBlock"">
            <h5>Are you sure?</h5>
            <div class=""row""></div>
            <div class=""container-yesNo"">
                <div class=""col-md-1 yes"">
                    ");
            EndContext();
            BeginContext(421, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5721a40e556a437eb16a39b1652734c5", async() => {
                BeginContext(526, 99, true);
                WriteLiteral("\r\n                        <input class=\"ask-yes\" type=\"submit\" value=\"YES\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(632, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(682, 406, true);
            WriteLiteral(@"                </div>
                <div class=""col-md-8""></div>
                <div class=""col-md-1 no"">                                                                
                    <p class=""ask-no"">NO</p>
                </div>
            </div>
        </div>
        <div class=""row""></div>
        <div class=""container-main"">
            <div class=""col-md-2"">
                ");
            EndContext();
            BeginContext(1089, 25, false);
#line 30 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
           Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1133, 29, false);
#line 31 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
           Write(Html.HiddenFor(x => x.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 96, true);
            WriteLiteral("\r\n                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1259, 37, false);
#line 34 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayNameFor(x => x.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1376, 33, false);
#line 37 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayFor(x => x.Firstname));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1489, 36, false);
#line 40 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayNameFor(x => x.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1605, 32, false);
#line 43 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayFor(x => x.Lastname));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 79, true);
            WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1717, 33, false);
#line 46 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayNameFor(x => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 79, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1830, 29, false);
#line 49 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                   Write(Html.DisplayFor(x => x.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 190, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-md-6\"></div>\r\n            <div class=\"col-md-4\">\r\n                <h6 class=\"description\">");
            EndContext();
            BeginContext(2050, 39, false);
#line 55 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
            BeginContext(2124, 44, true);
            WriteLiteral("                <p class=\"description-text\">");
            EndContext();
            BeginContext(2169, 35, false);
#line 57 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\Career\DeleteById.cshtml"
                                       Write(Html.DisplayFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 2682, true);
            WriteLiteral(@"</p>
             </div>   
        </div>
        
    </div>
</div>
<style type=""text/css"">
    .my-container {
        /*border: 3px solid black;*/
        /*padding: 50px;*/
        margin-top: 240px;
        width: 100%;
        height: auto;
        background-color: #969696;
        padding: 0 50px 0 50px;
    }
    .container-questionBlock {
        background-color: rgba(198, 208, 165, 0.27);
        width: 600px;
        text-align: center;
        padding-bottom: 12px;
        
    }
    h5 {
        font-size: 30px;
        color:rgba(255, 131, 0,0.78);
        text-shadow:2px 1px 1px rgb(71, 60, 160);
        letter-spacing:2.1px;
    }  
    .yes{
        background-color:rgb(255, 0, 0);
        width:80px;
        height:70px;
        outline-style:outset;
        outline-width:4px;
        outline-color:blueviolet;
        border:3px solid black;
        padding: 0;
    }
    .yes:active{
        border:6px solid black;
    }
    .no {
        backgro");
            WriteLiteral(@"und-color: rgb(68, 194, 62);
        width: 80px;
        height: 70px;
        text-align: center;
        margin-left: 30px;
        outline-style: outset;
        outline-width: 4px;
        outline-color: blueviolet;
        border: 3px solid black;
        cursor:pointer;        
    }
    .no:active{
        border:6px solid black;
    }
    .ask-no{
        font-size:25px;
        font-weight:bolder;
        margin: 15px auto;
        text-shadow:1px 2px 2px blueviolet;
    }   
    .ask-yes {
        font-size: 25px;
        font-weight: bolder;        
        width: 100%;
        height: 61px;
        text-shadow: 1px 2px 2px blueviolet;
        left: 1px;
        background-color: rgb(255, 0, 0);
        border:none;
        outline:none;
    }
   
    .dl-horizontal {
        width: 300px;
        color: white;
    }
    
    .description{
        font-size:22px;
        font-weight:800;
       
    }
    .description-text {
        width: 260px;
       ");
            WriteLiteral(@" height: 100px;
        overflow-y: scroll;
        background-color: rgb(255, 255, 255);
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        font-size: 15px;
        text-decoration: underline;
        outline:10px double rgba(54, 29, 29, 0.26);
        
        border-radius: 15px;
        text-align: center;
    }
</style>
<script type=""text/javascript"">
    let noBlock = document.getElementsByClassName(""no"")[0];
    console.log(noBlock);
    noBlock.addEventListener(""click"", function () {
        window.location.href = ""https://localhost:44313/Career/Applicants"";
    })
</script>");
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