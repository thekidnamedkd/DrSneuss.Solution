#pragma checksum "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b50cc49ae9baf960c05292e867c34181b58b44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machine_Edit), @"mvc.1.0.view", @"/Views/Machine/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Machine/Edit.cshtml", typeof(AspNetCore.Views_Machine_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b50cc49ae9baf960c05292e867c34181b58b44", @"/Views/Machine/Edit.cshtml")]
    public class Views_Machine_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Machine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(58, 24, true);
            WriteLiteral("\n<h2>Edit this machine: ");
            EndContext();
            BeginContext(83, 43, false);
#line 7 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
                  Write(Html.DisplayFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(126, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(166, 40, false);
#line 11 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.HiddenFor(model => model.MachineId));

#line default
#line hidden
            EndContext();
            BeginContext(213, 41, false);
#line 13 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.LabelFor(model => model.MachineName));

#line default
#line hidden
            EndContext();
            BeginContext(260, 86, false);
#line 14 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.EditorFor(model => model.MachineName, new { type = "text", required="required" }));

#line default
#line hidden
            EndContext();
            BeginContext(353, 44, false);
#line 16 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.LabelFor(model => model.MachineProduct));

#line default
#line hidden
            EndContext();
            BeginContext(403, 89, false);
#line 17 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.EditorFor(model => model.MachineProduct, new { type = "text", required="required" }));

#line default
#line hidden
            EndContext();
            BeginContext(494, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 20 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(537, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(541, 40, false);
#line 21 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.ActionLink("All Machines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(590, 47, false);
#line 22 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Machine/Edit.cshtml"
Write(Html.ActionLink("Return Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(637, 4, true);
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
