#pragma checksum "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3345804647c21e65b5e9da5acbef84daf13ca18d"
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
#line 1 "/Users/borakasmer/Projects/azureNews/Views/_ViewImports.cshtml"
using azureNews;

#line default
#line hidden
#line 2 "/Users/borakasmer/Projects/azureNews/Views/_ViewImports.cshtml"
using azureNews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3345804647c21e65b5e9da5acbef84daf13ca18d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2bb826de6e823bcea759fd58764b8743a4c95a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 164, true);
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"jumbotron\">\r\n            <h2>Technology News on borakasmer.com</h2>\r\n        </div>\r\n        <div align=\"right\"><b>");
            EndContext();
            BeginContext(189, 25, false);
#line 6 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
                         Write(Model.First().createdDate);

#line default
#line hidden
            EndContext();
            BeginContext(214, 78, true);
            WriteLiteral("</b></div>\r\n        <div>\r\n            <table class=\"table\">                \r\n");
            EndContext();
            BeginContext(312, 21, true);
            WriteLiteral("                     ");
            EndContext();
            BeginContext(335, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 11 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
                    var count=0;
                    foreach(var news in Model)
                    {                                                                         
                        if (count % 2 == 0)
                        {                           

#line default
#line hidden
            BeginContext(618, 27, true);
            WriteLiteral("                           ");
            EndContext();
            BeginContext(647, 11, true);
            WriteLiteral("</tr><tr>\r\n");
            EndContext();
#line 17 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
                        }                                                                                                                                                                                                                                

#line default
#line hidden
            BeginContext(909, 56, true);
            WriteLiteral("                        <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1010, 4);
            WriteAttributeValue("", 972, "/", 972, 1, true);
#line 19 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
WriteAttributeValue("", 973, Url.FriendlyUrl(news.title), 973, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 1001, "/", 1001, 1, true);
#line 19 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
WriteAttributeValue("", 1002, news.Id, 1002, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1011, 83, true);
            WriteLiteral(" target=\"_blank\" style=\"text-decoration: none;\">\r\n                            <h2> ");
            EndContext();
            BeginContext(1095, 10, false);
#line 20 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
                            Write(news.title);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 78, true);
            WriteLiteral("</h2>\r\n                            <div>\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1183, "\"", 1211, 2);
            WriteAttributeValue("", 1189, "/images/", 1189, 8, true);
#line 22 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
WriteAttributeValue("", 1197, news.imageUrl, 1197, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1212, 299, true);
            WriteLiteral(@" width=""500px"" height=""300px"">
                            </div>  
                        </a>                      
                        </td>                                                                                                                                                  
");
            EndContext();
#line 26 "/Users/borakasmer/Projects/azureNews/Views/Home/Index.cshtml"
                        count++;
                    }   

#line default
#line hidden
            BeginContext(1571, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1593, 28, true);
            WriteLiteral("</tr>                     \r\n");
            EndContext();
            BeginContext(1640, 48, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
