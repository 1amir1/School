#pragma checksum "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c29aeacb4c7a9fb8bbe3672852646cbdca562b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Accounts), @"mvc.1.0.view", @"/Views/Account/Accounts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Accounts.cshtml", typeof(AspNetCore.Views_Account_Accounts))]
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
#line 1 "D:\Downloads\Сане\на хостинг\School\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#line 5 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
using School.Models;

#line default
#line hidden
#line 6 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
using School.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c29aeacb4c7a9fb8bbe3672852646cbdca562b8", @"/Views/Account/Accounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Accounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowAccVM>
    {
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
   
    ViewData["Title"] = "Аккаунты";

#line default
#line hidden
            BeginContext(115, 215, true);
            WriteLiteral("\r\n\r\n<h2>Аккаунты</h2>\r\n<br/>\r\n<table class=\"accTbl\">\r\n    <tr>\r\n        <td>Id</td>\r\n        <td>Логин</td>\r\n        <td>Имя</td>\r\n        <td>Фамилия</td>\r\n        <td>Почта</td>\r\n        <td>Роль</td>\r\n    </tr>\r\n");
            EndContext();
#line 21 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
    foreach (User u in Model.Users)
    {
        

#line default
#line hidden
            BeginContext(384, 26, true);
            WriteLiteral("    <tr>\r\n            <td>");
            EndContext();
            BeginContext(410, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfa47aa18824a128f54f903499d5d0c", async() => {
                BeginContext(441, 7, false);
#line 25 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.UsrId);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 419, "~/Accounts/", 419, 11, true);
#line 25 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 430, u.UsrId, 430, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(475, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "873af1e7cc154fa0913fe4b81eeed46a", async() => {
                BeginContext(506, 7, false);
#line 26 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.Login);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 484, "~/Accounts/", 484, 11, true);
#line 26 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 495, u.UsrId, 495, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(517, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(540, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38b7d7f38764373a218bc767b19bafa", async() => {
                BeginContext(571, 11, false);
#line 27 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.FirstName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 549, "~/Accounts/", 549, 11, true);
#line 27 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 560, u.UsrId, 560, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(586, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(609, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05258dc945ff46ebbea185886e773f79", async() => {
                BeginContext(640, 10, false);
#line 28 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 618, "~/Accounts/", 618, 11, true);
#line 28 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 629, u.UsrId, 629, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(654, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(677, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55efe30f7044baea37306ffe20a2283", async() => {
                BeginContext(708, 6, false);
#line 29 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.Mail);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 686, "~/Accounts/", 686, 11, true);
#line 29 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 697, u.UsrId, 697, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(718, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(741, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc16f6dc20634db59ae47793eca300ca", async() => {
                BeginContext(772, 18, false);
#line 30 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
                                         Write(u.UsrRole.RoleName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 750, "~/Accounts/", 750, 11, true);
#line 30 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
AddHtmlAttributeValue("", 761, u.UsrId, 761, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(794, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 32 "D:\Downloads\Сане\на хостинг\School\School\Views\Account\Accounts.cshtml"
        
    }

#line default
#line hidden
            BeginContext(829, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowAccVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
