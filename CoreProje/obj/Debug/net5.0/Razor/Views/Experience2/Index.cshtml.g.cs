#pragma checksum "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Experience2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651f58f8fa5083aa64f396c4c95ba80760d0fb54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience2_Index), @"mvc.1.0.view", @"/Views/Experience2/Index.cshtml")]
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
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Experience2\Index.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651f58f8fa5083aa64f396c4c95ba80760d0fb54", @"/Views/Experience2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Experience2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Verileri Getir</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Kaydet</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-warning"">Id ile Getir</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Sil</button>
      
    </div>
</div>

<div class=""p-2"" id=""listexperience"">
</div>
<br />

<div class=""p-2"" id=""listbyidexperience"">

</div>

<br />
<div class=""col-md-12"">
    <h5>Ekleme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Başlık"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Tarih"" />

</div>
<br />
<div class=""col-md-12"">
    <h5>Id'ye Göre Getirme Paneli</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""ID Giriniz"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Sil");
            WriteLiteral("me Paneli</h5>\r\n    <input type=\"text\" class=\"form-control\" id=\"inpexpid\" placeholder=\"ID Giriniz\" />\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(""#btngetlistall"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/ListExperience/"",

                success: function (funk) {
                    let values = jQuery.parseJSON(funk)
                    console.log(values);

                    let htmlst = ""<table class=table table-bordered>  <tr> <th> ID </th> <th>Başlık</th> <th>Tarih</th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExprerienceID}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                    htmlst += ""</table>"";
                    $(""#listexperience"").html(htmlst);
                }
            });
        });

        $(""#btnadd"").click(function () {
            let values = {
                Name: $(""#inpname"").val(),
                Dat");
                WriteLiteral(@"e: $(""#inpdate"").val()
            };

            $.ajax({
                type: ""Post"",
                url: ""/Experience2/AddExperience/"",
                data: values,
                success: function (funk1) {
                    let result = jQuery.parseJSON(funk1);
                    alert(""Başarılı bir şekilde eklendi"");
                }
            });
        });

        $(""#btnid"").click(x => {
            let id = $(""#inpid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/GetById/"",
                data: { ExprerienceID: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(result);
                    let htmlstr = `<table class=table table-hover> <tr><th>Deneyim ID</th> <td> ${result.ExprerienceID}</td></tr> <tr><th>Deneyim Başlığı</th> <td> ${result.Name}<");
                WriteLiteral(@"/td></tr></table>`;
                    $(""#listbyidexperience"").html(htmlstr);
                }
            });
        });

        $(""#btndelete"").click(x => {
            let id = $(""#inpexpid"").val();
            $.ajax({
                url: ""/Experience/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (funk3) {
                    loadData();
                }
            });

        });

        //$(""#btnupdate"").click(x => {
        //    let values = {
        //        ExperienceID: $(""#inpeditexpid"").val(),
        //        Name: $(""#inpeditexpname"").val(),
        //    };
        //    $.ajax({
        //        type: ""post"",
        //        url:""/Experience2/UpdateExperience/"",   
        //        data: values,
        //        success: function (funk4) {
        //            alert(""Güncelleme işlemi yapıldı"");
        //        }
   ");
                WriteLiteral("     //    });\r\n        //});\r\n\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<!-- bu butonun tetiklendiği isim olacak #getlistall , click olduğunda bi fonsiyon oluştur ajax la çalışacak   -->
<!--jQuery.parseJSON(funk) adığımız veerileri json a dönüştür funk tan gelen değerleri

    sonra  console.log(users) yazdırsın userstan gelen değerleri -->
<!--""<table class=table table-bordered>  <tr> <th> ID </th> <th>Başlık</th> <th>Tarih</th> </tr>"" buraya bir satır açtık ve 3 tane th başlık tanımladık -->
<!-- `` bu işareti atlgr + noktalı virgül olan tuş ile yapacan , bu işaret verileri tabloya yansıtmak için gerekli -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "651f58f8fa5083aa64f396c4c95ba80760d0fb549287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591