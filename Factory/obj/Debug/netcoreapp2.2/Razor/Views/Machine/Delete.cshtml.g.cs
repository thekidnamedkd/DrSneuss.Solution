#pragma checksum "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb64312c3c686cab56ae4813c5acaf192bf105b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machine_Delete), @"mvc.1.0.view", @"/Views/Machine/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machine/Delete.cshtml", typeof(AspNetCore.Views_Machine_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb64312c3c686cab56ae4813c5acaf192bf105b0", @"/Views/Machine/Delete.cshtml")]
    public class Views_Machine_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 57, true);
            WriteLiteral("\n<h2>Are you sure you want to remove this machine?</h2>\n\n");
            EndContext();
            BeginContext(116, 47, false);
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(163, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(166, 43, false);
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
                                             Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(209, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(238, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(283, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(287, 44, false);
#line 14 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
Write(Html.ActionLink("Back to machines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(331, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(340, 47, false);
#line 15 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Delete.cshtml"
Write(Html.ActionLink("Return Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(387, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Machine> Html { get; private set; }
    }
}
#pragma warning restore 1591
