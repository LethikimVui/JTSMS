#pragma checksum "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98264b9185832fc21c9a8d74763ccd70c80e47d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Master_Approval_get_by_routeId), @"mvc.1.0.view", @"/Views/Admin/Master_Approval_get_by_routeId.cshtml")]
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
#nullable restore
#line 1 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\_ViewImports.cshtml"
using JTSMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\_ViewImports.cshtml"
using JTSMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98264b9185832fc21c9a8d74763ccd70c80e47d2", @"/Views/Admin/Master_Approval_get_by_routeId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a9d1c99f0322faafdd5be8b9bbef9b276d9f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Master_Approval_get_by_routeId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VMasterApproval>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
  
    var Customers = ViewData["customers"] as IEnumerable<SharedObjects.ValueObjects.VCustomer>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered table-hover table-striped table-responsive"">
    <thead>
        <tr class=""text-center bold"">
            <th>Customer</th>
            <th>NTLogin</th>
            <th>Name</th>
            <th>Email</th>
            <th>Modification</th>
        </tr>
    </thead>
    <tbody>
        <tr class=""text-center"">
            <td>
                <select class=""form-control"" id=""txt-custid"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98264b9185832fc21c9a8d74763ccd70c80e47d25323", async() => {
                WriteLiteral("--Please Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                     foreach (var item in Customers.OrderByDescending(c => c.CustId).ToList())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98264b9185832fc21c9a8d74763ccd70c80e47d26863", async() => {
#nullable restore
#line 24 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                                              Write(item.CustName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                          WriteLiteral(item.CustId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </td>
            <td>
                <input id=""txt-Ntlogin"" type=""text"" class=""form-control"" data-toggle=""modal"" href=""#modal-search"" style=""height:30px"" />
            </td>
            <td id=""txt-userName""></td>
            <td id=""txt-userEmail""></td>
            <td class=""text-center"">
                <a id=""btn-add"" class=""btn default btn-xs purple""><span class=""glyphicon glyphicon-plus""></span></a>
            </td>
        </tr>

");
#nullable restore
#line 38 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
               Write(item.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
               Write(item.NTLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <a id=\"btn-delete\" class=\"btn default btn-xs purple\" data-username=\"");
#nullable restore
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-approvalId=\"");
#nullable restore
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
                                                                                                                Write(item.ApprovalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"glyphicon glyphicon-minus\"></span></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Master_Approval_get_by_routeId.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<div class=""modal-area"">
    <div class=""modal fade"" id=""modal-search"" tabindex=""-1"" role=""columnheader"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                    <h4 class=""modal-title"">Search User </h4>
                    <p hidden id=""hid-UserId""></p>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98264b9185832fc21c9a8d74763ccd70c80e47d212738", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""txt-CourseName"">NTID</label>
                        <input type=""text"" class=""form-control"" id=""txt-search-input"" style=""color:mediumvioletred"">
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btn-search-input"" class=""btn green"">Search</button>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!--Kết thúc Modal thêm, update-->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VMasterApproval>> Html { get; private set; }
    }
}
#pragma warning restore 1591
