#pragma checksum "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fd3235c7b29920a85c015c601f49ec3656e1ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Details), @"mvc.1.0.view", @"/Views/Stylists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Details.cshtml", typeof(AspNetCore.Views_Stylists_Details))]
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
#line 5 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fd3235c7b29920a85c015c601f49ec3656e1ab", @"/Views/Stylists/Details.cshtml")]
    public class Views_Stylists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 37, true);
            WriteLiteral("\n<h2>Stylist Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(124, 40, false);
#line 10 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(164, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(167, 36, false);
#line 10 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(203, 12, true);
            WriteLiteral("</h3>\n\n<ul>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
 if (@Model.Clients.Count == 0)
{

#line default
#line hidden
            BeginContext(249, 26, true);
            WriteLiteral("  <p>no clients found</p>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
}

#line default
#line hidden
            BeginContext(277, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
 foreach (Client client in @Model.Clients)
{

#line default
#line hidden
            BeginContext(323, 15, true);
            WriteLiteral("  <li>Clients: ");
            EndContext();
            BeginContext(339, 18, false);
#line 20 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
          Write(client.Description);

#line default
#line hidden
            EndContext();
            BeginContext(357, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
}

#line default
#line hidden
            BeginContext(365, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(376, 44, false);
#line 24 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Back to stylists", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(420, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(429, 69, false);
#line 25 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Edit Stylist", "Edit", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(498, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(507, 73, false);
#line 26 "/Users/Guest/Desktop/HairSalon.Solution2/HairSalon/Views/Stylists/Details.cshtml"
Write(Html.ActionLink("Delete Stylist", "Delete", new { id = Model.StylistId }));

#line default
#line hidden
            EndContext();
            BeginContext(580, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591