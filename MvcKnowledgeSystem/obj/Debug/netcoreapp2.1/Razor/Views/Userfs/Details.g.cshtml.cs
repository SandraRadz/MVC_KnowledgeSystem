#pragma checksum "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aba6e738d652872bcb0571e313eba5ec15cffbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Userfs_Details), @"mvc.1.0.view", @"/Views/Userfs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Userfs/Details.cshtml", typeof(AspNetCore.Views_Userfs_Details))]
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
#line 1 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\_ViewImports.cshtml"
using MvcKnowledgeSystem;

#line default
#line hidden
#line 2 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\_ViewImports.cshtml"
using MvcKnowledgeSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aba6e738d652872bcb0571e313eba5ec15cffbd", @"/Views/Userfs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64aeb9e94572f309eddc578b7a6b223098102d8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Userfs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcKnowledgeSystem.Models.Userf>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(85, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Userf</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(205, 40, false);
#line 14 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 36, false);
#line 17 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(369, 40, false);
#line 20 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.role));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(453, 36, false);
#line 23 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayFor(model => model.role));

#line default
#line hidden
            EndContext();
            BeginContext(489, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(533, 43, false);
#line 26 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SkillId));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(620, 39, false);
#line 29 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayFor(model => model.SkillId));

#line default
#line hidden
            EndContext();
            BeginContext(659, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(703, 41, false);
#line 32 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.login));

#line default
#line hidden
            EndContext();
            BeginContext(744, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(788, 37, false);
#line 35 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayFor(model => model.login));

#line default
#line hidden
            EndContext();
            BeginContext(825, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(869, 44, false);
#line 38 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(913, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(957, 40, false);
#line 41 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
       Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(997, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1044, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38fafbcdcb3146ab94d9ea6e1356537d", async() => {
                BeginContext(1094, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\oleks\source\repos\MvcKnowledgeSystem\MvcKnowledgeSystem\Views\Userfs\Details.cshtml"
                           WriteLiteral(Model.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1102, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1110, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a60d539dc68b4e969180eb4935701c95", async() => {
                BeginContext(1132, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1148, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcKnowledgeSystem.Models.Userf> Html { get; private set; }
    }
}
#pragma warning restore 1591