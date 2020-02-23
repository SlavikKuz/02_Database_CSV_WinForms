#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937007af9fcb7102a3ecd20268a65207739e113a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Details), @"mvc.1.0.view", @"/Views/Invoice/Details.cshtml")]
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
#line 1 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Repos\05 - TubeStore\TubeStore\Views\_ViewImports.cshtml"
using TubeStore.DataLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937007af9fcb7102a3ecd20268a65207739e113a", @"/Views/Invoice/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fd7e7b0d868ba8e8fc73ec19ed1c370f10478e", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TubeStore.Models.Invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition register-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "937007af9fcb7102a3ecd20268a65207739e113a4603", async() => {
                WriteLiteral(@"
    <div class=""row justify-content-center"">
        <div class=""col-sm-12"">
            <div class=""register-box"">
                <div class=""card"">
                    <div class=""card-body register-card-body"">

                        <div>
                            <h4 class=""my-2"">Invoice #");
#nullable restore
#line 15 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                 Write(Model.InvoiceId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                            <h6>From ");
#nullable restore
#line 16 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                Write(Model.OrderDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral(", Status: ");
#nullable restore
#line 16 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                              Write(Model.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n                            <hr />\r\n                            <div class=\"row ml-4\">\r\n                                <p><b>");
#nullable restore
#line 19 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                 Write(Model.Customer.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 19 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                           Write(Model.Customer.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>, tel. ");
#nullable restore
#line 19 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                              Write(Model.Customer.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 19 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                           Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <div class=""row ml-4"">
                                <h6><u>Billing Address:</u></h6>
                            </div>
                            <div class=""row ml-4"">
                                <p>");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                              Write(Model.Customer.AddressLine1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                           Write(Model.Customer.AddressLine2);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                         Write(Model.Customer.ZipCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                 Write(Model.Customer.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                                       Write(Model.Customer.State);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 25 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                                                              Write(Model.Customer.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <div class=""row ml-4"">
                                <h6><u>Shipping Address:</u></h6>
                            </div>
                            <div class=""row ml-4"">
                                <p>");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                              Write(Model.ShippingAddress.AddressLine1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                  Write(Model.ShippingAddress.AddressLine2);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                       Write(Model.ShippingAddress.ZipCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                                      Write(Model.ShippingAddress.City);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                                                                   Write(Model.ShippingAddress.State);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 31 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                                                                                                                                 Write(Model.ShippingAddress.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <p><h6><u>Purchased Items:</u></h6></p>
                        </div>
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        Tube
                                    </th>
                                    <th>
                                        Type
                                    </th>
                                    <th>
                                        Specifics
                                    </th>
                                    <th>
                                        Quantity
                                    </th>
                                    <th>
                                        Price
                                    </th>
                                    <th>
                                        Total
     ");
                WriteLiteral("                               </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 59 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                 foreach (var item in @Model.InvoicesInfo)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 3183, "\"", 3217, 1);
#nullable restore
#line 63 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
WriteAttributeValue("", 3189, item.Tube.ImageThumbnailUrl, 3189, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"figure-img img-fluid rounded\" width=\"50\"");
                BeginWriteAttribute("alt", " alt=\"", 3266, "\"", 3272, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 66 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                       Write(item.Tube.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 66 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                        Write(item.Tube.Type);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 69 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                       Write(item.Tube.ShortDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 75 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <th>\r\n");
#nullable restore
#line 78 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                             if (item.Tube.Discount == 0)
                                            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                         Write((item.Price * item.Quantity).ToString("c"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                                          }
                                        else
                                        { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                      Write((item.Price * item.Quantity * (1 - item.Tube.Discount)).ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>Discount: ");
#nullable restore
#line 82 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                Write(item.Tube.Discount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" % </p>");
#nullable restore
#line 82 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </th>\r\n                                    </tr>\r\n");
#nullable restore
#line 85 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </tbody>\r\n                        </table>                    \r\n                        \r\n                        <p class=\"text-center\">\r\n                            ");
#nullable restore
#line 90 "d:\Repos\05 - TubeStore\TubeStore\Views\Invoice\Details.cshtml"
                       Write(Html.ActionLink("Pay", "PayInvoice", new { id = Model.InvoiceId }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" |\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "937007af9fcb7102a3ecd20268a65207739e113a18457", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TubeStore.Models.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591