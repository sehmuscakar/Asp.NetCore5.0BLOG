#pragma checksum "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a521f4247010b25b5ebedaa3e18e466627f9e98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a521f4247010b25b5ebedaa3e18e466627f9e98", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Yeteneklerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Başarılı bildiğim programlama dilleri ve teknolojiler üzerine bir liste bulunmaktadır </p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 14 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach(var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"py-1\">\n                        <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 16 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 16 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                          Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\n                        <div class=\"progress my-1\">\n                            <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 996, "\"", 1023, 3);
            WriteAttributeValue("", 1004, "width:", 1004, 6, true);
#nullable restore
#line 18 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1010, item.Value, 1011, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1022, "%", 1022, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1024, "\"", 1051, 1);
#nullable restore
#line 18 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1040, item.Value, 1040, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 21 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
