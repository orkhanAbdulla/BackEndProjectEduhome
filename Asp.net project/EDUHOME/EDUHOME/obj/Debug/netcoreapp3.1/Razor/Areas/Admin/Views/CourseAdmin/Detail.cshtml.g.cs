#pragma checksum "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8917780ff52627e20bbb581060536cf29a924f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CourseAdmin_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/CourseAdmin/Detail.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\_ViewImports.cshtml"
using EDUHOME.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\_ViewImports.cshtml"
using EDUHOME.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8917780ff52627e20bbb581060536cf29a924f97", @"/Areas/Admin/Views/CourseAdmin/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd613e4ccb1907e7d814d947f5749488bfab43c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CourseAdmin_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CourseAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card \">\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8917780ff52627e20bbb581060536cf29a924f975879", async() => {
                WriteLiteral("Go Back");
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
                                    Description
                                </th>
                                <th>
                                   Course Features
                                </th>
                                <th>
                                    Settings
                                </th>

                            </tr>

                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8917780ff52627e20bbb581060536cf29a924f978333", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1373, "~/img/course/", 1373, 13, true);
#nullable restore
#line 36 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
AddHtmlAttributeValue("", 1386, Model.ImageUrl, 1386, 15, false);

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
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <h5>");
#nullable restore
#line 39 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </td>
                                <td>
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalLong-");
#nullable restore
#line 43 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                                                                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        Click for Description\r\n                                    </button>\r\n\r\n                                    <!-- Modal -->\r\n                                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2059, "\"", 2090, 2);
            WriteAttributeValue("", 2064, "exampleModalLong-", 2064, 17, true);
#nullable restore
#line 48 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
WriteAttributeValue("", 2081, Model.Id, 2081, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2119, "\"", 2168, 2);
            WriteAttributeValue("", 2137, "exampleModalLongTitle-", 2137, 22, true);
#nullable restore
#line 48 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
WriteAttributeValue("", 2159, Model.Id, 2159, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    <h3>Description</h3>
                                                    <p>");
#nullable restore
#line 59 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    <div class=""course-details-left"">
                                                        <div class=""single-course-left"">
                                                            <h3>about course</h3>
                                                            <p>");
#nullable restore
#line 63 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                          Write(Model.DetailCourse.AboutCourse);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                        <div class=""single-course-left"">
                                                            <h3>how to apply</h3>
                                                            <p>");
#nullable restore
#line 67 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                          Write(Model.DetailCourse.HowToApply);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                        </div>
                                                        <div class=""single-course-left"">
                                                            <h3>certification</h3>
                                                            ");
#nullable restore
#line 71 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                       Write(Html.Raw(Model.DetailCourse.Certification));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#exampleModalLong-1"">
                        ");
            WriteLiteral(@"                Course Features
                                    </button>

                                    <!-- Modal -->
                                    <div class=""modal fade"" id=""exampleModalLong-1"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle3-1"" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
  ");
            WriteLiteral(@"                                              <div class=""modal-body"">
                                                    <div class=""course-details-right"">
                                                        <h3>COURSE FEATURES</h3>
                                                        <ul>
                                                            <li>starts: <span>");
#nullable restore
#line 103 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                         Write(Model.DetailCourse.Starts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>duration: <span>");
#nullable restore
#line 104 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                           Write(Model.DetailCourse.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>class duration: <span>");
#nullable restore
#line 105 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                                 Write(Model.DetailCourse.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>skill level: <span>");
#nullable restore
#line 106 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                              Write(Model.DetailCourse.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>language: <span>");
#nullable restore
#line 107 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                           Write(Model.DetailCourse.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>students: <span>");
#nullable restore
#line 108 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                           Write(Model.DetailCourse.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                            <li>assesments: <span>");
#nullable restore
#line 109 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                             Write(Model.DetailCourse.Assesments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                                        </ul>\r\n                                                        <h3 class=\"red\">course fee $");
#nullable restore
#line 111 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                               Write(Model.DetailCourse.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                                    </div>
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8917780ff52627e20bbb581060536cf29a924f9722831", async() => {
                WriteLiteral("\r\n                                        Edit\r\n                                    ");
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
#line 123 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\CourseAdmin\Detail.cshtml"
                                                                                     WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
