#pragma checksum "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636158ac207be206397c1f94874d71d362f5d81c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Web_Views_Post_Index), @"mvc.1.0.view", @"/Web/Views/Post/Index.cshtml")]
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
#line 1 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Blog.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Blog.DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Blog.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Blog.Core.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636158ac207be206397c1f94874d71d362f5d81c", @"/Web/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb199939c74c9f2f2f3448c3b6fc7ed0df440c9d", @"/Web/Views/_ViewImports.cshtml")]
    public class Web_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Posts";
    var pageNavigation = (PageNavigationViewModel)ViewBag.PageNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 8 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
          Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 12 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
          Write(post.CreatedAt.ToString("dd:MM:yy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n");
#nullable restore
#line 14 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\rufar\source\repos\Blog\Blog\Web\Views\Post\Index.cshtml"
Write(await Component.InvokeAsync("PageNavigation", pageNavigation));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserService UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
