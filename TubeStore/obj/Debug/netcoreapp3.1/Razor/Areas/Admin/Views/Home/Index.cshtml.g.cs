#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627d4d16cc53cb7efc5631794290bd378defc08a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.Models.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.Models.Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.Areas.Admin.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\_ViewImports.cshtml"
using TubeStore.DataLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627d4d16cc53cb7efc5631794290bd378defc08a", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5063ab094c357dc6f060e5d84f0b42cab949d7b0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SmallBoxesRow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-muted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lte/chart.js/Chart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <h1 class=\"m-0 text-dark\">Sales Dashboard</h1>\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n<section class=\"content\">\r\n    <div class=\"container-fluid\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "627d4d16cc53cb7efc5631794290bd378defc08a7544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 18 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""d-flex"">
                            <p class=""d-flex flex-column"">
                                <span class=""text-bold text-lg"">Sales Over Time: ");
#nullable restore
#line 26 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                                                            Write(Model.CountInvoices);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </p>\r\n                            <p class=\"ml-auto d-flex flex-column text-right\">\r\n");
#nullable restore
#line 29 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                 if (@Model.ChartView.DeltaSales >= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-success\">\r\n                                        <i class=\"fas fa-arrow-up\"></i> ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                                                   Write(Model.ChartView.DeltaSales.ToString("P1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>");
#nullable restore
#line 32 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                           }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"text-danger\">\r\n                                        <i class=\"fas fa-arrow-down\"></i> ");
#nullable restore
#line 36 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                                                     Write(Model.ChartView.DeltaSales.ToString("P1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>");
#nullable restore
#line 37 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <span class=""text-muted"">Since last week</span>
                            </p>
                        </div>
                        <!-- /.d-flex -->

                        <div class=""position-relative mb-4"">
                            <canvas id=""visitors-chart"" height=""200""></canvas>
                        </div>

                        <div class=""d-flex flex-row justify-content-end"">
                            <span class=""mr-2"">
                                <i class=""fas fa-square text-primary""></i> This Week
                            </span>

                            <span>
                                <i class=""fas fa-square text-gray""></i> Last Week
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.card -->

            <div class=""col-lg-6"">
                <div class=""card"">
                    <div class=""card-body ta");
            WriteLiteral(@"ble-responsive p-0"">
                        <table class=""table table-striped table-valign-middle"">
                            <thead>
                                <tr>
                                    <th>Product</th>
                                    <th>Price</th>
                                    <th>Sold</th>
                                    <th>Datails</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 74 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                 foreach (var tube in Model.TableView)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 3278, "\"", 3302, 1);
#nullable restore
#line 78 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 3284, tube.UrlImageTube, 3284, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle img-size-32 mr-2\">\r\n                                            ");
#nullable restore
#line 79 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(tube.TubeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 81 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(tube.PriceTube.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 83 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                       Write(tube.SoldTubes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Sold\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627d4d16cc53cb7efc5631794290bd378defc08a15182", async() => {
                WriteLiteral("\r\n                                                <i class=\"fas fa-search\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 91 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n                <!-- /.card -->\r\n            </div>\r\n        </div>\r\n        <!-- /.col-md-6 -->\r\n    </div>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627d4d16cc53cb7efc5631794290bd378defc08a17533", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627d4d16cc53cb7efc5631794290bd378defc08a18573", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(function () {
        'use strict';

        var ticksStyle = {
            fontColor: '#495057',
            fontStyle: 'bold'
        };

        var mode = 'index';
        var intersect = true;

        var $visitorsChart = $('#visitors-chart');
        var visitorsChart = new Chart($visitorsChart, {
            data: {
                labels: ['");
#nullable restore
#line 121 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                     Write(Model.ChartView.RangeYThisWeek[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 122 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 123 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 124 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 125 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 126 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    \'");
#nullable restore
#line 127 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                Write(Model.ChartView.RangeYThisWeek[6]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'],\r\n                datasets: [{\r\n                    type: \'line\',\r\n                    data: [\r\n                        ");
#nullable restore
#line 131 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[0].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 132 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[1].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 133 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[2].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 134 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[3].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 135 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[4].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 136 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[5].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 137 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsThisWeek[6].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    ],
                    backgroundColor: 'transparent',
                    borderColor: '#007bff',
                    pointBorderColor: '#007bff',
                    pointBackgroundColor: '#007bff',
                    fill: false
                },
                {
                    type: 'line',
                    data: [
                        ");
#nullable restore
#line 148 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[0].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 149 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[1].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 150 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[2].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 151 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[3].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 152 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[4].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 153 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[5].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 154 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                   Write(Model.ChartView.ChartPointsLastWeek[6].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    ],
                    backgroundColor: 'tansparent',
                    borderColor: '#ced4da',
                    pointBorderColor: '#ced4da',
                    pointBackgroundColor: '#ced4da',
                    fill: false
                }]
            },
            options: {
                maintainAspectRatio: false,
                tooltips: {
                    mode: mode,
                    intersect: intersect
                },
                hover: {
                    mode: mode,
                    intersect: intersect
                },
                legend: {
                    display: false
                },
                scales: {
                    yAxes: [{
                        gridLines: {
                            display: true,
                            lineWidth: '4px',
                            color: 'rgba(0, 0, 0, .2)',
                            zeroLineColor: 'transparent'
                        },
 ");
            WriteLiteral("                       ticks: $.extend({\r\n                            beginAtZero: true,\r\n                            suggestedMax: ");
#nullable restore
#line 186 "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Home\Index.cshtml"
                                     Write(Model.ChartView.RangeX);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        }, ticksStyle)
                    }],
                    xAxes: [{
                        display: true,
                        gridLines: {
                            display: false
                        },
                        ticks: ticksStyle
                    }]
                }
            }
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
