#pragma checksum "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb87477fa66ce41523c54399bb283a0433a5a033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Engineer_Edit), @"mvc.1.0.view", @"/Views/Engineer/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Engineer/Edit.cshtml", typeof(AspNetCore.Views_Engineer_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb87477fa66ce41523c54399bb283a0433a5a033", @"/Views/Engineer/Edit.cshtml")]
    public class Views_Engineer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Factory.Models.Engineer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 33, true);
            WriteLiteral("\n<h2>Edit engineer profile</h2>\n\n");
            EndContext();
            BeginContext(91, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(123, 41, false);
#line 11 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.HiddenFor(model => model.EngineerId));

#line default
#line hidden
            EndContext();
            BeginContext(171, 28, false);
#line 13 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.Label("Engineer Name "));

#line default
#line hidden
            EndContext();
            BeginContext(203, 43, false);
#line 14 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.EditorFor(model => model.EngineerName));

#line default
#line hidden
            EndContext();
            BeginContext(247, 7, true);
            WriteLiteral("<hr />\n");
            EndContext();
            BeginContext(257, 24, false);
#line 16 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.Label("Hire Date "));

#line default
#line hidden
            EndContext();
            BeginContext(285, 61, false);
#line 17 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.EditorFor(model => model.HireDate, new { type = "date"}));

#line default
#line hidden
            EndContext();
            BeginContext(347, 7, true);
            WriteLiteral("<hr />\n");
            EndContext();
            BeginContext(357, 31, false);
#line 19 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.Label("Current Machines "));

#line default
#line hidden
            EndContext();
            BeginContext(392, 30, false);
#line 20 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.DropDownList("MachineId"));

#line default
#line hidden
            EndContext();
            BeginContext(423, 87, true);
            WriteLiteral("<hr />\n  <input type=\"submit\" value=\"Save engineer changes\" class=\"btn btn-default\" />\n");
            EndContext();
#line 23 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(512, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(517, 47, false);
#line 25 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Engineer/Edit.cshtml"
Write(Html.ActionLink("Return Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(564, 4, true);
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