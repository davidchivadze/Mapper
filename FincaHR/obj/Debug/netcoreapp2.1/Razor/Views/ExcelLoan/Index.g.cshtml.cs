#pragma checksum "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5335181520ccc183e97b60dda2c2a725d0cd2e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExcelLoan_Index), @"mvc.1.0.view", @"/Views/ExcelLoan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ExcelLoan/Index.cshtml", typeof(AspNetCore.Views_ExcelLoan_Index))]
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
#line 1 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\_ViewImports.cshtml"
using FincaHR;

#line default
#line hidden
#line 2 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\_ViewImports.cshtml"
using FincaHR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5335181520ccc183e97b60dda2c2a725d0cd2e8a", @"/Views/ExcelLoan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df33f7c638dfd4c0debc5d31708aab52ad2c3c05", @"/Views/_ViewImports.cshtml")]
    public class Views_ExcelLoan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ViewModels.ExcelLoan.FolderFileListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 304, true);
            WriteLiteral(@"
<h2>File List</h2>

<h4>FileListModel</h4>
<hr />
<div class=""row"">
<div class=""col-md-12"">
    <table class=""table table-condensed"">
        <thead>
            <tr>
                <th>File Name</th>
                <th>File Type</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml"
             foreach (var file in Model.FileListModels)
            {

#line default
#line hidden
            BeginContext(526, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(573, 13, false);
#line 25 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml"
                   Write(file.FileName);

#line default
#line hidden
            EndContext();
            BeginContext(586, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(618, 17, false);
#line 26 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml"
                   Write(file.FileTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\ExcelLoan\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(680, 67, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n</div>\r\n\r\n<div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ViewModels.ExcelLoan.FolderFileListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
