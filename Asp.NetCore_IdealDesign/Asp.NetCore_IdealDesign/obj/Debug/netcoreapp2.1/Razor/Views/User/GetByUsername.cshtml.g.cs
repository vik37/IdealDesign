#pragma checksum "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09f2de1a33f44cdebdd528131318c058c9135b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetByUsername), @"mvc.1.0.view", @"/Views/User/GetByUsername.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetByUsername.cshtml", typeof(AspNetCore.Views_User_GetByUsername))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f2de1a33f44cdebdd528131318c058c9135b8e", @"/Views/User/GetByUsername.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ef4f3a02156cbf08c03b3f75fdad08ec9b640b2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetByUsername : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group labelImg fas fa-camera-retro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Photos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Photos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString("image/jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-typeOfProducts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetByUsername", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-applicants"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Career", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Applicants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
  
    ViewData["Title"] = Model.Username;

#line default
#line hidden
            BeginContext(97, 79, true);
            WriteLiteral("<div class=\"container my-container\">\r\n    <div class=\"col-md-12\">\r\n        <h2>");
            EndContext();
            BeginContext(177, 17, false);
#line 9 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(194, 21, true);
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(254, 65, true);
            WriteLiteral("    <div class=\"row\"></div>\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(319, 1640, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5c0907250e418e82199524373ba27f", async() => {
                BeginContext(461, 49, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                ");
                EndContext();
                BeginContext(510, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88d6775dcbab42f5bccaedd8d812efbe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 18 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(546, 22, true);
                WriteLiteral("\r\n\r\n\r\n                ");
                EndContext();
                BeginContext(568, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d79d0b2bb07a4534968d51ef5069bd59", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 21 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Username);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(610, 20, true);
                WriteLiteral("\r\n\r\n                ");
                EndContext();
                BeginContext(630, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f95bd68801184898bd350a81916007ec", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 23 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fullname);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(672, 158, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\"></div>\r\n                <div class=\"col-md-2\"></div>\r\n                <div class=\"input-group\">\r\n                    ");
                EndContext();
                BeginContext(831, 140, false);
#line 27 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
               Write(Html.DropDownListFor(product => product.ProductType, Html.GetEnumSelectList(Model.ProductType.GetType()), new { @class = "typeOfProducts" }));

#line default
#line hidden
                EndContext();
                BeginContext(971, 252, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <div class=\"row\">\r\n                <div class=\"col-md-10\"></div>\r\n                <div class=\"col-md-2\"></div>\r\n                <div class=\"upload\">\r\n\r\n                    ");
                EndContext();
                BeginContext(1223, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d29560ccb3b49f68761bf5e15cd0cf7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 37 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photos);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1304, 32, true);
                WriteLiteral("\r\n                    <br />\r\n\r\n");
                EndContext();
                BeginContext(1395, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1415, 147, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "450f870dae874930b32bbac8b9e05d0b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 41 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photos);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1562, 277, true);
                WriteLiteral(@"

                </div>
            </div>

            <br />
            <div class=""row"">
                <div class=""col-md-10""></div>
                <div class=""col-md-4"">
                    <button type=""submit"" class=""btn btn-info"" disabled>Upload</button>
");
                EndContext();
                BeginContext(1900, 52, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1959, 204, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-md-6\"></div>\r\n    <div class=\"col-md-1 container-nav\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item-text navbar-collapse\">\r\n                ");
            EndContext();
            BeginContext(2163, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c0469944a2f43d3a19b4c5bc5242e0d", async() => {
                BeginContext(2250, 50, true);
                WriteLiteral("\r\n                    APPLICANTS\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2304, 235, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n\r\n    </div>\r\n\r\n    <div class=\"row\"></div>\r\n    <div class=\"col-md-1\"></div>\r\n    <div class=\"container-msg  col-md-4\">\r\n        <p class=\"upload-msg\"></p>\r\n        <p class=\"text-danger error-msg\">");
            EndContext();
            BeginContext(2540, 18, false);
#line 74 "C:\Users\vikto\source\repos\Prof_Projects\Asp.NetCore_IdealDesign\Asp.NetCore_IdealDesign\Views\User\GetByUsername.cshtml"
                                    Write(ViewBag.ImageError);

#line default
#line hidden
            EndContext();
            BeginContext(2558, 5373, true);
            WriteLiteral(@"</p>
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
        padding-left: 130px;
    }

    h2 {
        font-size: 28px;
        color: rgba(64, 160, 219,0.8);
        text-shadow: 2px 2px 2px #fff;
        letter-spacing: 3px;
        text-decoration: underline;
        font-family: 'Felix Titling';
        font-weight: 600;
        background-color: rgba(0, 0, 0, 0.64);
        text-align: center;
        width: 270px;
        height: 75px;
        margin: 0 auto;
        padding: 20px;
        border-radius: 60px;
        border-left: 10px solid black;
        border-right: 10px solid black;
    }

    .form-typeOfProducts {
        border: 6px groove;
        width: 500px;
        margin: 8px;
        padding: 5px 50px;
        background-color: black;
        border-radius: 30px;");
            WriteLiteral(@"
    }

    .typeOfProducts {
        width: 250px;
        height: 34px;
        border: 5px ridge #e6e4aa;
        border-radius: 10px;
        font-size: 19px;
        font-family: 'Times New Roman', Times, serif;
        letter-spacing: 2px;
        outline: none;
        margin: 0 90px;
    }

        .typeOfProducts > * {
            border-radius: 10px;
            background-color: black;
            color: white;
        }

        .typeOfProducts:hover {
            color: #3ec20e;
            background-color: rgba(0, 0, 0, 0.67);
        }

    label {
        font-size: 28px;
        color: white;
        text-shadow: 2px 2px 4px #0ea4c2;
        margin-bottom: 10px;
        cursor: pointer;
        background-image: repeating-linear-gradient(to right, rgba(225, 174, 33,0.59) 10%, rgba(192, 212, 11, 0.69) 10%, rgba(142, 12, 220,0.47) 20%);
        border: inset 4px white;
        border-bottom-right-radius: 10px;
        border-top-right-radius: 10px;
        wi");
            WriteLiteral(@"dth: 200px;
        height: 50px;
        text-align: center;
        padding-top: 5px;
    }

    .fa-camera-retro::before {
        margin-right: 14px;
        background-color: rgba(181, 129, 0, 0.78);
        border: 1px outset rgba(255, 151, 82,0.70);
        border-radius: 2px;
        text-decoration: underline;
    }

    .upload {
        width: 300px;
        height: 100px;
        padding: 20px 15px;
        margin: 0 100px;
    }

    input[type=""file""] {
        display: none;
    }

    .btn {
        margin: 0 120px;
        width: 150px;
    }

    .container-msg {
        width: 25%;
        height: auto;
        background-color: rgba(255, 255, 255, 0.68);
        color: green;
        font-size: 18px;
        text-align: center;
        text-shadow: 1px 2px 2px rgb(255, 255, 255);
        font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
        margin: 5px auto;
        padding-top: 10px;
        border-left: 10px dashed blac");
            WriteLiteral(@"k;
        border-right: 10px double black;
        border-radius: 30px;
    }

    .container-nav {
        width: 190px;
        background-color: #000000;
        border: 4px double rgba(255, 255, 255, 0.96);
        box-shadow: rgba(255, 255, 255,0.89) -20px -10px 60px inset;
    }

    ul {
        list-style-type: georgian;
    }

    .link-applicants {
        color: #fff703;
        font-size: 18px;
        text-shadow: -2px -2px 2px #dd03ff;
        letter-spacing: 1.4px;
    }

    .link-applicants:hover {
        color: #ffffff;
        font-size: 21px;
        box-shadow: rgba(255, 255, 255,0.89) -30px -30px 60px;
        width: 100px;
    }
    
</style>

<script type=""text/javascript"">


    let label = document.getElementsByClassName(""labelImg"")[0];
    let upload = document.getElementsByClassName(""image"")[0];
    let uploadMsg = document.getElementsByClassName(""upload-msg"")[0];
    let errorMsg = document.getElementsByClassName(""error-msg"")[0];

    //if");
            WriteLiteral(@" (errorMsg.value === """") {
    //    document.getElementsByClassName("".container-msg"")[0].outerHTML.
    //}


    upload.addEventListener(""change"", function () {

        if (upload.value.length !== 0) {
            let fileName = upload.value;
            let idxDot = fileName.lastIndexOf(""."") + 1;
            let extFile = fileName.substring(idxDot, fileName.length).toLowerCase();

            //console.log(idxDot);

            if ((extFile === ""jpg"") || (extFile === ""JPG"")
                || (extFile === ""JPEG"") || (extFile === ""jpeg"")) {
                uploadMsg.textContent = upload.value;
                document.getElementsByClassName(""btn"")[0].disabled = false;
                errorMsg.textContent = """";
            }
            else {
                errorMsg.textContent = ""Files are NOT allowed. Only jpg/jpeg files are allowed!"";
                upload.value = """";
                uploadMsg.textContent = """";
                document.getElementsByClassName(""btn"")[0].disabled ");
            WriteLiteral("= true;\r\n            }\r\n        }\r\n        else {\r\n            errorMsg.textContent = \"Please select file\";\r\n            uploadMsg.textContent = \"\";\r\n            document.getElementsByClassName(\"btn\")[0].disabled = true;\r\n        }\r\n\r\n    });\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer _local { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
