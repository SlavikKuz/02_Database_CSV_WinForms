#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Areas\Admin\Views\Shared\_Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fab02bd89497c5b915f6e68a2731376fb9dfa1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Messages), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Messages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fab02bd89497c5b915f6e68a2731376fb9dfa1e", @"/Areas/Admin/Views/Shared/_Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5063ab094c357dc6f060e5d84f0b42cab949d7b0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<li class=""nav-item dropdown"">
    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
        <i class=""far fa-comments""></i>
        <span class=""badge badge-danger navbar-badge"">3</span>
    </a>
    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
        <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
                <img src=""dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
                <div class=""media-body"">
                    <h3 class=""dropdown-item-title"">
                        Brad Diesel
                        <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                    </h3>
                    <p class=""text-sm"">Call me whenever you can...</p>
                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                </div>
            </div>
            <!-- Message End -->
        <");
            WriteLiteral(@"/a>
        <div class=""dropdown-divider""></div>
        <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
                <img src=""dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                <div class=""media-body"">
                    <h3 class=""dropdown-item-title"">
                        John Pierce
                        <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                    </h3>
                    <p class=""text-sm"">I got your message bro</p>
                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                </div>
            </div>
            <!-- Message End -->
        </a>
        <div class=""dropdown-divider""></div>
        <a href=""#"" class=""dropdown-item"">
            <!-- Message Start -->
            <div class=""media"">
                <img src=""dist/img/user3-128x128.jpg"" alt=""User Av");
            WriteLiteral(@"atar"" class=""img-size-50 img-circle mr-3"">
                <div class=""media-body"">
                    <h3 class=""dropdown-item-title"">
                        Nora Silvester
                        <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                    </h3>
                    <p class=""text-sm"">The subject goes here</p>
                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                </div>
            </div>
            <!-- Message End -->
        </a>
        <div class=""dropdown-divider""></div>
        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
    </div>
</li>");
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
