#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5569d76a72e68e3f5d1cd94e9375e02531e809e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5569d76a72e68e3f5d1cd94e9375e02531e809e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Home/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 106, true);
            WriteLiteral("\n<h1 class=\"jumbotron\">Epicodus Hair Salon</h1>\n<div class=\"card\">\n    <div class=\"card-body\">\n        <p>");
            EndContext();
            BeginContext(136, 51, false);
#line 8 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Home/Index.cshtml"
      Write(Html.ActionLink("Back to list", "Index", "Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(187, 81, true);
            WriteLiteral("</p>\n    </div>\n</div>\n<div class=\"card\">\n    <div class=\"card-body\">\n        <p>");
            EndContext();
            BeginContext(269, 56, false);
#line 13 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Home/Index.cshtml"
      Write(Html.ActionLink("Add more Animals", "Create", "Clients"));

#line default
#line hidden
            EndContext();
            BeginContext(325, 25, true);
            WriteLiteral("</p>\n    </div>\n</div>\n\n\n");
            EndContext();
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
