#pragma checksum "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19f2966b99145e919b870a258bbc364fb54035b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineers_AddMachine), @"mvc.1.0.view", @"/Views/Engineers/AddMachine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Engineers/AddMachine.cshtml", typeof(AspNetCore.Views_Engineers_AddMachine))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f2966b99145e919b870a258bbc364fb54035b1", @"/Views/Engineers/AddMachine.cshtml")]
    public class Views_Engineers_AddMachine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 47, true);
            WriteLiteral("\n<h2>Add a machine</h2>\n\n<h4>What machines are ");
            EndContext();
            BeginContext(107, 44, false);
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
                 Write(Html.DisplayFor(model => model.EngineerName));

#line default
#line hidden
            EndContext();
            BeginContext(151, 28, true);
            WriteLiteral(" licensed to work on?</h4>\n\n");
            EndContext();
#line 11 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(212, 41, false);
#line 13 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
            EndContext();
            BeginContext(260, 28, false);
#line 15 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.Label("Select machine"));

#line default
#line hidden
            EndContext();
            BeginContext(294, 30, false);
#line 16 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
            EndContext();
            BeginContext(325, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 18 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
}

#line default
#line hidden
            BeginContext(368, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(373, 45, false);
#line 20 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.ActionLink("See all engineers", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(418, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(427, 47, false);
#line 21 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineers/AddMachine.cshtml"
Write(Html.ActionLink("Return Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(474, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Factory.Models.Engineer> Html { get; private set; }
    }
}
#pragma warning restore 1591
