#pragma checksum "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Onas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "687e7760823bbbc7c53fe3cd909d3a2e5a21b7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Onas), @"mvc.1.0.view", @"/Views/Home/Onas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Onas.cshtml", typeof(AspNetCore.Views_Home_Onas))]
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
#line 1 "C:\Users\ajmba\Projekt\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#line 2 "C:\Users\ajmba\Projekt\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models.Comments;

#line default
#line hidden
#line 3 "C:\Users\ajmba\Projekt\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"687e7760823bbbc7c53fe3cd909d3a2e5a21b7ff", @"/Views/Home/Onas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c4409f12944a028982f5e8a063c1ac4d8eb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Onas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Onas.cshtml"
   
    ViewBag.Title = "O redakcji zaczytanych";
    ViewBag.Description = "Poznaj redakcję zaczytanych. Dowiedz się więcej kim są zaczytani.";
    ViewBag.Keywords = "Blog książki polecane kryminały biografie";

#line default
#line hidden
            BeginContext(220, 179, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"special-body\">\r\n        <span class=\"path\"><a href=\"https://zaczytani.com.pl\" class=\"path-url\">Zaczytani</a> >> O nas</span>\r\n        <h1>");
            EndContext();
            BeginContext(400, 13, false);
#line 9 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Onas.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(413, 1367, true);
            WriteLiteral(@"</h1>
        <p>
            Cześć,
            <br /> <br />
            przed Tobą zaCzytani. To projekt o ludziach czytających, ale też o tym co czytali, czytają i będą czytać.
            <br />
            Zaczytani to recenzje książek, która są skupione na tym co w nich lubimy. Chcę pokazać dlaczego ludzie sięgają po książki i co w nich odnajdują. Począwszy od ulubionych bohaterów, historii, tego co wnoszą w życie i jakie wzbudzają emocje. Wspólnie stworzymy regał pełen dobrych książek.
            Może statystyki nie są sprzyjające, ale każdy czytający ma swój wirtualny świat, taką książkową rzeczywistość. Dlaczego więc nie dzielić się tym z innymi? Niech będzie nas więcej. Właśnie po to są zaczytani.
            <br />W zaczytanych cenimy zarówno weteranów literatury, jak i tych którzy swoją przygodę z książkami dopiero zaczynają. Przypomnijmy sobie ulubione książki z młodych lat, sprawdźmy co obecnie jest na topie i wspólnie rozwińmy swoje horyzonty.
            <br /><br />Dobrej książki!");
            WriteLiteral(@"
            <br /><br />
            Strona stanowi element projektu zaliczeniowego pracę inżynierską.
            <br /><br />
            Jeśli chcesz skontaktować się z nami, <a href=""https://zaczytani.com.pl/Home/Kontakt"">odwiedź tę stronę</a>.
        </p>
    </div>

</div>


<script type=""application/ld+json"">
    {
    """);
            EndContext();
            BeginContext(1781, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(1822, 59, true);
            WriteLiteral("@type\": \"BreadcrumbList\",\r\n    \"itemListElement\": [{\r\n    \"");
            EndContext();
            BeginContext(1882, 126, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 1,\r\n    \"name\": \"Strona główna\",\r\n    \"item\": \"https://zaczytani.com.pl/\"\r\n    },{\r\n    \"");
            EndContext();
            BeginContext(2009, 154, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 2,\r\n    \"name\": \"O redakcji zaczytanych\",\r\n    \"item\": \"https://zaczytani.com.pl/Home/Onas\"\r\n    }]\r\n    }\r\n</script>");
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
