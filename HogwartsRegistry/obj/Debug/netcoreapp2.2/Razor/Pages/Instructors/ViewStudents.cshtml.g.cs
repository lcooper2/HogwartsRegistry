#pragma checksum "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9926c995c144745ee331325069e6038b78c5ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HogwartsRegistry.Pages.Instructors.Pages_Instructors_ViewStudents), @"mvc.1.0.razor-page", @"/Pages/Instructors/ViewStudents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Instructors/ViewStudents.cshtml", typeof(HogwartsRegistry.Pages.Instructors.Pages_Instructors_ViewStudents), null)]
namespace HogwartsRegistry.Pages.Instructors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\_ViewImports.cshtml"
using HogwartsRegistry;

#line default
#line hidden
#line 3 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\_ViewImports.cshtml"
using HogwartsRegistry.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9926c995c144745ee331325069e6038b78c5ad", @"/Pages/Instructors/ViewStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12926f217128faf7d2244f86abbe23caf44a6f24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instructors_ViewStudents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "UnenrollStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Enroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::HogwartsRegistry.TagHelpers.PageLinkTagHelper __HogwartsRegistry_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
  
    ViewData["Title"] = "ViewStudents";

#line default
#line hidden
            BeginContext(116, 53, true);
            WriteLiteral("<div class=\"scratches\">\r\n    <h1>View Students</h1>\r\n");
            EndContext();
