#pragma checksum "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "811c68d9e22e52cd34c3b4787c4415a33e74e4fc93be401c5e8168cf34deea63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MVC CRUD SYSTEM\MVC .PL\Views\_ViewImports.cshtml"
using MVC_.PL

#nullable disable
    ;
#nullable restore
#line 2 "C:\MVC CRUD SYSTEM\MVC .PL\Views\_ViewImports.cshtml"
using MVC_.PL.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\MVC CRUD SYSTEM\MVC .PL\Views\_ViewImports.cshtml"
using MVC.DAL.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\MVC CRUD SYSTEM\MVC .PL\Views\_ViewImports.cshtml"
using MVC_.PL.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"811c68d9e22e52cd34c3b4787c4415a33e74e4fc93be401c5e8168cf34deea63", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ab7f6d0af6753de0d9be2e30c6b213a08dc93d524aaf50cd8cdc9a6d9dec3bbb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
       IEnumerable<EmployeeViewModel>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
  
    ViewData["title"] = "All Employees";

#line default
#line hidden
#nullable disable

#nullable restore
#line 6 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "811c68d9e22e52cd34c3b4787c4415a33e74e4fc93be401c5e8168cf34deea636034", async() => {
                WriteLiteral("Add New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{


#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"row justify-content-center align-items-center mt-5\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "811c68d9e22e52cd34c3b4787c4415a33e74e4fc93be401c5e8168cf34deea637587", async() => {
                WriteLiteral(@"
            <div class=""col-8"">
                <input type=""text"" class=""form-control"" name=""searchInp"" placeholder=""Search By Name"" />
            </div>
            <div class=""col-4"">
                <input type=""submit"" value=""Search"" class=""btn btn-success"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <h1 class=\"mt-2\"> Employees</h1>\r\n    <table class=\"table table-striped table-hover mt-5\">\r\n        <thead> \r\n            <tr>\r\n\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 32 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 33 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 34 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 35 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 36 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 37 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 38 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 39 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
            Write(
#nullable restore
#line 40 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                 Html.DisplayNameFor(E => E.HireDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <th scope=\"col\">Deails</th>\r\n                <th scope=\"col\">Update</th>\r\n                <th scope=\"col\">Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 47 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
             foreach (var Employee in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            Write(
#nullable restore
#line 50 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 51 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 52 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.Address

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 53 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.Department?.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 54 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Html.DisplayFor(M => Employee.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 55 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Html.DisplayFor(M => Employee.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 56 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Html.DisplayFor(M => Employee.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 57 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 58 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                         Employee.HireDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "811c68d9e22e52cd34c3b4787c4415a33e74e4fc93be401c5e8168cf34deea6315553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 62 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
                                                            Employee.Id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  \r\n\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 72 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h1>No Employees</h1>\r\n    </div>\r\n");
#nullable restore
#line 78 "C:\MVC CRUD SYSTEM\MVC .PL\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
