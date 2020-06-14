#pragma checksum "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5676ba89d384fb01a62db3093ca0ec6a68b55ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_ShowReviews), @"mvc.1.0.view", @"/Views/Review/ShowReviews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Review/ShowReviews.cshtml", typeof(AspNetCore.Views_Review_ShowReviews))]
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
#line 1 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
using School.Models;

#line default
#line hidden
#line 2 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
using School.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5676ba89d384fb01a62db3093ca0ec6a68b55ab", @"/Views/Review/ShowReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Review_ShowReviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShowReviewsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Reviews/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(72, 29, true);
            WriteLiteral("\r\n\r\n<h2>Отзывы</h2>\r\n<br />\r\n");
            EndContext();
#line 8 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
 if (Model.LoggedIn && Model.UsrRole == "Пользователь")
{

#line default
#line hidden
            BeginContext(161, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(165, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5214b69f2209411da6336981feee5945", async() => {
                BeginContext(189, 14, true);
                WriteLiteral("Оставить отзыв");
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
            BeginContext(207, 14, true);
            WriteLiteral("\r\n    <br />\r\n");
            EndContext();
#line 12 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
}

#line default
#line hidden
            BeginContext(224, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 16 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
 foreach (Review rv in Model.Reviews)
{

#line default
#line hidden
            BeginContext(278, 15, true);
            WriteLiteral("<div>\r\n    <h3>");
            EndContext();
            BeginContext(294, 17, false);
#line 19 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
   Write(rv.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(311, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(314, 16, false);
#line 19 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
                       Write(rv.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(330, 29, true);
            WriteLiteral("</h3>\r\n    <p class=\"RvText\">");
            EndContext();
            BeginContext(360, 7, false);
#line 20 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
                 Write(rv.Text);

#line default
#line hidden
            EndContext();
            BeginContext(367, 21, true);
            WriteLiteral("</p>\r\n    <p>Оценка: ");
            EndContext();
            BeginContext(389, 7, false);
#line 21 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
          Write(rv.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(396, 36, true);
            WriteLiteral(" из 10</p>\r\n    <p class=\"postDate\">");
            EndContext();
            BeginContext(433, 30, false);
#line 22 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
                   Write(rv.PostDT.ToString("dd.MM.yy"));

#line default
#line hidden
            EndContext();
            BeginContext(463, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 23 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
     if (rv.UsrId == Convert.ToInt32(Model.UsrId))
    {

#line default
#line hidden
            BeginContext(528, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(536, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dba73060eae4cfbbcb1494a36c5d5aa", async() => {
                BeginContext(563, 14, true);
                WriteLiteral("Изменить отзыв");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 545, "~/Reviews/", 545, 10, true);
#line 25 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
AddHtmlAttributeValue("", 555, rv.Id, 555, 6, false);

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
            BeginContext(581, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
    }

#line default
#line hidden
            BeginContext(590, 44, true);
            WriteLiteral("    <br />\r\n    <hr />\r\n    <br />\r\n</div>\r\n");
            EndContext();
#line 31 "D:\Downloads\Сане\School\School\Views\Review\ShowReviews.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShowReviewsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
