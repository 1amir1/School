#pragma checksum "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64d3707ec93b38195161ba609a9d0525bc9d00ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_EditGroup), @"mvc.1.0.view", @"/Views/Table/EditGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Table/EditGroup.cshtml", typeof(AspNetCore.Views_Table_EditGroup))]
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
#line 1 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
using School.Models;

#line default
#line hidden
#line 2 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
using School.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64d3707ec93b38195161ba609a9d0525bc9d00ef", @"/Views/Table/EditGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Table_EditGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddGroupModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
 if (Model.UsrRole == "Администратор")
{

#line default
#line hidden
            BeginContext(119, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(123, 1804, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fe8647cc46c417c8b653d78ac767f78", async() => {
                BeginContext(189, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(200, 38, false);
#line 9 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
   Write(Html.HiddenFor(id => Model.GrToAdd.Id));

#line default
#line hidden
                EndContext();
                BeginContext(238, 53, true);
                WriteLiteral("\r\n        <div class=\"form-horizontal\">\r\n            ");
                EndContext();
                BeginContext(291, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96db697bdc084862bbaaa80aa96a83fa", async() => {
                    BeginContext(328, 9, true);
                    WriteLiteral("Описание:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 11 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrToAdd.Desc);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(345, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(359, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97810641402049cca68778359fd4d31b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrToAdd.Desc);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 12 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                                        WriteLiteral(Model.GrToAdd.Desc);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(436, 45, true);
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(481, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de0e3dee81f049f5b4f95d54f4bd3e4e", async() => {
                    BeginContext(529, 14, true);
                    WriteLiteral("Преподаватель:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 15 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrToAdd.GrTeach.TeachId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(551, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(565, 243, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1442c0b11f7f472e9e240c4df99952b0", async() => {
                    BeginContext(614, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 17 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                 foreach (User u in Model.Teachers)
                {

#line default
#line hidden
                    BeginContext(688, 20, true);
                    WriteLiteral("                    ");
                    EndContext();
                    BeginContext(708, 58, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74949050ee2644e28d0a1a2270494aeb", async() => {
                        BeginContext(734, 11, false);
#line 19 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                        Write(u.FirstName);

#line default
#line hidden
                        EndContext();
                        BeginContext(745, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(747, 10, false);
#line 19 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                                     Write(u.LastName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 19 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       WriteLiteral(u.UsrId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(766, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 20 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                }

#line default
#line hidden
                    BeginContext(787, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 16 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrToAdd.GrTeach.TeachId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(808, 94, true);
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label>Расписание:</label>\r\n            <table>\r\n");
                EndContext();
#line 26 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                 for (int i = 0; i < Model.GrTable.Count; i++)
                {

#line default
#line hidden
                BeginContext(985, 50, true);
                WriteLiteral("                    <tr>\r\n                        ");
                EndContext();
                BeginContext(1036, 41, false);
#line 29 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                   Write(Html.HiddenFor(id => Model.GrTable[i].Id));

#line default
#line hidden
                EndContext();
                BeginContext(1077, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1104, 43, false);
#line 30 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                   Write(Html.HiddenFor(day => Model.GrTable[i].Day));

#line default
#line hidden
                EndContext();
                BeginContext(1147, 30, true);
                WriteLiteral("\r\n                        <td>");
                EndContext();
                BeginContext(1177, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d509a6d8066243b2b1d812ccb3680f3c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 31 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrTable[i].Added);

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
                BeginContext(1234, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1270, 20, false);
#line 32 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       Write(Model.GrTable[i].Day);

#line default
#line hidden
                EndContext();
                BeginContext(1290, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1325, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61be6e373ad9478a8442df153d6e0080", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 33 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrTable[i].Time);

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
                BeginContext(1377, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 35 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                }

#line default
#line hidden
                BeginContext(1430, 90, true);
                WriteLiteral("            </table>\r\n        </div>\r\n        <div>\r\n            <label>Ученики:</label>\r\n");
                EndContext();
#line 40 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
             for (int i = 0; i < Model.GrUsers.Count; i++)
            {
                

#line default
#line hidden
                BeginContext(1612, 42, false);
#line 42 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
           Write(Html.HiddenFor(ids => Model.GrUsers[i].Id));

#line default
#line hidden
                EndContext();
                BeginContext(1673, 46, false);
#line 43 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
           Write(Html.HiddenFor(names => Model.GrUsers[i].Name));

#line default
#line hidden
                EndContext();
                BeginContext(1721, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1737, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b3ce0e5b0b144959b4c870d970813dc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 44 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.GrUsers[i].AddToGr);

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
                BeginContext(1797, 21, false);
#line 44 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                                                      Write(Model.GrUsers[i].Name);

#line default
#line hidden
                EndContext();
                BeginContext(1818, 8, true);
                WriteLiteral("<br />\r\n");
                EndContext();
#line 45 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
            }

#line default
#line hidden
                BeginContext(1841, 79, true);
                WriteLiteral("        </div>\r\n        <input type=\"submit\" value=\"Сохранить изменения\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1927, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1933, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4793f442a66a48118d16d1f04ff57a9f", async() => {
                BeginContext(2003, 67, true);
                WriteLiteral("\r\n        <!--<input type=\"submit\" value=\"Удалить группу\">-->\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2077, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
}
else if (Model.UsrRole == "Преподаватель")
{

#line default
#line hidden
            BeginContext(2129, 36, true);
            WriteLiteral("    <div>\r\n        <label>Описание: ");
            EndContext();
            BeginContext(2166, 18, false);
#line 56 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                    Write(Model.GrToAdd.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(2184, 63, true);
            WriteLiteral("</label>\r\n    </div>\r\n    <div>\r\n        <label>Преподаватель: ");
            EndContext();
            BeginContext(2248, 39, false);
#line 59 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                         Write(Model.GrToAdd.GrTeach.Teacher.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2289, 38, false);
#line 59 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                                                  Write(Model.GrToAdd.GrTeach.Teacher.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2327, 92, true);
            WriteLiteral("</label>\r\n    </div>\r\n    <div>\r\n        <label>Расписание:</label><br />\r\n        <table>\r\n");
            EndContext();
#line 64 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
             foreach (GrDayTime tbl in Model.GrTable)
            {
                if (tbl.Added)
                {

#line default
#line hidden
            BeginContext(2540, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2595, 7, false);
#line 69 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       Write(tbl.Day);

#line default
#line hidden
            EndContext();
            BeginContext(2602, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2638, 8, false);
#line 70 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       Write(tbl.Time);

#line default
#line hidden
            EndContext();
            BeginContext(2646, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2650, 58, false);
#line 70 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                   Write(Convert.ToDateTime(tbl.Time).AddHours(1).ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2708, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 72 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2776, 88, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div>\r\n        <label>Ученики:</label>\r\n        <ul>\r\n");
            EndContext();
#line 79 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
             foreach (GrUser gu in Model.GrUsers)
            {
                if (gu.AddToGr)
                {

#line default
#line hidden
            BeginContext(2982, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(3007, 7, false);
#line 83 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                   Write(gu.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3014, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 84 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(3055, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 88 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3094, 36, true);
            WriteLiteral("    <div>\r\n        <label>Описание: ");
            EndContext();
            BeginContext(3131, 18, false);
#line 92 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                    Write(Model.GrToAdd.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(3149, 63, true);
            WriteLiteral("</label>\r\n    </div>\r\n    <div>\r\n        <label>Преподаватель: ");
            EndContext();
            BeginContext(3213, 39, false);
#line 95 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                         Write(Model.GrToAdd.GrTeach.Teacher.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3252, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3254, 38, false);
#line 95 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                                                  Write(Model.GrToAdd.GrTeach.Teacher.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 92, true);
            WriteLiteral("</label>\r\n    </div>\r\n    <div>\r\n        <label>Расписание:</label><br />\r\n        <table>\r\n");
            EndContext();
#line 100 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
             foreach (GrDayTime tbl in Model.GrTable)
            {
                if (tbl.Added)
                {

#line default
#line hidden
            BeginContext(3505, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3560, 7, false);
#line 105 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       Write(tbl.Day);

#line default
#line hidden
            EndContext();
            BeginContext(3567, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3603, 8, false);
#line 106 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                       Write(tbl.Time);

#line default
#line hidden
            EndContext();
            BeginContext(3611, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(3615, 58, false);
#line 106 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                                   Write(Convert.ToDateTime(tbl.Time).AddHours(1).ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3673, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 108 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(3741, 30, true);
            WriteLiteral("        </table>\r\n    </div>\r\n");
            EndContext();
#line 112 "D:\Downloads\Сане\School\School\Views\Table\EditGroup.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddGroupModel> Html { get; private set; }
    }
}
#pragma warning restore 1591