#pragma checksum "C:\Users\Rayman\source\repos\Shop\Shop\Views\Lights\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f968d9317a823545d95a450a431dda4a6b7d61c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lights_List), @"mvc.1.0.view", @"/Views/Lights/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lights/List.cshtml", typeof(AspNetCore.Views_Lights_List))]
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
#line 1 "C:\Users\Rayman\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Rayman\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f968d9317a823545d95a450a431dda4a6b7d61c9", @"/Views/Lights/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67d845e5371e4c720b943bf40f713afc7b23e1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Lights_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 17, false);
#line 1 "C:\Users\Rayman\source\repos\Shop\Shop\Views\Lights\List.cshtml"
Write(Model.lighCategor);

#line default
#line hidden
            EndContext();
            BeginContext(22, 36, true);
            WriteLiteral("</h1>\r\n<div class=\"row mt-3 mb-2\">\r\n");
            EndContext();
#line 3 "C:\Users\Rayman\source\repos\Shop\Shop\Views\Lights\List.cshtml"
          
            foreach (Light light in Model.allLights)
            {
                

#line default
#line hidden
            BeginContext(156, 43, false);
#line 6 "C:\Users\Rayman\source\repos\Shop\Shop\Views\Lights\List.cshtml"
           Write(await Html.PartialAsync("AllLights", light));

#line default
#line hidden
            EndContext();
#line 6 "C:\Users\Rayman\source\repos\Shop\Shop\Views\Lights\List.cshtml"
                                                            
            }
        

#line default
#line hidden
            BeginContext(227, 6, true);
            WriteLiteral("</div>");
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
