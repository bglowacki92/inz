#pragma checksum "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee54cc26db738e0e3ee5317910c8623147a69de"
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
using Blog.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee54cc26db738e0e3ee5317910c8623147a69de", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dd3060fcc070c1fef2b57326d647d791aa3ac34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
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
            BeginContext(226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(420, 61, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"post no-shadow\">\r\n");
            EndContext();
#line 24 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {
            var image_path = $"{base_path}/Image/{Model.Image}";

#line default
#line hidden
            BeginContext(608, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 624, "\"", 641, 1);
#line 27 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 630, image_path, 630, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 36, true);
            WriteLiteral("/>\r\n            <span class=\"title\">");
            EndContext();
            BeginContext(679, 11, false);
#line 28 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(690, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 29 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(710, 49, true);
            WriteLiteral("    </div>\r\n    <div class=\"post-body\">\r\n        ");
            EndContext();
            BeginContext(760, 20, false);
#line 32 "C:\Users\ajmba\Projekt\Blog\Blog\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(780, 22, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
