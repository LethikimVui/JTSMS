#pragma checksum "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_Get), @"mvc.1.0.view", @"/Views/Request/Get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5738b31a3a4d00cd467d5af38a92a561ccd7ef3f", @"/Views/Request/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a9d1c99f0322faafdd5be8b9bbef9b276d9f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/request.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
  
    ViewData["Title"] = "";
    var Customers = ViewData["Customer"] as IEnumerable<SharedObjects.ValueObjects.VCustomer>;
    var Station = ViewData["Station"] as IEnumerable<SharedObjects.ValueObjects.VStation>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">

        <div class=""col-md-12"" style=""min-height: auto !important;height: auto !important;"">

            <!-- BEGIN EXAMPLE TABLE PORTLET-->
            <div class=""portlet light"" style=""min-height: auto !important;height: auto !important"">
                <div class=""portlet-title"">

                    <div class=""caption col-md-12"">
                        <span class=""caption-subject font-green-sharp bold uppercase"">
                            Get Test Script ID
                        </span>
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 964, "\"", 970, 0);
            EndWriteAttribute();
            WriteLiteral(">WorkCell</label>\r\n                        <select class=\"form-control\" id=\"txt-customer-search\" data-search=\"customer\" name=\"customer\" style=\"color:mediumvioletred\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f6699", async() => {
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
#line 26 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                             foreach (var item in Customers.OrderByDescending(c => c.CustName).ToList())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f8269", async() => {
#nullable restore
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
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
#line 28 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
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
#line 29 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n                    <div class=\"form-group col-md-2 pull-left\">\r\n                        <label class=\"text-center bold font-green-sharp\"");
            BeginWriteAttribute("for", " for=\"", 1664, "\"", 1670, 0);
            EndWriteAttribute();
            WriteLiteral(">Station</label>\r\n                        <select class=\"form-control\" id=\"txt-station-search\" data-search=\"station\" name=\"station\" style=\"color:mediumvioletred\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f10983", async() => {
                WriteLiteral("--Please Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                             foreach (var item in Station.OrderByDescending(c => c.Station).ToList())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f12551", async() => {
#nullable restore
#line 38 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                                                         Write(item.Station);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                                  WriteLiteral(item.StationId);

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
#line 39 "C:\Users\1099969\OneDrive - Jabil\Desktop\Development_Project\Web\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\Get.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n                    </div>\r\n\r\n                    <div class=\"form-group col-md-2 pull-left\">\r\n                        <label class=\"text-center bold font-green-sharp\"");
            BeginWriteAttribute("for", " for=\"", 2360, "\"", 2366, 0);
            EndWriteAttribute();
            WriteLiteral(@">Assembly Number</label>
                        <label class=""control-label""></label>
                        <input id=""txt-assy"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 2700, "\"", 2706, 0);
            EndWriteAttribute();
            WriteLiteral(@">Revision</label>
                        <label class=""control-label""></label>
                        <input id=""txt-rev"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 3032, "\"", 3038, 0);
            EndWriteAttribute();
            WriteLiteral(">Type</label>\r\n                        <select class=\"form-control\" id=\"txt-type-search\" data-search=\"type\" name=\"type\" style=\"color:mediumvioletred\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f16219", async() => {
                WriteLiteral("--Please Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f17418", async() => {
                WriteLiteral("New ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f18604", async() => {
                WriteLiteral("Deviation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f19795", async() => {
                WriteLiteral("PCN");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <div class=\"form-group col-md-2 pull-left\">\r\n                        <label class=\"text-center bold font-green-sharp\"");
            BeginWriteAttribute("for", " for=\"", 3644, "\"", 3650, 0);
            EndWriteAttribute();
            WriteLiteral(@">Script Name</label>
                        <label class=""control-label""></label>
                        <input id=""txt-scriptname"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 3986, "\"", 3992, 0);
            EndWriteAttribute();
            WriteLiteral(@">Script Revision</label>
                        <label class=""control-label""></label>
                        <input id=""txt-scriptrev"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 4331, "\"", 4337, 0);
            EndWriteAttribute();
            WriteLiteral(@">Firmware</label>
                        <label class=""control-label""></label>
                        <input id=""txt-firmware"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-2 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 4668, "\"", 4674, 0);
            EndWriteAttribute();
            WriteLiteral(@">Firmware Revision</label>
                        <label class=""control-label""></label>
                        <input id=""txt-firmware"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-4 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 5014, "\"", 5020, 0);
            EndWriteAttribute();
            WriteLiteral(@">Description</label>
                        <label class=""control-label""></label>
                        <input id=""txt-desc"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-12 pull-left"">
                        <label class=""text-center bold font-green-sharp""");
            BeginWriteAttribute("for", " for=\"", 5351, "\"", 5357, 0);
            EndWriteAttribute();
            WriteLiteral(@">Test Script ID</label>
                        <input type=""text"" id=""txt-scriptid"" class=""form-control col-md-3"" />
                    </div>
                    <div class=""form-group col-md-12"">
                        <a class=""btn btn-success"" id=""btn-get"">Get</a>
                    </div>


                </div>


            </div>


        </div>

    </div>

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5738b31a3a4d00cd467d5af38a92a561ccd7ef3f24237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591