#pragma checksum "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38230ca58c5043b5a2ba2cddcc1910cabf138179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HogwartsRegistry.Pages.Students.Pages_Students_StudentClasses), @"mvc.1.0.razor-page", @"/Pages/Students/StudentClasses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Students/StudentClasses.cshtml", typeof(HogwartsRegistry.Pages.Students.Pages_Students_StudentClasses), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38230ca58c5043b5a2ba2cddcc1910cabf138179", @"/Pages/Students/StudentClasses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12926f217128faf7d2244f86abbe23caf44a6f24", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_StudentClasses : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Students/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
  
    ViewData["Title"] = "StudentClasses";

#line default
#line hidden
            BeginContext(117, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
 if (@Model.studentClasses.Count > 0)
{

#line default
#line hidden
            BeginContext(163, 265, true);
            WriteLiteral(@"    <br />
    <div class=""scratches"">
        <h1>My Classes</h1>
        <div class=""row"">
            <div class=""col-6 text-left"">
                <h3>Fall 2019 Schedule</h3>
            </div>
            <div class=""col-6 text-right"">
                ");
            EndContext();
            BeginContext(428, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38230ca58c5043b5a2ba2cddcc1910cabf1381794970", async() => {
                BeginContext(485, 56, true);
                WriteLiteral("<i class=\"fa fa-user-graduate\"></i> Register for Classes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(545, 339, true);
            WriteLiteral(@"
            </div>
        </div>
        <table class=""table table-striped border"">
            <tr class=""table table-secondary"">
                <th>Department</th>
                <th>Course Number</th>
                <th>Course Title</th>
                <th>Instructor</th>
                <th></th>
            </tr>

");
            EndContext();
#line 30 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
             foreach (var cls in Model.studentClasses)
            {

#line default
#line hidden
            BeginContext(955, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1002, 33, false);
#line 33 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
                   Write(cls.Class.Course.DepartmentPrefix);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1067, 26, false);
#line 34 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
                   Write(cls.Class.Course.CourseNum);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1125, 28, false);
#line 35 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
                   Write(cls.Class.Course.CourseTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1185, 30, false);
#line 36 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
                   Write(cls.Class.Instructor.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1217, 29, false);
#line 36 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
                                                   Write(cls.Class.Instructor.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
            }

#line default
#line hidden
            BeginContext(1291, 32, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 42 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
}
else
{
    

#line default
#line hidden
            BeginContext(1341, 122, true);
            WriteLiteral("<div class=\"scratches p-2\">\r\n    <h1>No Classes Found</h1>\r\n    <p>You are not curently enrolled in any classes.</p>\r\n    ");
            EndContext();
            BeginContext(1463, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38230ca58c5043b5a2ba2cddcc1910cabf1381799916", async() => {
                BeginContext(1520, 56, true);
                WriteLiteral("<i class=\"fa fa-user-graduate\"></i> Register for Classes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1580, 22, true);
            WriteLiteral("\r\n    <br />\r\n</div>\r\n");
            EndContext();
#line 52 "C:\Users\lcooper2\source\repos\HogwartsRegistry\HogwartsRegistry\Pages\Students\StudentClasses.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HogwartsRegistry.Pages.Students.StudentClassesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Students.StudentClassesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HogwartsRegistry.Pages.Students.StudentClassesModel>)PageContext?.ViewData;
        public HogwartsRegistry.Pages.Students.StudentClassesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
