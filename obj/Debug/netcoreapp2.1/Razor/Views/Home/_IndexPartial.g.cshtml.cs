#pragma checksum "C:\Users\Atif\Documents\C#\Drivers\Views\Home\_IndexPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a205ef71daea7fa5bc02610017309b58d15cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__IndexPartial), @"mvc.1.0.view", @"/Views/Home/_IndexPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_IndexPartial.cshtml", typeof(AspNetCore.Views_Home__IndexPartial))]
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
#line 1 "C:\Users\Atif\Documents\C#\Drivers\Views\_ViewImports.cshtml"
using Drivers;

#line default
#line hidden
#line 2 "C:\Users\Atif\Documents\C#\Drivers\Views\_ViewImports.cshtml"
using Drivers.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a205ef71daea7fa5bc02610017309b58d15cbb", @"/Views/Home/_IndexPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce0a34ef8da1a0c401de414204779ee5c903d7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__IndexPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Trip>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 25, true);
            WriteLiteral("<div class=\"summaries\">\r\n");
            EndContext();
#line 3 "C:\Users\Atif\Documents\C#\Drivers\Views\Home\_IndexPartial.cshtml"
     if (ViewBag.List != null){
        List<Trip> sortTrips = ViewBag.List;
        sortTrips.Sort((x,y) => y.miles.CompareTo(x.miles));
        foreach (var i in sortTrips){

#line default
#line hidden
            BeginContext(218, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(234, 9, false);
#line 7 "C:\Users\Atif\Documents\C#\Drivers\Views\Home\_IndexPartial.cshtml"
          Write(i.print());

#line default
#line hidden
            EndContext();
            BeginContext(243, 9, true);
            WriteLiteral("</p>   \r\n");
            EndContext();
#line 8 "C:\Users\Atif\Documents\C#\Drivers\Views\Home\_IndexPartial.cshtml"
        }
    }
    else{

#line default
#line hidden
            BeginContext(281, 27, true);
            WriteLiteral("        <p>No Summary</p>\r\n");
            EndContext();
#line 12 "C:\Users\Atif\Documents\C#\Drivers\Views\Home\_IndexPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(315, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Trip> Html { get; private set; }
    }
}
#pragma warning restore 1591