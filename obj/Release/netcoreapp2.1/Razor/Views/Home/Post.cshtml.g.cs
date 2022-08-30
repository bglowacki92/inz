#pragma checksum "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "482956a496f71b01ed541327bd08fd045da2e52d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482956a496f71b01ed541327bd08fd045da2e52d", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c4409f12944a028982f5e8a063c1ac4d8eb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("path-url"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/static/miniaturka-bartlomiej-glowacki.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Redaktor Bartłomiej Głowacki"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(682, 164, true);
            WriteLiteral(" class=\"fotunia\" />\r\n            <div class=\"article_top\">\r\n                <span class=\"path\"><a href=\"https://zaczytani.com.pl\" class=\"path-url\">Zaczytani</a> >> ");
            EndContext();
            BeginContext(846, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ed57e01add420f8cadb818ec3dbf31", async() => {
                BeginContext(945, 25, false);
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
            BeginContext(974, 4, true);
            WriteLiteral(" >> ");
            EndContext();
            BeginContext(979, 22, false);
#line 26 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                                                                                                                                                                                                       Write(Model.Title.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1001, 68, true);
            WriteLiteral("</span>\r\n                <br /> \r\n                <H1 class=\"title\">");
            EndContext();
            BeginContext(1070, 11, false);
#line 28 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 94, true);
            WriteLiteral("</H1>\r\n                <br />\r\n                <span class=\"article_published\">Opublikowano:  ");
            EndContext();
            BeginContext(1176, 36, false);
#line 30 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                          Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 197, true);
            WriteLiteral("</span>\r\n                <p class=\"article_author\">Autor: <a href=\"https://zaczytani.com.pl/Home/Redakcja\" class=\"path-url\">Bartłomiej Głowacki</a></p>\r\n                <br />\r\n            </div>\r\n");
            EndContext();
#line 34 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
            }

#line default
#line hidden
            BeginContext(1424, 56, true);
            WriteLiteral("        </div>\r\n    <div class=\"post-body\">\r\n        <p>");
            EndContext();
            BeginContext(1481, 17, false);
#line 37 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1498, 14, true);
            WriteLiteral("</p>\r\n        ");
            EndContext();
            BeginContext(1513, 20, false);
