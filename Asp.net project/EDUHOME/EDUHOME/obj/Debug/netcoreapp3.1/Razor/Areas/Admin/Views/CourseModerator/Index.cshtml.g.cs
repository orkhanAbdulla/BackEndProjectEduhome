#pragma checksum "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d8cd11dece273f5165e0e52e20a616de4f761f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CourseModerator_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CourseModerator/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\_ViewImports.cshtml"
using EDUHOME.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\_ViewImports.cshtml"
using EDUHOME.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8cd11dece273f5165e0e52e20a616de4f761f", @"/Areas/Admin/Views/CourseModerator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd613e4ccb1907e7d814d947f5749488bfab43c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CourseModerator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CourseAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 120px; height: 115px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card \">\r\n        <div class=\"card \">\r\n            <div class=\"card-body \">\r\n                <h4 class=\"card-title\">Courses</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43d8cd11dece273f5165e0e52e20a616de4f761f5932", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""table-responsive"">
                    <table class=""table table-striped "">
                        <thead>
                            <tr>
                                <th>
                                    Image
                                </th>
                                <th>
                                    Course
                                </th>
                                <th>
                                    Starts
                                </th>
                                <th>
                                    Language
                                </th>
                                <th>
                                    Students
                                </th>
                                <th>
                                    Price($)
                                </th>
                                <th>
                                    IsDeleted
                                <");
            WriteLiteral("/th>\r\n                                <th>\r\n                                    Setting\r\n                                </th>\r\n                            </tr>\r\n\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                             foreach (Course cr in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43d8cd11dece273f5165e0e52e20a616de4f761f9131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1890, "~/img/course/", 1890, 13, true);
#nullable restore
#line 48 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
AddHtmlAttributeValue("", 1903, cr.ImageUrl, 1903, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("a", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 51 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                   Write(cr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 54 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                   Write(cr.DetailCourse.Starts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 57 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                   Write(cr.DetailCourse.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 60 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                   Write(cr.DetailCourse.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                   Write(cr.DetailCourse.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 65 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                     if (cr.IsDeleted)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-danger\">\r\n                                            Deactive\r\n                                        </td>\r\n");
#nullable restore
#line 70 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-success\">\r\n                                            Active\r\n                                        </td>\r\n");
#nullable restore
#line 77 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n");
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43d8cd11dece273f5165e0e52e20a616de4f761f14701", async() => {
                WriteLiteral("\r\n                                            Edit\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                                                                                         WriteLiteral(cr.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 102 "C:\Users\hp\Desktop\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseModerator\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
