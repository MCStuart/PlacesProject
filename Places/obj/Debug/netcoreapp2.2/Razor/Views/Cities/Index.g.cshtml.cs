#pragma checksum "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906197d669f065d7663af2801794be5ca2ba9597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_Index), @"mvc.1.0.view", @"/Views/Cities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cities/Index.cshtml", typeof(AspNetCore.Views_Cities_Index))]
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
#line 1 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
using Places.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906197d669f065d7663af2801794be5ca2ba9597", @"/Views/Cities/Index.cshtml")]
    public class Views_Cities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 28, true);
            WriteLiteral("\n<h1>Cities List</h1>\n\n<ul>\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
   if (Model.Count == 0)
  {

#line default
#line hidden
            BeginContext(79, 50, true);
            WriteLiteral("    <p>You have no cities in your to do list!</p>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(133, 2, true);
            WriteLiteral("  ");
            EndContext();
#line 10 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
   if(Model.Count != 0)
  {
    

#line default
#line hidden
#line 12 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
     foreach (City city in Model)
    {

#line default
#line hidden
            BeginContext(201, 12, true);
            WriteLiteral("      <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 213, "\'", 241, 2);
            WriteAttributeValue("", 220, "/cities/", 220, 8, true);
#line 14 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
WriteAttributeValue("", 228, city.GetId(), 228, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(244, 21, false);
#line 14 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
                                     Write(city.GetDescription());

#line default
#line hidden
            EndContext();
            BeginContext(265, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
    }

#line default
#line hidden
#line 15 "/Users/Guest/Desktop/Places.Solution/Places/Views/Cities/Index.cshtml"
     
  }

#line default
#line hidden
            BeginContext(285, 167, true);
            WriteLiteral("</ul>\n\n<a href=\"/cities/new\">Add a new city.</a>\n\n<form action=\"/cities/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear all cities</button>\n</form>\n");
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