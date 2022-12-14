#pragma checksum "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e7fba84b63b503ce4e8b7f37549790eda54f68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e7fba84b63b503ce4e8b7f37549790eda54f68", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c4409f12944a028982f5e8a063c1ac4d8eb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("path-url"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/static/miniaturka-bartlomiej-glowacki.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Redaktor Bart??omiej G??owacki"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("author-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.Description;
    ViewBag.Keywords = $"{Model.Tags?.Replace(",", "")} {Model.Category}";
    var base_path = Context.Request.PathBase;

#line default
#line hidden
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(443, 59, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"post no-shadow\">\r\n");
            EndContext();
#line 21 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {
            var image_path = $"{base_path}/Image/{Model.Image}";

#line default
#line hidden
            BeginContext(629, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 645, "\"", 662, 1);
#line 24 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 651, image_path, 651, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 663, "\"", 681, 1);
#line 24 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 669, Model.Title, 669, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 162, true);
            WriteLiteral("class=\"fotunia\"/>\r\n            <div class=\"article_top\">\r\n                <span class=\"path\"><a href=\"https://zaczytani.com.pl\" class=\"path-url\">Zaczytani</a> >> ");
            EndContext();
            BeginContext(844, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf7a828cfa04cdab4b442e45348b223", async() => {
                BeginContext(943, 25, false);
#line 26 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                                                                                                                                                                     Write(Model.Category.ToString());

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                                                                                                                            WriteLiteral(Model.Category);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(972, 4, true);
            WriteLiteral(" >> ");
            EndContext();
            BeginContext(977, 22, false);
#line 26 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                                                                                                                                                                                                       Write(Model.Title.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(999, 74, true);
            WriteLiteral("</span>\r\n                <br /> <br />\r\n                <H1 class=\"title\">");
            EndContext();
            BeginContext(1074, 11, false);
#line 28 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 70, true);
            WriteLiteral("</H1>\r\n                <br />\r\n                <p class=\"description\">");
            EndContext();
            BeginContext(1156, 17, false);
#line 30 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1173, 69, true);
            WriteLiteral("</p>\r\n                <span class=\"article_published\">Opublikowano:  ");
            EndContext();
            BeginContext(1243, 36, false);
#line 31 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                          Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 204, true);
            WriteLiteral("</span>\r\n                <p class=\"article_author\">Autor: <a href=\"https://zaczytani.com.pl/Home/Redakcja\" class=\"path-url\">Bart??omiej G??owacki</a></p>\r\n                <br /> <br />\r\n            </div>\r\n");
            EndContext();
#line 35 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(1494, 49, true);
            WriteLiteral("    </div>\r\n    <div class=\"post-body\">\r\n        ");
            EndContext();
            BeginContext(1544, 20, false);
#line 38 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 143, true);
            WriteLiteral("\r\n        <hr />\r\n        <div class=\"author\">\r\n           \r\n            <div class=\"author-info\">\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(1707, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff162d79d1fb4e3e8e5ff884466cbcbf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 578, true);
            WriteLiteral(@"
                </div>
                <div>
                    <a href=""https://zaczytani.com.pl/Home/Redakcja"" ><h4 class=""author-name"">Bart??omiej G??owacki</h4></a>
                    <p class=""author-opis"">
                        Uwielbiam kaw?? i dobre ksi????ki, a zaczytanych tworz?? w??a??nie z pasji do nich. Uwielbiam odkrywa?? ciekawe hisotri?? i czerpa?? z nich inspiracj?? do codziennego ??ycia.
                    </p>
                </div>
            </div>
        </div>
        <hr />
        <div class=""comment-section"">
            <h4>Komentarze o: ");
            EndContext();
            BeginContext(2418, 11, false);
#line 56 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2429, 71, true);
            WriteLiteral("</h4>\r\n            <br />\r\n            <h5>Napisz Tw??j komentarz</h5>\r\n");
            EndContext();
#line 59 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
              
                await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = 0 });
            

#line default
#line hidden
            BeginContext(2658, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 64 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
             foreach (var c in Model.MainComments)
            {

#line default
#line hidden
            BeginContext(2729, 130, true);
            WriteLiteral("                <hr />\r\n                <br /><br /><h5>Do????cz do dyskusji</h5>\r\n                <p>\r\n                    <strong>");
            EndContext();
            BeginContext(2860, 6, false);
#line 69 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                       Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2866, 15, true);
            WriteLiteral(" </strong>     ");
            EndContext();
            BeginContext(2882, 38, false);
#line 69 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                             Write(c.Created.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2920, 29, true);
            WriteLiteral(" <br />\r\n                    ");
            EndContext();
            BeginContext(2950, 9, false);
#line 70 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
               Write(c.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2959, 85, true);
            WriteLiteral(" <br />\r\n                </p>\r\n                <div style=\"margin-left: 5rem;\">\r\n\r\n\r\n");
            EndContext();
#line 75 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                     foreach (var sc in c.SubComments)
                    {

#line default
#line hidden
            BeginContext(3123, 65, true);
            WriteLiteral("                        <p>\r\n                            <strong>");
            EndContext();
            BeginContext(3189, 7, false);
#line 78 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                               Write(sc.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3196, 15, true);
            WriteLiteral(" </strong>     ");
            EndContext();
            BeginContext(3212, 39, false);
#line 78 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                      Write(sc.Created.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3251, 37, true);
            WriteLiteral(" <br />\r\n                            ");
            EndContext();
            BeginContext(3289, 10, false);
#line 79 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                       Write(sc.Message);

#line default
#line hidden
            EndContext();
            BeginContext(3299, 39, true);
            WriteLiteral(" <br />\r\n                        </p>\r\n");
            EndContext();
#line 81 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                    }

#line default
#line hidden
            BeginContext(3361, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 82 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                      
                        await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = c.Id });
                    

#line default
#line hidden
            BeginContext(3546, 54, true);
            WriteLiteral("                    <br />\r\n\r\n                </div>\r\n");
            EndContext();
#line 88 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
            }

#line default
#line hidden
            BeginContext(3615, 87, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(3703, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(3744, 340, true);
            WriteLiteral(@"@type"": ""Person"",
    ""name"": ""Bartlomiej Glowacki"",
    ""url"": ""https://zaczytani.com.pl/Home/Redakcja"",
    ""image"": ""https://zaczytani.com.pl/content/static/miniaturka-bartlomiej-glowacki.jpg"",
    ""sameAs"": ""https://www.instagram.com/accounts/login/?next=/bartlomiej_glowacki"",
    ""jobTitle"": ""Redaktor"",
    ""worksFor"": {
    """);
            EndContext();
            BeginContext(4085, 78, true);
            WriteLiteral("@type\": \"Organization\",\r\n    \"name\": \"Zaczytani\"\r\n    }\r\n    }\r\n\r\n    {\r\n    \"");
            EndContext();
            BeginContext(4164, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(4205, 59, true);
            WriteLiteral("@type\": \"BreadcrumbList\",\r\n    \"itemListElement\": [{\r\n    \"");
            EndContext();
            BeginContext(4265, 126, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 1,\r\n    \"name\": \"Strona g????wna\",\r\n    \"item\": \"https://zaczytani.com.pl/\"\r\n    },{\r\n    \"");
            EndContext();
            BeginContext(4392, 54, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 2,\r\n    \"name\": \"");
            EndContext();
            BeginContext(4447, 11, false);
#line 119 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4458, 52, true);
            WriteLiteral("\",\r\n    \"item\": \"https://zaczytani.com.pl/Home/Post/");
            EndContext();
            BeginContext(4511, 8, false);
#line 120 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4519, 80, true);
            WriteLiteral("\"\r\n    }]\r\n    }\r\n</script>\r\n\r\n<script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(4600, 39, true);
            WriteLiteral("@context\": \"https://schema.org\",\r\n    \"");
            EndContext();
            BeginContext(4640, 52, true);
            WriteLiteral("@type\": \"Article\",\r\n    \"mainEntityOfPage\": {\r\n    \"");
            EndContext();
            BeginContext(4693, 25, true);
            WriteLiteral("@type\": \"WebPage\",\r\n    \"");
            EndContext();
            BeginContext(4719, 42, true);
            WriteLiteral("@id\": \"https://zaczytani.com.pl/Home/Post/");
            EndContext();
            BeginContext(4762, 8, false);
#line 131 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4770, 28, true);
            WriteLiteral("\"\r\n    },\r\n    \"headline\": \"");
            EndContext();
            BeginContext(4799, 11, false);
#line 133 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
            Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4810, 24, true);
            WriteLiteral("\",\r\n    \"description\": \"");
            EndContext();
            BeginContext(4835, 17, false);
#line 134 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4852, 49, true);
            WriteLiteral("\",\r\n    \"image\": \"https://zaczytani.com.pl/Image/");
            EndContext();
            BeginContext(4902, 11, false);
#line 135 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                        Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(4913, 26, true);
            WriteLiteral("\",\r\n    \"author\": {\r\n    \"");
            EndContext();
            BeginContext(4940, 141, true);
            WriteLiteral("@type\": \"Person\",\r\n    \"name\": \"Bart??omiej G??owacki\",\r\n    \"url\": \"https://zaczytani.com.pl/Home/Redakcja\"\r\n    },\r\n    \"publisher\": {\r\n    \"");
            EndContext();
            BeginContext(5082, 71, true);
            WriteLiteral("@type\": \"Organization\",\r\n    \"name\": \"Zaczytani\",\r\n    \"logo\": {\r\n    \"");
            EndContext();
            BeginContext(5154, 129, true);
            WriteLiteral("@type\": \"ImageObject\",\r\n    \"url\": \"https://zaczytani.com.pl/content/static/zaczytani.png\"\r\n    }\r\n    },\r\n    \"datePublished\": \"");
            EndContext();
            BeginContext(5284, 36, false);
#line 149 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                 Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5320, 25, true);
            WriteLiteral("\",\r\n    \"dateModified\": \"");
            EndContext();
            BeginContext(5346, 36, false);
#line 150 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5382, 19, true);
            WriteLiteral("\"\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
