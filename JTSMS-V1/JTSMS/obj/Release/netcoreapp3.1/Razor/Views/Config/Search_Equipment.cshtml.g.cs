#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f2be7d216d7a6299ee53d19a2eef880920daa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Search_Equipment), @"mvc.1.0.view", @"/Views/Config/Search_Equipment.cshtml")]
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
#line 1 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\_ViewImports.cshtml"
using JTSMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\_ViewImports.cshtml"
using JTSMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f2be7d216d7a6299ee53d19a2eef880920daa5", @"/Views/Config/Search_Equipment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a9d1c99f0322faafdd5be8b9bbef9b276d9f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Search_Equipment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JTSMS.Models.EquipmentViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f2be7d216d7a6299ee53d19a2eef880920daa53416", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered table-hover table-striped table-responsive"">
        <thead>
            <tr class=""text-center bold"">
                <th>Equipment_ID</th>
                <th>CommonName</th>
                <th></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 14 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
               Write(item.Equipment_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
               Write(item.CommonName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <button id=\"btn-select\" type=\"button\" class=\"btn green select\" data-name=\"");
#nullable restore
#line 20 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
                                                                                         Write(item.CommonName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-id=\"");
#nullable restore
#line 20 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
                                                                                                                    Write(item.Equipment_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Select</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Config\Search_Equipment.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JTSMS.Models.EquipmentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
