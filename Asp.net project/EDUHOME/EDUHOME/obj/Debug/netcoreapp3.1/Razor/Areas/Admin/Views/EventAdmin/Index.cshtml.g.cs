#pragma checksum "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c7aac850c2da905b4d48d845e2b0697c3c29fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EventAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/EventAdmin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c7aac850c2da905b4d48d845e2b0697c3c29fc", @"/Areas/Admin/Views/EventAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd613e4ccb1907e7d814d947f5749488bfab43c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EventAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EventAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px; height: 100px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 140px; height: 140px; object-fit:cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card \">\r\n        <div class=\"card \">\r\n            <div class=\"card-body \">\r\n                <h4 class=\"card-title\">Events</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7aac850c2da905b4d48d845e2b0697c3c29fc8067", async() => {
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
                                    Fullname
                                </th>
                                <th>
                                    Position
                                </th>
                                <th>
                                    About me
                                </th>
                                <th>
                                    Speakers
                                </th>
                                <th>
                                    IsDeleted
                                </th>
                                <th>
                                    Settings
                             ");
            WriteLiteral("   </th>\r\n\r\n                            </tr>\r\n\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                             foreach (Event ev in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31c7aac850c2da905b4d48d845e2b0697c3c29fc11148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1770, "~/img/event/", 1770, 12, true);
#nullable restore
#line 46 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
AddHtmlAttributeValue("", 1782, ev.ImageUrl, 1782, 12, false);

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
#line 49 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                   Write(ev.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                   Write(ev.EventTime.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                Write(ev.EventTime.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                              Write(ev.EventTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 52 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                                                            Write(ev.EventEndTime.ToString("t"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 55 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                   Write(ev.Venue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>
                                        <!-- Button trigger modal -->
                                        <button type=""button"" class=""btn btn-secondary"" data-toggle=""modal"" data-target=""#speaker-");
#nullable restore
#line 59 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                                                             Write(ev.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            SPEAKER INFO\r\n                                        </button>\r\n\r\n                                        <!-- Modal -->\r\n                                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2847, "\"", 2866, 2);
            WriteAttributeValue("", 2852, "speaker-", 2852, 8, true);
#nullable restore
#line 64 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
WriteAttributeValue("", 2860, ev.Id, 2860, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2895, "\"", 2927, 2);
            WriteAttributeValue("", 2913, "speaker-", 2913, 8, true);
#nullable restore
#line 64 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
WriteAttributeValue("", 2921, ev.Id, 2921, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                                            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                                <div class=""modal-content"">
                                                    <div class=""modal-header"">
                                                        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                            <span aria-hidden=""true"">&times;</span>
                                                        </button>
                                                    </div>
                                                    <div class=""modal-body"">
");
#nullable restore
#line 74 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                         foreach (EventSpeaker es in ev.EventSpeakers)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"row mt-5\">\r\n                                                                <div class=\"col-6\">\r\n                                                                    ");
#nullable restore
#line 78 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                               Write(Html.Raw("<p>Speaker Name</p>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                    <h3>");
#nullable restore
#line 79 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                   Write(es.Speaker.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                                    ");
#nullable restore
#line 80 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                               Write(Html.Raw("<p>Speaker Occupation</p>"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                    <h3>");
#nullable restore
#line 81 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                   Write(es.Speaker.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                                </div>\r\n                                                                <div class=\"col-6\">\r\n                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31c7aac850c2da905b4d48d845e2b0697c3c29fc20771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4813, "~/img/event/", 4813, 12, true);
#nullable restore
#line 84 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
AddHtmlAttributeValue("", 4825, es.Speaker.ImageUrl, 4825, 20, false);

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
            WriteLiteral("\r\n                                                                </div>\r\n                                                            </div>\r\n");
#nullable restore
#line 87 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                        <button type=""button"" class=""btn btn-primary"">Save changes</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                    </td>

");
#nullable restore
#line 99 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                     if (ev.IsDeleted)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-danger\">\r\n                                            Deactive\r\n                                        </td>\r\n");
#nullable restore
#line 104 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-success\">\r\n                                            Active\r\n                                        </td>\r\n");
#nullable restore
#line 111 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7aac850c2da905b4d48d845e2b0697c3c29fc25235", async() => {
                WriteLiteral("\r\n                                            Detail\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                      WriteLiteral(ev.Id);

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
            WriteLiteral("\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7aac850c2da905b4d48d845e2b0697c3c29fc27698", async() => {
                WriteLiteral("\r\n                                            Edit\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                         WriteLiteral(ev.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                         if (ev.IsDeleted)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7aac850c2da905b4d48d845e2b0697c3c29fc30506", async() => {
                WriteLiteral("\r\n                                                Activated\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                             WriteLiteral(ev.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 125 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c7aac850c2da905b4d48d845e2b0697c3c29fc33360", async() => {
                WriteLiteral("\r\n                                                Deactivated\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                                                                            WriteLiteral(ev.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 135 "C:\Users\hp\Desktop\Asp.net\Edu\BackEndProjectEduhome\Asp.net project\EDUHOME\EDUHOME\Areas\Admin\Views\EventAdmin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "31c7aac850c2da905b4d48d845e2b0697c3c29fc36711", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
