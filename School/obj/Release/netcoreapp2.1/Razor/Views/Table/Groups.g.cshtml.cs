#pragma checksum "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77504046a27fed44bbb9549d00c007fc363c2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Groups), @"mvc.1.0.view", @"/Views/Table/Groups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table/Groups.cshtml", typeof(AspNetCore.Views_Table_Groups))]
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
#line 2 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
using School.Models;

#line default
#line hidden
#line 1 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
using School.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77504046a27fed44bbb9549d00c007fc363c2c0", @"/Views/Table/Groups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrShowVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custLnk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Groups/Add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(67, 285, true);
            WriteLiteral(@"
<h2>Расписание</h2>

<table class=""globalTbl"">
    <tr>
        <th>Время</th>
        <th>Понедельник</th>
        <th>Вторник</th>
        <th>Среда</th>
        <th>Четверг</th>
        <th>Пятница</th>
        <th>Суббота</th>
        <th>Воскресенье</th>
    </tr>
");
            EndContext();
#line 18 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
     for (int i = 0; i < Model.UniqueTime.Count; i++)
    {

#line default
#line hidden
            BeginContext(414, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(437, 19, false);
#line 21 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
       Write(Model.UniqueTime[i]);

#line default
#line hidden
            EndContext();
            BeginContext(456, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(460, 69, false);
#line 21 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                              Write(Convert.ToDateTime(Model.UniqueTime[i]).AddHours(1).ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(529, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 22 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
         for (int j = 1; j < 8; j++)
        {

#line default
#line hidden
            BeginContext(585, 18, true);
            WriteLiteral("            <td>\r\n");
            EndContext();
#line 25 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
            foreach (GrVM gr in Model.Grs)
            {
               

#line default
#line hidden
#line 27 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                for (int k = 0; k < gr.Table.Count; k++)
                {
                   

#line default
#line hidden
#line 29 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                    if (gr.Table[k].Time == Model.UniqueTime[i])
                    {
                        

#line default
#line hidden
#line 31 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                         if (gr.Table[k].Id == j)
                        {

#line default
#line hidden
            BeginContext(906, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(934, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "019abcc0b5d745e69ed704224296d84a", async() => {
                BeginContext(977, 7, false);
#line 33 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                                                                 Write(gr.Desc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 959, "~/Groups/", 959, 9, true);
#line 33 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
AddHtmlAttributeValue("", 968, gr.Id, 968, 6, false);

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
            BeginContext(988, 7, true);
            WriteLiteral("<br/>\r\n");
            EndContext();
#line 34 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                        }

#line default
#line hidden
#line 34 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                         
                    }

#line default
#line hidden
#line 35 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                     
                }

#line default
#line hidden
#line 36 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1079, 19, true);
            WriteLiteral("            </td>\r\n");
            EndContext();
#line 39 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
        }

#line default
#line hidden
            BeginContext(1109, 11, true);
            WriteLiteral("    </tr>\r\n");
            EndContext();
#line 41 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
    }

#line default
#line hidden
            BeginContext(1127, 17, true);
            WriteLiteral("</table>\r\n<br/>\r\n");
            EndContext();
#line 44 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
 if (Model.UsrRole == "Администратор")
{

#line default
#line hidden
            BeginContext(1187, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1191, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef55035d58d14b8a8dbeb8663649c425", async() => {
                BeginContext(1214, 15, true);
                WriteLiteral("Добавить группу");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1233, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "D:\Downloads\Сане\на хостинг\School\School\Views\Table\Groups.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrShowVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
