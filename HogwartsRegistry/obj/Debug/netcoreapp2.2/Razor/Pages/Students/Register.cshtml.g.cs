#pragma checksum "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d939b7557c059164cc93ed4e3fa12848550afe92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HogwartsRegistry.Pages.Students.Pages_Students_Register), @"mvc.1.0.razor-page", @"/Pages/Students/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Students/Register.cshtml", typeof(HogwartsRegistry.Pages.Students.Pages_Students_Register), null)]
namespace HogwartsRegistry.Pages.Students
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d939b7557c059164cc93ed4e3fa12848550afe92", @"/Pages/Students/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12926f217128faf7d2244f86abbe23caf44a6f24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Enroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(105, 23, true);
            WriteLiteral("\r\n<h1>Register</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
 if (Model.studentClasses.Count > 0)
{

#line default
#line hidden
            BeginContext(169, 119, true);
            WriteLiteral("    <div class=\"scratches\">\r\n    <!-- Display the classes the student is enrolled in-->\r\n    <h3>My Schedule</h3>\r\n    ");
            EndContext();
            BeginContext(288, 1040, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d939b7557c059164cc93ed4e3fa12848550afe926391", async() => {
                BeginContext(308, 115, true);
                WriteLiteral("\r\n        <table class=\"table table-striped\">\r\n            <tr class=\"table table-secondary\">\r\n                <th>");
                EndContext();
                BeginContext(424, 75, false);
#line 17 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.Department));

#line default
#line hidden
                EndContext();
                BeginContext(499, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(527, 74, false);
#line 18 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(601, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(629, 76, false);
#line 19 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(705, 53, true);
                WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 22 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
             foreach (var cls in Model.studentClasses)
            {

#line default
#line hidden
                BeginContext(829, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(876, 55, false);
#line 25 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Class.Course.DepartmentPrefix));

#line default
#line hidden
                EndContext();
                BeginContext(931, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(963, 48, false);
#line 26 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Class.Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(1011, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1043, 50, false);
#line 27 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Class.Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1093, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1124, 130, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d939b7557c059164cc93ed4e3fa12848550afe9210000", async() => {
                    BeginContext(1239, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 28 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                                                                               WriteLiteral(cls.ClassId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-classId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1254, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 30 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
            }

#line default
#line hidden
                BeginContext(1299, 22, true);
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
            BeginContext(1328, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
}

#line default
#line hidden
            BeginContext(1349, 168, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"scratches\">\r\n    <hr />\r\n\r\n    <!-- Display every other class besides the ones the student is enrolled in-->\r\n    <h3>Available Classes</h3>\r\n    ");
            EndContext();
            BeginContext(1517, 999, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d939b7557c059164cc93ed4e3fa12848550afe9214780", async() => {
                BeginContext(1537, 115, true);
                WriteLiteral("\r\n        <table class=\"table table-striped\">\r\n            <tr class=\"table table-secondary\">\r\n                <th>");
                EndContext();
                BeginContext(1653, 75, false);
#line 45 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.Department));

#line default
#line hidden
                EndContext();
                BeginContext(1728, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(1756, 74, false);
#line 46 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(1830, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(1858, 76, false);
#line 47 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
               Write(Html.DisplayNameFor(i => i.otherClasses.FirstOrDefault().Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(1934, 53, true);
                WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 50 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
             foreach (var cls in Model.otherClasses)
            {

#line default
#line hidden
                BeginContext(2056, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(2103, 49, false);
#line 53 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.DepartmentPrefix));

#line default
#line hidden
                EndContext();
                BeginContext(2152, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2184, 42, false);
#line 54 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.CourseNum));

#line default
#line hidden
                EndContext();
                BeginContext(2226, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2258, 44, false);
#line 55 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                   Write(Html.DisplayFor(i => cls.Course.CourseTitle));

#line default
#line hidden
                EndContext();
                BeginContext(2302, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(2333, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d939b7557c059164cc93ed4e3fa12848550afe9218381", async() => {
                    BeginContext(2427, 6, true);
                    WriteLiteral("Enroll");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-classId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 56 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
                                                                 WriteLiteral(cls.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-classId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["classId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2442, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 58 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\Register.cshtml"
            }

#line default
#line hidden
                BeginContext(2487, 22, true);
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
            BeginContext(2516, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HogwartsRegistry.Pages.Students.RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Students.RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Students.RegisterModel>)PageContext?.ViewData;
        public HogwartsRegistry.Pages.Students.RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591