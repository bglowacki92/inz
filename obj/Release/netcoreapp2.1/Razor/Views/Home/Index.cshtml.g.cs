#pragma checksum "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "502fe8642d0b4a50286f1e5d50b75c2f07757757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"502fe8642d0b4a50286f1e5d50b75c2f07757757", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c4409f12944a028982f5e8a063c1ac4d8eb12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BlogPagination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
   
    ViewBag.Title = "Zaczytani - polecane ksi????ki";
    ViewBag.Description = "Blog o polecanych ksi????kach ??? na powa??nie i ??artem, ale zawsze profesjonalnie. Odkryj Twoje nowe ulubione ksia??ki.";
    ViewBag.Keywords = "Blog ksi????ki polecane krymina??y biografie";
    var base_path = Context.Request.PathBase;

#line default
#line hidden
            BeginContext(440, 118, true);
            WriteLiteral("\r\n<div class=\"maing-img\" alt=\"ksi????ki na regale\">\r\n    <H1 class=\"title_main\">Zaczytani - polecane ksi????ki:</H1>\r\n    ");
            EndContext();
            BeginContext(558, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "734d7d2b75fe489f982a5d1206cbdb2b", async() => {
                BeginContext(618, 48, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"pageNumber\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 666, "\"", 691, 1);
#line 15 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 674, Model.PageNumber, 674, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(692, 49, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"category\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 741, "\"", 764, 1);
#line 16 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 749, Model.Category, 749, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(765, 94, true);
                WriteLiteral(" />\r\n        <input class=\"search\" type=\"text\" name=\"search\" placeholder=\"Wyszukaj na stronie\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 859, "\"", 880, 1);
#line 17 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 867, Model.Search, 867, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(881, 63, true);
                WriteLiteral(" />\r\n        <button class=\"submit-btn\">Wyszukaj</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(951, 37, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
            EndContext();
            BeginContext(1287, 71, true);
            WriteLiteral("    <h2>Najnowsze recenzje</h2>\r\n    <p>Tw??j styl ??ycia z ksi????k??</p>\r\n");
            EndContext();
#line 35 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
     foreach (var post in Model.Posts.OrderByDescending(i => i.Created)) 
    {
        var image_path = $"{base_path}/Image/{post.Image}";

#line default
#line hidden
            BeginContext(1501, 29, true);
            WriteLiteral("<div class=\"main-post\">\r\n    ");
            EndContext();
            BeginContext(1530, 548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e52a559956ad46e68be1c9bdcfd464b2", async() => {
                BeginContext(1610, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1668, 12, true);
                WriteLiteral("        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1680, "\"", 1697, 1);
#line 41 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 1686, image_path, 1686, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1698, "\"", 1715, 1);
#line 41 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 1704, post.Title, 1704, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1716, 104, true);
                WriteLiteral("/>\r\n        <div class=\"maing_page_listing\">\r\n            <H3 class=\"title_main_page\">\r\n                ");
                EndContext();
                BeginContext(1821, 10, false);
#line 44 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
           Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1831, 82, true);
                WriteLiteral("\r\n            </H3>\r\n            <p class=\"main_page_published\">\r\n                ");
                EndContext();
                BeginContext(1914, 35, false);
#line 47 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
           Write(post.Created.ToString("dd/MM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(1949, 89, true);
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <p class=\"maing_page_category\">\r\n            ");
                EndContext();
                BeginContext(2039, 13, false);
#line 51 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
       Write(post.Category);

#line default
#line hidden
                EndContext();
                BeginContext(2052, 22, true);
                WriteLiteral("\r\n        </p>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
                                                              WriteLiteral(post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2078, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 56 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2103, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(2119, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05b4287ab7f64fa882a51b1ec0840a70", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 59 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2167, 24, true);
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
