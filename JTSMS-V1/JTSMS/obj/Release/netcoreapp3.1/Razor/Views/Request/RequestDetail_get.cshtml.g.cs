#pragma checksum "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c8b08f599cfa7012f97903d861ec2dce453547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_RequestDetail_get), @"mvc.1.0.view", @"/Views/Request/RequestDetail_get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c8b08f599cfa7012f97903d861ec2dce453547", @"/Views/Request/RequestDetail_get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a9d1c99f0322faafdd5be8b9bbef9b276d9f8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_RequestDetail_get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SharedObjects.ValueObjects.VDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-add-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frm-save"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
  
    var customers = ViewData["Customer"] as IEnumerable<SharedObjects.ValueObjects.VCustomer>;
    var Station = ViewData["Station"] as IEnumerable<SharedObjects.ValueObjects.VStation>;
    var Type = ViewData["Type"] as IEnumerable<SharedObjects.ValueObjects.VType>;
    //var RouteStep = ViewData["RouteStep"] as IEnumerable<SharedObjects.ValueObjects.VRouteStep>;
    // var RouteStep = ViewData["RouteStep"] as IEnumerable<JTSMS.Models.Recordset>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce4535476067", async() => {
                WriteLiteral(@"
    <table class=""table table-bordered table-hover table-striped table-responsive"">
        <thead>
            <tr class=""text-center bold"">
                <th>No.</th>
                <th>Customer</th>
                <th>Station</th>
                <th>RouteStep</th>
                <th>Assembly Number</th>
                <th>Assembly Revision</th>
                <th>Type</th>
                <th>Platform</th>
                <th>Test Script Id</th>
                <th>Description</th>
                <th>Status</th>
                <th>Modification</th>
            </tr>
        </thead>
        <tbody>
            <tr class=""text-center"">
                <td>New</td>
                <td>
                    <select class=""form-control"" id=""txt-customer"" name=""customer"" required onchange=""fncOnChangeCustomer()"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce4535477216", async() => {
                    WriteLiteral("Please Select");
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
#line 35 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                         foreach (var item in customers.OrderByDescending(c => c.CustId).ToList())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce4535478821", async() => {
#nullable restore
#line 37 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
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
#line 37 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
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
#line 38 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </td>
                <td>
                    <select class=""form-control"" id=""txt-station"" name=""station"" style=""height: 34px !important; color: mediumvioletred"" onchange=""fncOnChangeStation(this)"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354711282", async() => {
                    WriteLiteral("Please Select");
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
#line 44 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                         foreach (var item in Station.OrderByDescending(c => c.Station).ToList())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354712887", async() => {
#nullable restore
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
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
#line 46 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                              WriteLiteral(item.StepId);

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
#line 47 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </td>\r\n                <td>\r\n                    <select class=\"form-control\" id=\"txt-route\" name=\"route\" style=\"height: 34px !important; color: mediumvioletred\">\r\n");
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354715352", async() => {
                    WriteLiteral("--Please Select Station--");
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
                WriteLiteral("\r\n\r\n                    </select>\r\n                </td>\r\n                <td>\r\n                    <input id=\"txt-assy\" name=\"assy\" type=\"text\" class=\"form-control\" style=\"height:30px\" data-toggle=\"modal\" href=\"#modal-search\" readonly />\r\n");
                WriteLiteral("                </td>\r\n                <td>\r\n                    <input id=\"txt-rev\" name=\"rev\" type=\"text\" class=\"form-control\" style=\"height:30px\" readonly />\r\n");
                WriteLiteral("                </td>\r\n                <td>\r\n                    <select class=\"form-control\" id=\"txt-type\" name=\"type\" data-search=\"type\" style=\"color:mediumvioletred\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354717316", async() => {
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
#line 81 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                         foreach (var item in Type.OrderByDescending(c => c.TypeId).ToList())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354718921", async() => {
#nullable restore
#line 83 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                                                  Write(item.Type);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                              WriteLiteral(item.TypeId);

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
#line 84 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </td>\r\n                <td>\r\n                    <select class=\"form-control\" id=\"txt-platform\" data-search=\"platform\" name=\"platform\" style=\"color:mediumvioletred\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354721349", async() => {
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354722608", async() => {
                    WriteLiteral("JEMSts ");
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354723857", async() => {
                    WriteLiteral("Jabil Test");
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
                WriteLiteral(@"
                    </select>
                </td>
                <td></td>
                <td>
                    <input id=""txt-description"" type=""text"" class=""form-control"" style=""height:30px"" />
                </td>
                <td></td>
                <td class=""text-center"">
                    <a id=""btn-add"" class=""btn default btn-xs purple update"" title=""Get Test Script ID""> <span class=""glyphicon glyphicon-plus""></span></a>
                </td>
            </tr>

");
#nullable restore
#line 104 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.ReqId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.CustName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 109 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.Station);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 110 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.routeStepId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 111 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.AssemblyNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 112 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.AssemblyRevision);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 113 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 114 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.Platform);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 115 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.ScriptId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 116 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td");
                BeginWriteAttribute("style", " style=\"", 5963, "\"", 6006, 2);
                WriteAttributeValue("", 5971, "background-color:", 5971, 17, true);
#nullable restore
#line 117 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
WriteAttributeValue("", 5988, item.StatusColour, 5988, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 117 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                                                               Write(item.StatusName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <a id=\"btn-edit\" class=\"btn default btn-xs purple\" data-reqId=\"");
#nullable restore
#line 119 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
                                                                                  Write(item.ReqId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 6192, "\"", 6274, 1);
#nullable restore
#line 119 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
WriteAttributeValue("", 6199, Url.Action("RequestDetail_get_by_id","Request", new { reqid = item.ReqId}), 6199, 75, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Edit\"> <span class=\"glyphicon glyphicon-list-alt\"></span></a>\r\n");
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 124 "C:\Users\1099969\Desktop\Development\GitHub\JTSMS\JTSMS-V1\JTSMS\Views\Request\RequestDetail_get.cshtml"
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""modal-area"">
    <div class=""modal fade"" id=""modal-search"" tabindex=""-1"" role=""columnheader"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""></button>
                    <h4 class=""modal-title"">Search Assembly Number</h4>
                    <p hidden id=""hid-UserId""></p>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c8b08f599cfa7012f97903d861ec2dce45354732719", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 7275, "\"", 7281, 0);
                EndWriteAttribute();
                WriteLiteral(@">Assembly Number</label>
                        <input type=""text"" class=""form-control"" id=""txt-search-input"" style=""color:mediumvioletred"" />
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btn-search-input"" class=""btn green"">Search</button>
                    </div>
                    <div id=""tbl-result"">

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SharedObjects.ValueObjects.VDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
