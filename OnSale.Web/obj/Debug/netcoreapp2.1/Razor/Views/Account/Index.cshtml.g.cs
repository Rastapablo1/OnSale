#pragma checksum "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3942675fa1f2ec48c37c0f9d0ea9b5c8bd1c54df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "F:\Projects\OnSale\OnSale.Web\Views\_ViewImports.cshtml"
using OnSale.Web;

#line default
#line hidden
#line 2 "F:\Projects\OnSale\OnSale.Web\Views\_ViewImports.cshtml"
using OnSale.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3942675fa1f2ec48c37c0f9d0ea9b5c8bd1c54df", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b70f2da74e666573a67ad13717a3462b8a492d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnSale.Web.Data.Entities.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 120, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n<br />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(214, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd25314a31c24d89b0d52a44b9bd9fad", async() => {
                BeginContext(261, 50, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> New Admin");
                EndContext();
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
            EndContext();
            BeginContext(315, 472, true);
            WriteLiteral(@"
</p>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Users</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTable"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(788, 44, false);
#line 25 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(832, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(936, 44, false);
#line 28 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(980, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1084, 41, false);
#line 31 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1229, 45, false);
#line 34 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.City.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1378, 43, false);
#line 37 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1525, 47, false);
#line 40 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1676, 49, false);
#line 43 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ImageFullPath));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 127, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 48 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1933, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2042, 43, false);
#line 52 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2201, 43, false);
#line 55 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2360, 40, false);
#line 58 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2516, 44, false);
#line 61 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.City.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2560, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2676, 42, false);
#line 64 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2718, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2834, 46, false);
#line 67 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2880, 119, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2999, "\"", 3024, 1);
#line 70 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 3005, item.ImageFullPath, 3005, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3025, 128, true);
            WriteLiteral(" style=\"width:80px;height:80px;border-radius:50%\" />\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 73 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3180, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3312, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 82 "F:\Projects\OnSale\OnSale.Web\Views\Account\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3382, 283, true);
                WriteLiteral(@"    <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script src=""/js/deleteDialog.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#MyTable').DataTable();
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3668, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnSale.Web.Data.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591