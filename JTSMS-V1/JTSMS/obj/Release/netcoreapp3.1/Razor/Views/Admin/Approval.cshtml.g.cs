#pragma checksum "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "135e5f97a6624944399f418e2c78faf17b1e10bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Approval), @"mvc.1.0.view", @"/Views/Admin/Approval.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"135e5f97a6624944399f418e2c78faf17b1e10bc", @"/Views/Admin/Approval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a9d1c99f0322faafdd5be8b9bbef9b276d9f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Approval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VRoute>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin-approval.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
  
    ViewData["Title"] = "Administration - Approval";
    var Routes = ViewData["Routes"] as IEnumerable<SharedObjects.ValueObjects.VRoute>;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""min-height: auto !important;height: auto !important"">
                <div class=""portlet-title"">
                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Administration - Approval
                        </span>
                    </div>
                    <table class=""table table-bordered table-hover table-striped"">
                        <thead>
                            <tr class=""text-center bold"">
                                <td>RouteId</td>
                                <td>Route Name</td>
                                <td style=""width:100px"">Modification</td>
                            </tr>
                        </thead>
                        <tbody id=""table-data"">
");
#nullable restore
#line 40 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 2133, "\"", 2138, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                                         Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td");
            BeginWriteAttribute("id", " id=\"", 2199, "\"", 2204, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                                         Write(item.RouteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n                                        <a id=\"btn-detail\" class=\"btn default btn-xs purple\" data-id=\"");
#nullable restore
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                                                                                                 Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-routename=\"");
#nullable restore
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                                                                                                                                Write(item.RouteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Detail\"> <span class=\"glyphicon glyphicon-new-window\"></span></a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Admin\Approval.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>


                    <div class=""portlet light table-responsive col-md-12 "" id=""detail"" style=""display:none; min-height: auto !important;"">
                        <div class=""caption col-md-12"">
                            <span id=""lbl-title"" class=""caption-subject font-green-sharp bold uppercase"">

                            </span>
                        </div>
                        <div id=""tbl-detail"" class=""table-responsive col-md-12"">

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135e5f97a6624944399f418e2c78faf17b1e10bc8245", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VRoute>> Html { get; private set; }
    }
}
#pragma warning restore 1591