#line 8 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
     if (Model.InstrViewVM.Students.Count > 0)
    {

#line default
#line hidden
            BeginContext(224, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(228, 1536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad9854", async() => {
                BeginContext(248, 115, true);
                WriteLiteral("\r\n        <table class=\"table table-striped\">\r\n            <tr class=\"table table-secondary\">\r\n                <th>");
                EndContext();
                BeginContext(364, 58, false);
#line 13 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Id));

#line default
#line hidden
                EndContext();
                BeginContext(422, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(450, 65, false);
#line 14 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Class.CRN));

#line default
#line hidden
                EndContext();
                BeginContext(515, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(543, 78, false);
#line 15 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Class.Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(621, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(649, 80, false);
#line 16 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Class.Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(729, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(757, 73, false);
#line 17 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Student.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(830, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(858, 72, false);
#line 18 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayNameFor(s => Model.InstrViewVM.Students[0].Student.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(930, 55, true);
                WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n\r\n");
                EndContext();
#line 22 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
             foreach (var stud in Model.InstrViewVM.Students)
            {

#line default
#line hidden
                BeginContext(1063, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1110, 29, false);
#line 25 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1139, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1171, 36, false);
#line 26 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Class.CRN));

#line default
#line hidden
                EndContext();
                BeginContext(1207, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1239, 49, false);
#line 27 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Class.Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(1288, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1320, 51, false);
#line 28 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Class.Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1371, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1403, 44, false);
#line 29 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Student.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1447, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1479, 43, false);
#line 30 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                   Write(Html.DisplayFor(s => stud.Student.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1522, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1553, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad16197", async() => {
                    BeginContext(1675, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-studentClassId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                                                                                                                            WriteLiteral(stud.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["studentClassId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-studentClassId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["studentClassId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1690, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 33 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
            }

#line default
#line hidden
                BeginContext(1735, 22, true);
                WriteLiteral("        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1764, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 36 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
    }

#line default
#line hidden
            BeginContext(1773, 24, true);
            WriteLiteral("</div>\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(1797, 2362, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad20898", async() => {
                BeginContext(1816, 402, true);
                WriteLiteral(@"
    <div class=""scratches"">
        <h3>Add a Student</h3>
        <div class=""border"">
            <div style=""height: 60px;"" class=""container border border-secondary"">
                <div class=""row"">
                    <div class=""col-11"">
                        <div class=""row"" style=""padding-top:10px"">
                            <div class=""col-4"">
                                ");
                EndContext();
                BeginContext(2219, 390, false);
#line 49 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                           Write(Html.Editor("searchLastName", new
                                {
                                    htmlAttributes = new
                                    {
                                @class = "form-control",
                                placeholder = "Last Name..."
                                }
                                }
                                ));

#line default
#line hidden
                EndContext();
                BeginContext(2609, 119, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-4\">\r\n                                ");
                EndContext();
                BeginContext(2729, 381, false);
#line 60 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                           Write(Html.Editor("searchYear", new
                                {
                                    htmlAttributes = new
                                    {
                                @class = "form-control",
                                placeholder = "Year..."
                                }
                                }
                                ));

#line default
#line hidden
                EndContext();
                BeginContext(3110, 119, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-4\">\r\n                                ");
                EndContext();
                BeginContext(3230, 383, false);
#line 71 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                           Write(Html.Editor("searchHouse", new
                                {
                                    htmlAttributes = new
                                    {
                                @class = "form-control",
                                placeholder = "House..."
                                }
                                }
                                ));

#line default
#line hidden
                EndContext();
                BeginContext(3613, 256, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-1"">
                        <div class=""row"" style=""padding-top:10px; padding-right:15px;"">
                            ");
                EndContext();
                BeginContext(3869, 149, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad24504", async() => {
                    BeginContext(3980, 29, true);
                    WriteLiteral("<i class=\"fas fa-search\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4018, 134, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4159, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(4163, 1554, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad27782", async() => {
                BeginContext(4183, 132, true);
                WriteLiteral("\r\n    <div class=\"scratches\">\r\n    <table class=\"table table-striped\">\r\n        <tr class=\"table table-secondary\">\r\n            <th>");
                EndContext();
                BeginContext(4316, 70, false);
#line 98 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
           Write(Html.DisplayNameFor(s => Model.InstrViewVM.otherStudents[0].FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(4386, 23, true);
                WriteLiteral("</th>\r\n            <th>");
                EndContext();
                BeginContext(4410, 69, false);
#line 99 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
           Write(Html.DisplayNameFor(s => Model.InstrViewVM.otherStudents[0].LastName));

#line default
#line hidden
                EndContext();
                BeginContext(4479, 23, true);
                WriteLiteral("</th>\r\n            <th>");
                EndContext();
                BeginContext(4503, 65, false);
#line 100 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
           Write(Html.DisplayNameFor(s => Model.InstrViewVM.otherStudents[0].Year));

#line default
#line hidden
                EndContext();
                BeginContext(4568, 23, true);
                WriteLiteral("</th>\r\n            <th>");
                EndContext();
                BeginContext(4592, 66, false);
#line 101 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
           Write(Html.DisplayNameFor(s => Model.InstrViewVM.otherStudents[0].House));

#line default
#line hidden
                EndContext();
                BeginContext(4658, 73, true);
                WriteLiteral("</th>\r\n            <th><!-- Empty for formatting--></th>\r\n        </tr>\r\n");
                EndContext();
#line 104 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
         foreach (var stud in Model.InstrViewVM.otherStudents)
        {

#line default
#line hidden
                BeginContext(4806, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(4845, 36, false);
#line 107 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayFor(s => stud.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(4881, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(4909, 35, false);
#line 108 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayFor(s => stud.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(4944, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(4972, 31, false);
#line 109 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayFor(s => stud.Year));

#line default
#line hidden
                EndContext();
                BeginContext(5003, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(5031, 32, false);
#line 110 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
               Write(Html.DisplayFor(s => stud.House));

#line default
#line hidden
                EndContext();
                BeginContext(5063, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(5090, 229, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad32254", async() => {
                    BeginContext(5255, 55, true);
                    WriteLiteral("\r\n                    <i class=\"fa fa-plus\"></i> Enroll");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-studentId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 112 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
                                                                        WriteLiteral(stud.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["studentId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-studentId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["studentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5319, 26, true);
                WriteLiteral("</td>\r\n            </tr>\r\n");
                EndContext();
#line 115 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
        }

#line default
#line hidden
                BeginContext(5356, 79, true);
                WriteLiteral("        <tr>\r\n            <td colspan=\"5\" class=\"text-right\">\r\n                ");
                EndContext();
                BeginContext(5435, 213, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a9926c995c144745ee331325069e6038b78c5ad35446", async() => {
                }
                );
                __HogwartsRegistry_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::HogwartsRegistry.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__HogwartsRegistry_TagHelpers_PageLinkTagHelper);
#line 118 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\ViewStudents.cshtml"
__HogwartsRegistry_TagHelpers_PageLinkTagHelper.PageModel = Model.InstrViewVM.PagingInfo;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __HogwartsRegistry_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __HogwartsRegistry_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __HogwartsRegistry_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5648, 62, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5717, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HogwartsRegistry.Pages.Instructors.ViewStudentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Instructors.ViewStudentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Instructors.ViewStudentsModel>)PageContext?.ViewData;
        public HogwartsRegistry.Pages.Instructors.ViewStudentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
