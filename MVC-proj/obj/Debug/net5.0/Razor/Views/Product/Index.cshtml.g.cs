#pragma checksum "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d13e4df76350787c50e4b952811f2d59518a77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\_ViewImports.cshtml"
using MVC_proj.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\_ViewImports.cshtml"
using MVC_proj.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d13e4df76350787c50e4b952811f2d59518a77", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0f8a47fe77c200136584079995965011cd7dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_proj.ViewModels.ProductIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""product-list-title"">
        <div class=""container py-4"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <h1>Product List</h1>
                    <i class=""text-muted"">Where flowers are our inspiration</i>
                </div>
            </div>
        </div>
    </section>
    <section id=""product-list"">
        <input id=""skipCount"" type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 528, "\"", 554, 1);
#nullable restore
#line 18 "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\Product\Index.cshtml"
WriteAttributeValue("", 536, ViewBag.skipCount, 536, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"container\">\r\n            <div class=\"row\" id=\"products-cont\">\r\n                ");
#nullable restore
#line 21 "C:\Users\HP\Desktop\MVC-proj\MVC-proj\Views\Product\Index.cshtml"
           Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n            <div class=\"justify-content-center d-flex\">\r\n                <button id=\"loadmorebtn\" class=\"btn btn-primary\">Load More</button>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_proj.ViewModels.ProductIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
