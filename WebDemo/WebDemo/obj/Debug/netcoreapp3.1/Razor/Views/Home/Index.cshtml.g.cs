#pragma checksum "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c11a2e38f7924ac63200abd7ecef465d6db305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\_ViewImports.cshtml"
using WebDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\_ViewImports.cshtml"
using WebDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c11a2e38f7924ac63200abd7ecef465d6db305", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d56dcb61d88e82c427f12429121e0342a73935f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to my site</h1>\r\n\r\n</div>\r\n");
#nullable restore
#line 9 "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "DotNet"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"DotNet\" />\r\n");
#nullable restore
#line 13 "E:\Code\C#\Test\ASP.NET\.vs\WebDemo\WebDemo\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
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