#pragma checksum "C:\Users\daviti.chivadze\source\repos\FincaHR\FincaHR\Views\Employee\EmployeeCreateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c167060507a6cbc4bf87f0b749eca234e1e3e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeCreateModal), @"mvc.1.0.view", @"/Views/Employee/EmployeeCreateModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/EmployeeCreateModal.cshtml", typeof(AspNetCore.Views_Employee_EmployeeCreateModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c167060507a6cbc4bf87f0b749eca234e1e3e67", @"/Views/Employee/EmployeeCreateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df33f7c638dfd4c0debc5d31708aab52ad2c3c05", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeCreateModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/imageUpload.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("document.getElementById(\'UserImageUpload\').click()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserImageView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 769, true);
            WriteLiteral(@"<div id=""EmployeeCreateModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Create Employee</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""row"">
                            <div class=""col-md-4""></div>
                            <div class=""col-md-8"">

                                <input type=""file"" id=""UserImageUpload"" />
                                ");
            EndContext();
            BeginContext(769, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fc8a386585d486fac619fc3247c1c99", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(916, 2812, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeFirstName"">First Name</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeFirstName"" name=""EmployeeFirstName"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeLastName"">Last Name</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeLastName"" name=""EmployeeLastName"" class=""form-control"" />
                            </div>
");
            WriteLiteral(@"
                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeePIN"">Personal ID</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeePIN"" name=""EmployeePIN"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeBirthDate"">Birth Date</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeBirthDate"" name=""EmployeeBirthDate"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-");
            WriteLiteral(@"md-4"">
                                <label for=""EmployeeAddress"">Address</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeAddress"" name=""EmployeeAddress"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeGender"">Gender</label>
                            </div>
                            <div class=""col-md-8"">
                                <select id=""EmployeeGender"" name=""EmployeeGender"" class=""form-control"">
                                    ");
            EndContext();
            BeginContext(3728, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0981dc6cb3844eb0845c7557f2e4ac72", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3745, 3272, true);
            WriteLiteral(@"
                                </select>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeIPPhone"">IP Phone</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeIPPhone"" name=""EmployeeIPPhone"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeMobile"">Mobile</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeMobi");
            WriteLiteral(@"le"" name=""EmployeeMobile"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeHome"">Home</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeHome"" name=""EmployeeHome"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeEmergencyContact"">Emergency Contact</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeEmergencyContact"" name=""EmployeeEmergencyContact"" class=""form-control"" />
                            </div>

        ");
            WriteLiteral(@"                </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeEmail"">Email</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeEmail"" name=""EmployeeEmail"" class=""form-control"" />
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <label for=""EmployeeInsurancePackage"">Insurance Package</label>
                            </div>
                            <div class=""col-md-8"">
                                <input type=""text"" id=""EmployeeInsurancePackage"" name=""EmployeeInsurancePackage"" class=""form-control"" />
                            </div>

                        </div>
                    </div>
                </div>
            </div");
            WriteLiteral(">\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591