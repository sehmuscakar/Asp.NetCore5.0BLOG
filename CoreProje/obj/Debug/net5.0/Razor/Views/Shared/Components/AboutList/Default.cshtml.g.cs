#pragma checksum "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6731af8267ca4d25ff08ec5f7de230ab8af8fea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6731af8267ca4d25ff08ec5f7de230ab8af8fea2", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n        <div class=\"container-narrow\">\r\n");
#nullable restore
#line 5 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
             foreach(var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <h2 class=\"h4 my-2\">");
#nullable restore
#line 8 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 9 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row mt-3"">
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Yaş</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 15 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Mail</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 21 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Telefon</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 27 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                       
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Adres</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 34 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                       \r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-md-5 offset-md-1\" data-aos=\"fade-left\" data-aos-delay=\"100\"><img class=\"avatar img-fluid mt-2\"");
            BeginWriteAttribute("src", " src=\"", 1815, "\"", 1834, 1);
#nullable restore
#line 40 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1821, item.ImagUrl, 1821, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Walter Patterson\" /></div>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\AboutList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
