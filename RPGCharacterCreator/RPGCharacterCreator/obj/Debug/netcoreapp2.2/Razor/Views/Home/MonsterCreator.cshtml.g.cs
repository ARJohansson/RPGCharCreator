#pragma checksum "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\MonsterCreator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f24ddd16d8d728019eba43305154184d48d323"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MonsterCreator), @"mvc.1.0.view", @"/Views/Home/MonsterCreator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MonsterCreator.cshtml", typeof(AspNetCore.Views_Home_MonsterCreator))]
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
#line 1 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\_ViewImports.cshtml"
using RPGCharacterCreator;

#line default
#line hidden
#line 2 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\_ViewImports.cshtml"
using RPGCharacterCreator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f24ddd16d8d728019eba43305154184d48d323", @"/Views/Home/MonsterCreator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a998b5dadced4b0cb34ebc3eae36abc34bf931", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MonsterCreator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<String>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(182, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\MonsterCreator.cshtml"
  
    Layout = "_Navigation";
    ViewData["Title"] = "Monster";

#line default
#line hidden
            BeginContext(271, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(273, 1503, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f24ddd16d8d728019eba43305154184d48d3235034", async() => {
                BeginContext(279, 10, true);
                WriteLiteral("\r\n    <h2>");
                EndContext();
                BeginContext(290, 5, false);
#line 15 "C:\Users\Ashley Johansson\Documents\Lanecc\CS295N\Project\rpgCharCreator\RPGCharCreator\RPGCharacterCreator\RPGCharacterCreator\Views\Home\MonsterCreator.cshtml"
   Write(Model);

#line default
#line hidden
                EndContext();
                BeginContext(295, 241, true);
                WriteLiteral(" Welcome to the Monster (Creature) Creator Form! Here you can create a new monster</h2>\r\n    <h2>Just fill out any of the fields below to build your character.</h2>\r\n    <h3>Be sure to press save in order to keep your information.</h3>\r\n    ");
                EndContext();
                BeginContext(536, 1169, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f24ddd16d8d728019eba43305154184d48d3236085", async() => {
                    BeginContext(596, 1102, true);
                    WriteLiteral(@"
        <label for=""name"">Name</label>
        <input name=""name"" /><br />
        <label for=""species"">Species</label>
        <input name=""species"" /><br />
        <label for=""gender"">Gender</label>
        <input name=""gender"" /><br />
        <label for=""description"">Description</label><br />
        <textarea name=""description"" rows=""3"" cols=""100""></textarea><br />
        <label for=""ability1"">First Ability</label><br />
        <textarea name=""ability1"" rows=""2"" cols=""100""></textarea><br />
        <label for=""ability2"">Second Ability</label><br />
        <textarea name=""ability2"" rows=""2"" cols=""100""></textarea><br />
        <label for=""ability3"">Third Ability</label><br />
        <textarea name=""ability3"" rows=""2"" cols=""100""></textarea><br />
        <label for=""ability4"">Fourth Ability</label><br />
        <textarea name=""ability4"" rows=""2"" cols=""100""></textarea><br />
        <label for=""ability5"">Fifth Ability</label><br />
        <textarea name=""ability5"" rows=""2"" cols=""10");
                    WriteLiteral("0\"></textarea><br /><br />\r\n        <input type=\"submit\" value=\"Save\" />\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1705, 64, true);
                WriteLiteral("\r\n    <a href=\"Home/Member\"></a>\r\n    <p>Form coming soon.</p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<String> Html { get; private set; }
    }
}
#pragma warning restore 1591