#line 38 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 132, true);
            WriteLiteral("\r\n        <hr />\r\n        <div class=\"author\">\r\n\r\n            <div class=\"author-info\">\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(1665, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46f307c1361142f781614130b48cde30", async() => {
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
            BeginContext(1797, 577, true);
            WriteLiteral(@"
                </div>
                <div>
                    <a href=""https://zaczytani.com.pl/Home/Redakcja""><h4 class=""author-name"">Bartłomiej Głowacki</h4></a>
                    <p class=""author-opis"">
                        Uwielbiam kawę i dobre książki, a zaczytanych tworzę właśnie z pasji do nich. Uwielbiam odkrywać ciekawe hisotrię i czerpać z nich inspirację do codziennego życia.
                    </p>
                </div>
            </div>
        </div>
        <hr />
        <div class=""comment-section"">
            <h4>Komentarze o: ");
            EndContext();
            BeginContext(2375, 11, false);
#line 56 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2386, 71, true);
            WriteLiteral("</h4>\r\n            <br />\r\n            <h5>Napisz Twój komentarz</h5>\r\n");
            EndContext();
#line 59 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
              
                await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = 0 });
            

#line default
#line hidden
            BeginContext(2615, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 64 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
             foreach (var c in Model.MainComments)
            {

#line default
#line hidden
            BeginContext(2686, 130, true);
            WriteLiteral("                <hr />\r\n                <br /><br /><h5>Dołącz do dyskusji</h5>\r\n                <p>\r\n                    <strong>");
            EndContext();
            BeginContext(2817, 6, false);
#line 69 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                       Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2823, 15, true);
            WriteLiteral(" </strong>     ");
            EndContext();
            BeginContext(2839, 38, false);
#line 69 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                             Write(c.Created.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 29, true);
            WriteLiteral(" <br />\r\n                    ");
            EndContext();
            BeginContext(2907, 9, false);
#line 70 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
               Write(c.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2916, 85, true);
            WriteLiteral(" <br />\r\n                </p>\r\n                <div style=\"margin-left: 5rem;\">\r\n\r\n\r\n");
            EndContext();
#line 75 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                     foreach (var sc in c.SubComments)
                    {

#line default
#line hidden
            BeginContext(3080, 65, true);
            WriteLiteral("                        <p>\r\n                            <strong>");
            EndContext();
            BeginContext(3146, 7, false);
#line 78 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                               Write(sc.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3153, 15, true);
            WriteLiteral(" </strong>     ");
            EndContext();
            BeginContext(3169, 39, false);
#line 78 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                                      Write(sc.Created.ToString("MM/dd/yyyy hh:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3208, 37, true);
            WriteLiteral(" <br />\r\n                            ");
            EndContext();
            BeginContext(3246, 10, false);
#line 79 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                       Write(sc.Message);

#line default
#line hidden
            EndContext();
            BeginContext(3256, 39, true);
            WriteLiteral(" <br />\r\n                        </p>\r\n");
            EndContext();
#line 81 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                    }

#line default
#line hidden
            BeginContext(3318, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 82 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                      
                        await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = c.Id });
                    

#line default
#line hidden
            BeginContext(3503, 54, true);
            WriteLiteral("                    <br />\r\n\r\n                </div>\r\n");
            EndContext();
#line 88 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
            }

#line default
#line hidden
            BeginContext(3572, 95, true);
            WriteLiteral("        </div>\r\n    </div>\r\n        </div>\r\n\r\n<script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(3668, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(3709, 340, true);
            WriteLiteral(@"@type"": ""Person"",
    ""name"": ""Bartlomiej Glowacki"",
    ""url"": ""https://zaczytani.com.pl/Home/Redakcja"",
    ""image"": ""https://zaczytani.com.pl/content/static/miniaturka-bartlomiej-glowacki.jpg"",
    ""sameAs"": ""https://www.instagram.com/accounts/login/?next=/bartlomiej_glowacki"",
    ""jobTitle"": ""Redaktor"",
    ""worksFor"": {
    """);
            EndContext();
            BeginContext(4050, 78, true);
            WriteLiteral("@type\": \"Organization\",\r\n    \"name\": \"Zaczytani\"\r\n    }\r\n    }\r\n\r\n    {\r\n    \"");
            EndContext();
            BeginContext(4129, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(4170, 59, true);
            WriteLiteral("@type\": \"BreadcrumbList\",\r\n    \"itemListElement\": [{\r\n    \"");
            EndContext();
            BeginContext(4230, 126, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 1,\r\n    \"name\": \"Strona główna\",\r\n    \"item\": \"https://zaczytani.com.pl/\"\r\n    },{\r\n    \"");
            EndContext();
            BeginContext(4357, 54, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 2,\r\n    \"name\": \"");
            EndContext();
            BeginContext(4412, 11, false);
#line 119 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4423, 52, true);
            WriteLiteral("\",\r\n    \"item\": \"https://zaczytani.com.pl/Home/Post/");
            EndContext();
            BeginContext(4476, 8, false);
#line 120 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4484, 80, true);
            WriteLiteral("\"\r\n    }]\r\n    }\r\n</script>\r\n\r\n<script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(4565, 39, true);
            WriteLiteral("@context\": \"https://schema.org\",\r\n    \"");
            EndContext();
            BeginContext(4605, 52, true);
            WriteLiteral("@type\": \"Article\",\r\n    \"mainEntityOfPage\": {\r\n    \"");
            EndContext();
            BeginContext(4658, 25, true);
            WriteLiteral("@type\": \"WebPage\",\r\n    \"");
            EndContext();
            BeginContext(4684, 42, true);
            WriteLiteral("@id\": \"https://zaczytani.com.pl/Home/Post/");
            EndContext();
            BeginContext(4727, 8, false);
#line 131 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4735, 28, true);
            WriteLiteral("\"\r\n    },\r\n    \"headline\": \"");
            EndContext();
            BeginContext(4764, 11, false);
#line 133 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
            Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4775, 24, true);
            WriteLiteral("\",\r\n    \"description\": \"");
            EndContext();
            BeginContext(4800, 17, false);
#line 134 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4817, 49, true);
            WriteLiteral("\",\r\n    \"image\": \"https://zaczytani.com.pl/Image/");
            EndContext();
            BeginContext(4867, 11, false);
#line 135 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                        Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(4878, 26, true);
            WriteLiteral("\",\r\n    \"author\": {\r\n    \"");
            EndContext();
            BeginContext(4905, 141, true);
            WriteLiteral("@type\": \"Person\",\r\n    \"name\": \"Bartłomiej Głowacki\",\r\n    \"url\": \"https://zaczytani.com.pl/Home/Redakcja\"\r\n    },\r\n    \"publisher\": {\r\n    \"");
            EndContext();
            BeginContext(5047, 71, true);
            WriteLiteral("@type\": \"Organization\",\r\n    \"name\": \"Zaczytani\",\r\n    \"logo\": {\r\n    \"");
            EndContext();
            BeginContext(5119, 129, true);
            WriteLiteral("@type\": \"ImageObject\",\r\n    \"url\": \"https://zaczytani.com.pl/content/static/zaczytani.png\"\r\n    }\r\n    },\r\n    \"datePublished\": \"");
            EndContext();
            BeginContext(5249, 36, false);
#line 149 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                 Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5285, 25, true);
            WriteLiteral("\",\r\n    \"dateModified\": \"");
            EndContext();
            BeginContext(5311, 36, false);
#line 150 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                Write(Model.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(5347, 72, true);
            WriteLiteral("\"\r\n    }\r\n</script>\r\n\r\n<script type=\"application/ld+json\">\r\n    {\r\n    \"");
            EndContext();
            BeginContext(5420, 40, true);
            WriteLiteral("@context\": \"https://schema.org/\",\r\n    \"");
            EndContext();
            BeginContext(5461, 59, true);
            WriteLiteral("@type\": \"BreadcrumbList\",\r\n    \"itemListElement\": [{\r\n    \"");
            EndContext();
            BeginContext(5521, 143, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 1,\r\n    \"name\": \"Strona główna zaczytani.com.pl\",\r\n    \"item\": \"https://zaczytani.com.pl/\"\r\n    },{\r\n    \"");
            EndContext();
            BeginContext(5665, 54, true);
            WriteLiteral("@type\": \"ListItem\",\r\n    \"position\": 2,\r\n    \"name\": \"");
            EndContext();
            BeginContext(5720, 11, false);
#line 166 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5731, 52, true);
            WriteLiteral("\",\r\n    \"item\": \"https://zaczytani.com.pl/Home/Post/");
            EndContext();
            BeginContext(5784, 8, false);
#line 167 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5792, 27, true);
            WriteLiteral("\"\r\n    }]\r\n    }\r\n</script>");
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