#pragma checksum "D:\Downloads\Сане\School\School\Views\News\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aec4648ce70f5c87a664ef74f365eb065d1cda0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_News), @"mvc.1.0.view", @"/Views/News/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/News.cshtml", typeof(AspNetCore.Views_News_News))]
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
#line 1 "D:\Downloads\Сане\School\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#line 1 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
using School.Models;

#line default
#line hidden
#line 2 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
using School.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aec4648ce70f5c87a664ef74f365eb065d1cda0", @"/Views/News/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_News_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowNewsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/News/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsLnk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 28, true);
            WriteLiteral("\r\n<h2>События</h2>\r\n<br />\r\n");
            EndContext();
#line 7 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
 if (Model.UsrRole == "Администратор")
{

#line default
#line hidden
            BeginContext(140, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(144, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aedab121f2344e20ae8e6d23cd02887e", async() => {
                BeginContext(165, 16, true);
                WriteLiteral("Добавить событие");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 14, true);
            WriteLiteral("\r\n    <br />\r\n");
            EndContext();
#line 11 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
}

#line default
#line hidden
#line 12 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
 foreach (NewsMdl n in Model.NewsMdls)
{

#line default
#line hidden
            BeginContext(245, 23, true);
            WriteLiteral("    <div>\r\n        <h3>");
            EndContext();
            BeginContext(268, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d94065dd5e649d7829957f5010a11f1", async() => {
                BeginContext(308, 7, false);
#line 15 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
                                              Write(n.Title);

#line default
#line hidden
                EndContext();
                BeginContext(315, 2, true);
                WriteLiteral("  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 293, "~/News/", 293, 7, true);
#line 15 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
AddHtmlAttributeValue("", 300, n.Id, 300, 5, false);

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
            BeginContext(321, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 16 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
         if (n.Text.Length > 100)
        {
            n.Text = n.Text.Substring(0, 100) + "...";
            

#line default
#line hidden
#line 19 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
             foreach (string str in n.Text.Split(Environment.NewLine))
            {

#line default
#line hidden
            BeginContext(517, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(537, 3, false);
#line 21 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
              Write(str);

#line default
#line hidden
            EndContext();
            BeginContext(540, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
            }

#line default
#line hidden
#line 22 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
             

        }
        else
        {
            

#line default
#line hidden
#line 27 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
             foreach (string str in n.Text.Split(Environment.NewLine))
            {

#line default
#line hidden
            BeginContext(686, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(706, 3, false);
#line 29 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
              Write(str);

#line default
#line hidden
            EndContext();
            BeginContext(709, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 30 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
            }

#line default
#line hidden
#line 30 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
             
        }

#line default
#line hidden
            BeginContext(741, 44, true);
            WriteLiteral("        <br />\r\n        <p class=\"postDate\">");
            EndContext();
            BeginContext(786, 29, false);
#line 33 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"
                       Write(n.PostDT.ToString("dd.MM.yy"));

#line default
#line hidden
            EndContext();
            BeginContext(815, 50, true);
            WriteLiteral("</p>\r\n        <hr />\r\n        <br />\r\n    </div>\r\n");
            EndContext();
#line 37 "D:\Downloads\Сане\School\School\Views\News\News.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowNewsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
