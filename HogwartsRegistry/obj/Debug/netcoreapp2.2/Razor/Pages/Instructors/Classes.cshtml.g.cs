#pragma checksum "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13160b5cfbf97ec41a848c8e8d47432864e453cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HogwartsRegistry.Pages.Instructors.Pages_Instructors_Classes), @"mvc.1.0.razor-page", @"/Pages/Instructors/Classes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Instructors/Classes.cshtml", typeof(HogwartsRegistry.Pages.Instructors.Pages_Instructors_Classes), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13160b5cfbf97ec41a848c8e8d47432864e453cb", @"/Pages/Instructors/Classes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12926f217128faf7d2244f86abbe23caf44a6f24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instructors_Classes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Instructors/ViewStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
  
    ViewData["Title"] = "Classes";

#line default
#line hidden
            BeginContext(106, 167, true);
            WriteLiteral("<div class=\"scratches\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h1>My Classes</h1>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
            EndContext();
            BeginContext(273, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13160b5cfbf97ec41a848c8e8d47432864e453cb6954", async() => {
                BeginContext(320, 38, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Add a Class");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(362, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(396, 1475, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13160b5cfbf97ec41a848c8e8d47432864e453cb8478", async() => {
                BeginContext(416, 115, true);
                WriteLiteral("\r\n        <table class=\"table table-striped\">\r\n            <tr class=\"table table-secondary\">\r\n                <th>");
                EndContext();
                BeginContext(532, 59, false);
#line 18 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
               Write(Html.DisplayNameFor(i => Model.Classes.FirstOrDefault().Id));

#line default
#line hidden
                EndContext();
                BeginContext(591, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(619, 60, false);
#line 19 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
               Write(Html.DisplayNameFor(i => Model.Classes.FirstOrDefault().CRN));

#line default
#line hidden
                EndContext();
                BeginContext(679, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(707, 74, false);
#line 20 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
               Write(Html.DisplayNameFor(i => Model.Classes.FirstOrDefault().Course.Department));

#line default
#line hidden
                EndContext();
                BeginContext(781, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(809, 73, false);
#line 21 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
               Write(Html.DisplayNameFor(i => Model.Classes.FirstOrDefault().Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(882, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(910, 75, false);
#line 22 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
               Write(Html.DisplayNameFor(i => Model.Classes.FirstOrDefault().Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(985, 53, true);
                WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 25 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
             foreach (var cls in Model.Classes)
            {

#line default
#line hidden
                BeginContext(1102, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1149, 28, false);
#line 28 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                   Write(Html.DisplayFor(i => cls.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1177, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1209, 29, false);
#line 29 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                   Write(Html.DisplayFor(i => cls.CRN));

#line default
#line hidden
                EndContext();
                BeginContext(1238, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1270, 43, false);
#line 30 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.Department));

#line default
#line hidden
                EndContext();
                BeginContext(1313, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1345, 42, false);
#line 31 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(1387, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1419, 44, false);
#line 32 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1463, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1494, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13160b5cfbf97ec41a848c8e8d47432864e453cb13807", async() => {
                    BeginContext(1599, 34, true);
                    WriteLiteral("<i class=\"fa fa-trash\"></i> Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                                                                                                            WriteLiteral(cls.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-classId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1642, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1668, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13160b5cfbf97ec41a848c8e8d47432864e453cb16635", async() => {
                    BeginContext(1763, 8, true);
                    WriteLiteral("Students");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
                                                                                                  WriteLiteral(cls.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["classId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-classId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["classId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1775, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 37 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Instructors\Classes.cshtml"
            }

#line default
#line hidden
                BeginContext(1842, 22, true);
                WriteLiteral("        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(1871, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HogwartsRegistry.Pages.Instructors.ClassesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Instructors.ClassesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Instructors.ClassesModel>)PageContext?.ViewData;
        public HogwartsRegistry.Pages.Instructors.ClassesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
