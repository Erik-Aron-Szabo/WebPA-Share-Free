#pragma checksum "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dddfbfc78aa383cbd730bc46b26eb9871bc2279"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyAccount), @"mvc.1.0.view", @"/Views/Account/MyAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/MyAccount.cshtml", typeof(AspNetCore.Views_Account_MyAccount))]
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
#line 1 "C:\CodeCool\Web\PA\Share-Free2\Views\_ViewImports.cshtml"
using Share_Free;

#line default
#line hidden
#line 2 "C:\CodeCool\Web\PA\Share-Free2\Views\_ViewImports.cshtml"
using Share_Free.Models;

#line default
#line hidden
#line 6 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 7 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
using Share_Free.Controllers;

#line default
#line hidden
#line 8 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
using Share_Free.Services;

#line default
#line hidden
#line 9 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
using Sharing_Free.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dddfbfc78aa383cbd730bc46b26eb9871bc2279", @"/Views/Account/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8e8d91de01dd75d5b40c4044bc5c4ef24baaa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
  
    ViewData["Title"] = "MyAccount";

#line default
#line hidden
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(174, 16, true);
            WriteLiteral("\r\n            \r\n");
            EndContext();
#line 12 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
  
    string username = Context.User.FindFirst("Username").Value.ToString();
 

#line default
#line hidden
            BeginContext(274, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(279, 8, false);
#line 15 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
Write(username);

#line default
#line hidden
            EndContext();
            BeginContext(287, 58, true);
            WriteLiteral("\'s Account</h1>\r\n\r\n<div>\r\n    <h2>MyPosts</h2>\r\n    <ul>\r\n");
            EndContext();
#line 20 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
          
            // Make a button, so when user clicks on it, it will take him to his post
            PostService pService = new PostService();
            List<Post> myPosts = pService.GetAllPostsFromUser(username);

            foreach (var post in myPosts)
            {

#line default
#line hidden
            BeginContext(633, 140, true);
            WriteLiteral("                <li>\r\n                    \r\n                    <p>\r\n                    <strong>Post:</strong>\r\n                    Title: ");
            EndContext();
            BeginContext(774, 10, false);
#line 31 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
                      Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(784, 7, true);
            WriteLiteral(" Date: ");
            EndContext();
            BeginContext(792, 9, false);
#line 31 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
                                        Write(post.Date);

#line default
#line hidden
            EndContext();
            BeginContext(801, 52, true);
            WriteLiteral(" \r\n                    </p>\r\n                </li>\r\n");
            EndContext();
#line 34 "C:\CodeCool\Web\PA\Share-Free2\Views\Account\MyAccount.cshtml"
            }
        

#line default
#line hidden
            BeginContext(879, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
