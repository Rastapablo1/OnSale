#pragma checksum "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8abec7d6b2391f9d556bfc17c0cefc437901bc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8abec7d6b2391f9d556bfc17c0cefc437901bc7", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f9e2fe1051a5563cad806bd09dad9638374979", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnSale.Web.Data.Entities.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteDialog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 220, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css\" />\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(307, 40, false);
#line 15 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(391, 36, false);
#line 18 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(471, 47, false);
#line 21 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(562, 43, false);
#line 24 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(605, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Category\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(700, 45, false);
#line 30 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(789, 41, false);
#line 33 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(830, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(874, 37, false);
#line 36 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(955, 44, false);
#line 39 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(999, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1043, 40, false);
#line 42 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1127, 45, false);
#line 45 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsStarred));

#line default
#line hidden
            EndContext();
            BeginContext(1172, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1216, 41, false);
#line 48 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsStarred));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1301, 49, false);
#line 51 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1394, 45, false);
#line 54 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Qualification));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1483, 55, false);
#line 57 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductImagesNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1582, 51, false);
#line 60 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductImagesNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1677, 57, false);
#line 63 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductQualifications));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1778, 53, false);
#line 66 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductQualifications));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1878, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a40d1c129a54f5c942f465337b406ad", async() => {
                BeginContext(1952, 46, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> Image");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2002, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2008, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b8f7fcc8424c35a57461996657bf19", async() => {
                BeginContext(2078, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2086, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2092, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247fdb7b7034474c9a6ba3dbde08c4a6", async() => {
                BeginContext(2138, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2154, 496, true);
            WriteLiteral(@"
</div>
<br />

<div class=""row"">
    <div class=""col-md-5"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Product Images</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTableImages"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(2651, 80, false);
#line 88 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ProductImages.FirstOrDefault().ImageFullPath));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 94 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                         foreach (var item in Model.ProductImages)
                        {

#line default
#line hidden
            BeginContext(2992, 112, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3104, "\"", 3129, 1);
#line 98 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 3110, item.ImageFullPath, 3110, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3130, 199, true);
            WriteLiteral(" style=\"width:200px;height:200px;max-width: 100%; height: auto;\" />\r\n                                </td>\r\n                                <td>\r\n                                    <button data-id=\"");
            EndContext();
            BeginContext(3330, 7, false);
#line 101 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                                Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3337, 210, true);
            WriteLiteral("\" class=\"btn btn-danger deleteItem\" data-toggle=\"modal\" data-target=\"#deleteDialog\"><i class=\"glyphicon glyphicon-trash\"></i></button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 104 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(3574, 814, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""col-md-7"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">Qualifications</h3>
            </div>
            <div class=""panel-body"">
                <table class=""table table-hover table-responsive table-striped"" id=""MyTableQualifications"">
                    <colgroup>
                        <col span=""1"" />
                        <col span=""1"" />
                        <col span=""1"" />
                        <col span=""1"" width=""400"" />
                    </colgroup>
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(4389, 77, false);
#line 126 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().DateLocal));

#line default
#line hidden
            EndContext();
            BeginContext(4466, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4570, 78, false);
#line 129 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4648, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4752, 73, false);
#line 132 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().Score));

#line default
#line hidden
            EndContext();
            BeginContext(4825, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(4929, 75, false);
#line 135 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Qualifications.FirstOrDefault().Remarks));

#line default
#line hidden
            EndContext();
            BeginContext(5004, 127, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 140 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                         foreach (var item in Model.Qualifications)
                        {

#line default
#line hidden
            BeginContext(5227, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5336, 44, false);
#line 144 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DateLocal));

#line default
#line hidden
            EndContext();
            BeginContext(5380, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5496, 45, false);
#line 147 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(5541, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5657, 40, false);
#line 150 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
            EndContext();
            BeginContext(5697, 79, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            EndContext();
#line 153 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                      
                                        string[] noteWords = item.Remarks.Split(' ');
                                        if (noteWords.Count() > 7)
                                        {

#line default
#line hidden
            BeginContext(6014, 92, true);
            WriteLiteral("                                            <a class=\"\" role=\"button\" data-toggle=\"collapse\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6106, "\"", 6135, 2);
            WriteAttributeValue("", 6113, "#collapseSum", 6113, 12, true);
#line 157 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 6125, item.Id, 6125, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6136, 22, true);
            WriteLiteral(" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 6158, "\"", 6195, 2);
            WriteAttributeValue("", 6174, "collapseSum", 6174, 11, true);
#line 157 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 6185, item.Id, 6185, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6196, 51, true);
            WriteLiteral(">\r\n                                                ");
            EndContext();
            BeginContext(6249, 43, false);
#line 158 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                            Write(string.Join(" ", noteWords.Take(7)) + "...");

#line default
#line hidden
            EndContext();
            BeginContext(6293, 117, true);
            WriteLiteral("\r\n                                            </a>\r\n                                            <div class=\"collapse\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6410, "\"", 6436, 2);
            WriteAttributeValue("", 6415, "collapseSum", 6415, 11, true);
#line 160 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 6426, item.Id, 6426, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6437, 123, true);
            WriteLiteral(">\r\n                                                <div class=\"well\">\r\n                                                    ");
            EndContext();
            BeginContext(6562, 35, false);
#line 162 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                                Write(string.Join(" ", noteWords.Skip(7)));

#line default
#line hidden
            EndContext();
            BeginContext(6598, 110, true);
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 165 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(6885, 12, false);
#line 168 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                       Write(item.Remarks);

#line default
#line hidden
            EndContext();
#line 168 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                                                         
                                        }
                                    

#line default
#line hidden
            BeginContext(6981, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 174 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(7084, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(7198, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4d8d334b6914e06a4d70856d31fa765", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7230, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7252, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 185 "F:\Projects\OnSale\OnSale.Web\Views\Products\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(7322, 482, true);
                WriteLiteral(@"    <script src=""//cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script src=""/js/deleteDialog.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#MyTableImages').DataTable();
            $('#MyTableQualifications').DataTable();

            // Delete item
            sc_deleteDialog.openModal('deleteItem', true, 'btnYesDelete', '/Products/DeleteImage/', false);
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(7807, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnSale.Web.Data.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
