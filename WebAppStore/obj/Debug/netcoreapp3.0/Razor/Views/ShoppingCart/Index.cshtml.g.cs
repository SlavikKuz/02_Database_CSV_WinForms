#pragma checksum "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a584039de4bd7066b3e9fb699adf72c1e1bee8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "d:\Repos\05 - Web Store\WebAppStore\Views\_ViewImports.cshtml"
using WebAppStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Repos\05 - Web Store\WebAppStore\Views\_ViewImports.cshtml"
using WebAppStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Repos\05 - Web Store\WebAppStore\Views\_ViewImports.cshtml"
using WebAppStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a584039de4bd7066b3e9fb699adf72c1e1bee8d", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f494bb41b4bc3416a8ce56a6c8139636c136946", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2> Shooping cart </h2>
<table class=""table table-bordered table-striped"">
    <thread>
        <tr>
            <th>Selected amount</th>
            <th>Tube</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thread>
    <tbody>
");
#nullable restore
#line 14 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
         foreach (var item in Model.ShoppingCart.ShoppingCartItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
#nullable restore
#line 17 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 18 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                                 Write(item.Tube.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                                                  Write(item.Tube.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 18 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                                                                    Write(item.Tube.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 19 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                                  Write(item.Tube.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-right\">\r\n                    ");
#nullable restore
#line 21 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
                Write((item.Amount * item.Tube.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">\r\n                ");
#nullable restore
#line 30 "d:\Repos\05 - Web Store\WebAppStore\Views\ShoppingCart\Index.cshtml"
           Write(Model.ShoppingCartTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
