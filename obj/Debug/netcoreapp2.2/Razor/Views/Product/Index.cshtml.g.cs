#pragma checksum "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbdf5951d47004612401ae008c900ad5658e279a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\_ViewImports.cshtml"
using Test_Task.WebUI.Data;

#line default
#line hidden
#line 2 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\_ViewImports.cshtml"
using Test_Task.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\_ViewImports.cshtml"
using Test_Task.WebUI;

#line default
#line hidden
#line 5 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\_ViewImports.cshtml"
using Task_Test.WebUI.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbdf5951d47004612401ae008c900ad5658e279a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e7a7e90d18578105d32409d1c1031358681f240", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline active-pink-3 active-pink-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Task_Test.WebUI.Infrastructure.WeightTagHelper __Task_Test_WebUI_Infrastructure_WeightTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 92, true);
            WriteLiteral("\r\n<div class=\"bg-primary text-white p-1 m-1 text-center\">\r\n    <h2>Cargo List</h2>\r\n</div>\r\n");
            EndContext();
            BeginContext(162, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbdf5951d47004612401ae008c900ad5658e279a6776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 526, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbdf5951d47004612401ae008c900ad5658e279a8478", async() => {
                BeginContext(335, 408, true);
                WriteLiteral(@"
    <i class=""fas fa-search"" aria-hidden=""true""></i>
    <input id=""q"" name=""q"" class=""form-control form-control-sm ml-3 w-75"" type=""text"" placeholder=""Search""
           aria-label=""Search"">
    <input id=""d"" name=""d"" class=""form-control form-control-sm ml-3 w-75"" type=""date"" placeholder=""datetime""
           aria-label=""Search"">
    <input type=""submit"" class=""btn btn-success"" value=""Search"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 288, true);
            WriteLiteral(@"
<table class=""table table-bordered table-striped m-1 p-1"">
    <tr>
        
        <th>Name</th>
        <th>DateTime</th>
        <th>City Departure</th>
        <th>City Arrival</th>
        <th>Stok</th>
        <th>Weight</th>
        <th>Category</th>



    </tr>
");
            EndContext();
#line 32 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
            BeginContext(1075, 103, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center btn-success\" colspan=\"8\">No Item</td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
    }
    else
    {
        foreach (var item in Model)
        {
            
               
                
            

#line default
#line hidden
            BeginContext(1313, 58, true);
            WriteLiteral("            <tr>\r\n\r\n                \r\n                <td>");
            EndContext();
            BeginContext(1372, 9, false);
#line 49 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1409, 44, false);
#line 50 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Datetime.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1481, 19, false);
#line 51 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Departrue.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1500, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1529, 17, false);
#line 52 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Arrival.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 28, true);
            WriteLiteral(" </td>\r\n                <td>");
            EndContext();
            BeginContext(1575, 9, false);
#line 53 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Stok);

#line default
#line hidden
            EndContext();
            BeginContext(1584, 23, true);
            WriteLiteral("</td>\r\n                ");
            EndContext();
            BeginContext(1607, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbdf5951d47004612401ae008c900ad5658e279a13985", async() => {
                BeginContext(1640, 7, false);
#line 54 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
                                           Write(item.Kg);

#line default
#line hidden
                EndContext();
            }
            );
            __Task_Test_WebUI_Infrastructure_WeightTagHelper = CreateTagHelper<global::Task_Test.WebUI.Infrastructure.WeightTagHelper>();
            __tagHelperExecutionContext.Add(__Task_Test_WebUI_Infrastructure_WeightTagHelper);
#line 54 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
__Task_Test_WebUI_Infrastructure_WeightTagHelper.Weight = item.Kg.Value;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("weight-siz", __Task_Test_WebUI_Infrastructure_WeightTagHelper.Weight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1652, 24, true);
            WriteLiteral("\r\n\r\n                <td>");
            EndContext();
            BeginContext(1677, 18, false);
#line 56 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 30, true);
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\resid\source\repos\task_test\Task_Test.WebUI\Views\Product\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1743, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(1753, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbdf5951d47004612401ae008c900ad5658e279a16360", async() => {
                BeginContext(1822, 7, true);
                WriteLiteral("Create ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1833, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
