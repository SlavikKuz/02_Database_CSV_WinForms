#pragma checksum "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_AvailableInPairs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f17aafb7f567efc43c1a6faf936db343ef37f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AvailableInPairs), @"mvc.1.0.view", @"/Views/Shared/_AvailableInPairs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f17aafb7f567efc43c1a6faf936db343ef37f04", @"/Views/Shared/_AvailableInPairs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fd7e7b0d868ba8e8fc73ec19ed1c370f10478e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AvailableInPairs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tube>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_AvailableInPairs.cshtml"
 if (Model.MatchedPair)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> Available in pairs! </p>");
#nullable restore
#line 4 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_AvailableInPairs.cshtml"
                                 }
else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p> Perfect singles!</p>");
#nullable restore
#line 6 "d:\Repos\05 - TubeStore\TubeStore\Views\Shared\_AvailableInPairs.cshtml"
                             }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tube> Html { get; private set; }
    }
}
#pragma warning restore 1591
