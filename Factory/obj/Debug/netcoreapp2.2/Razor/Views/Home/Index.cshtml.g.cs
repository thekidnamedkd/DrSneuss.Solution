#pragma checksum "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efaaccf3c3cc26ee8c771c9fb72eeaf66b9b9bd5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efaaccf3c3cc26ee8c771c9fb72eeaf66b9b9bd5", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 108, true);
            WriteLiteral("\n<h1>Welcome to the wonderful, wild factory of Dr. Sneuss</h1>\n<hr />\n<button class=\"btn btn-warning btn-md\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 135, "\"", 194, 3);
            WriteAttributeValue("", 145, "location.href=\'", 145, 15, true);
#line 7 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Home/Index.cshtml"
WriteAttributeValue("", 160, Url.Action("Index", "Engineers"), 160, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 193, "\'", 193, 1, true);
            EndWriteAttribute();
            BeginContext(195, 76, true);
            WriteLiteral(">View current engineers</button>\n<br>\n<button class=\"btn btn-warning btn-md\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 271, "\"", 329, 3);
            WriteAttributeValue("", 281, "location.href=\'", 281, 15, true);
#line 9 "/Users/thekidnamedkd/Desktop/DrSneuss.Solution/Factory/Views/Home/Index.cshtml"
WriteAttributeValue("", 296, Url.Action("Index", "Machines"), 296, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 328, "\'", 328, 1, true);
            EndWriteAttribute();
            BeginContext(330, 31, true);
            WriteLiteral(">View current machines</button>");
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
