#pragma checksum "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74521138b9cb13f184440035c32727698cdf75c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\_ViewImports.cshtml"
using WebAppGoogleBooks;

#line default
#line hidden
#line 2 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\_ViewImports.cshtml"
using WebAppGoogleBooks.Models;

#line default
#line hidden
#line 1 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
using WebAppGoogleBooks.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74521138b9cb13f184440035c32727698cdf75c", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2ac2cd90b07973bdb914270f4ad27a9f882e00", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(112, 26, true);
            WriteLiteral("\r\n<h2>Books</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 12 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
     foreach (var book in Model.Books)
    {

#line default
#line hidden
            BeginContext(185, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 199, "\"", 250, 1);
#line 14 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
WriteAttributeValue("", 206, Url.Action("Details", new { id = book.Id }), 206, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(251, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(253, 10, false);
#line 14 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
                                                              Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(263, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 15 "C:\Users\MarkoPoikkimaki\source\repos\WebAppGoogleBooks\WebAppGoogleBooks\Views\Book\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(281, 7, true);
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
