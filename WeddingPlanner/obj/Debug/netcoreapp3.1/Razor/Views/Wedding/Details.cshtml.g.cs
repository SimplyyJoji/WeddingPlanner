#pragma checksum "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53dabdc2770d8bce85703ee2a69681c7a93a18c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Details), @"mvc.1.0.view", @"/Views/Wedding/Details.cshtml")]
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
#line 1 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53dabdc2770d8bce85703ee2a69681c7a93a18c9", @"/Views/Wedding/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a836a4045b5a7b44d4678b001bba9011e9862f63", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"card shadow rounded mx-auto mb-3\">\n  <h4 class=\"card-title text-center bg-dark text-light py-2 rounded-top\">\n    ");
#nullable restore
#line 9 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
Write(Model.NameOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 9 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
                Write(Model.NameTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding\n  </h4>\n  <div class=\"card-body\">\n    <p class=\"card-text\">");
#nullable restore
#line 12 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
                    Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <small class=\"text-muted\">Submitted on: ");
#nullable restore
#line 13 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
                                       Write(Model.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n  </div>\n  <div class=\"card-body\">\n    <h3>RSVPs</h3>\n");
#nullable restore
#line 17 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
     foreach (Rsvps rsvp in Model.UserRsvps)
    {
      

#line default
#line hidden
#nullable disable
            WriteLiteral("      <span>");
#nullable restore
#line 20 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
       Write(rsvp.User.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\n");
#nullable restore
#line 21 "/Users/javanogden/Desktop/CodingDojo/cSharp/ORM/WeddingPlanner/WeddingPlanner/Views/Wedding/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\n  \n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
