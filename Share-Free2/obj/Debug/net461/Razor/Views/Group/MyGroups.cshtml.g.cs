#pragma checksum "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74bc9d17550f0dbda176ca3d8e3303e496223e8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_MyGroups), @"mvc.1.0.view", @"/Views/Group/MyGroups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Group/MyGroups.cshtml", typeof(AspNetCore.Views_Group_MyGroups))]
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
#line 5 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
using Sharing_Free.Services;

#line default
#line hidden
#line 6 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
using Share_Free.Domain;

#line default
#line hidden
#line 7 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 8 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
using Share_Free.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74bc9d17550f0dbda176ca3d8e3303e496223e8c", @"/Views/Group/MyGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8e8d91de01dd75d5b40c4044bc5c4ef24baaa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_MyGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Group.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
  
    ViewData["Title"] = "MyGroups";

#line default
#line hidden
            BeginContext(171, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e904256f197450a88fce07115223d29", async() => {
                BeginContext(177, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(183, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6cf6a316c444bf9881fa74da6da6ab6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(226, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
  GroupService gService = new GroupService(); 

#line default
#line hidden
            BeginContext(286, 40, true);
            WriteLiteral("<div>\r\n    <h2>MyGroups</h2>\r\n    <ul>\r\n");
            EndContext();
#line 16 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
          
            // I don't know how to list all the groups, where the user is in

            int userId = Convert.ToInt32(Context.User.FindFirst("Id").Value.ToString());
            List<UserGroup> myGroups = gService.UserGroups(userId); 
            // HIBA - 0 count

            foreach (var group in myGroups)
            {

#line default
#line hidden
            BeginContext(671, 57, true);
            WriteLiteral("                <li>\r\n                    <p>Group Name: ");
            EndContext();
            BeginContext(729, 15, false);
#line 26 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
                              Write(group.GroupName);

#line default
#line hidden
            EndContext();
            BeginContext(744, 29, true);
            WriteLiteral("</p>\r\n                </li>\r\n");
            EndContext();
#line 28 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
            }
        

#line default
#line hidden
            BeginContext(799, 73, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div>\r\n    <h2>Available Groups</h2>\r\n\r\n    <ul>\r\n\r\n");
            EndContext();
#line 38 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
          
            List<Group> availableGroups = gService.GetAllGroups();
            int userId2 = Convert.ToInt32(Context.User.FindFirst("Id").Value.ToString());
            foreach (var group in availableGroups)
            {

#line default
#line hidden
            BeginContext(1110, 57, true);
            WriteLiteral("                <li>\r\n                    <p>Group Name: ");
            EndContext();
            BeginContext(1168, 10, false);
#line 44 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
                              Write(group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1178, 74, true);
            WriteLiteral("</p>\r\n                    <input id=\"groupId\" type=\"number\" name=\"groupId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1252, "\"", 1269, 1);
#line 45 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
WriteAttributeValue("", 1260, group.Id, 1260, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1270, 11, true);
            WriteLiteral(" hidden /> ");
            EndContext();
            BeginContext(1313, 68, true);
            WriteLiteral("\r\n                    <input id=\"userId\" type=\"number\" name=\"userId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1381, "\"", 1397, 1);
#line 46 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
WriteAttributeValue("", 1389, userId2, 1389, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1398, 106, true);
            WriteLiteral(" hidden />\r\n                    <button onclick=\"joinGroup()\">Join Group</button>\r\n                </li>\r\n");
            EndContext();
#line 49 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
        }

        

#line default
#line hidden
            BeginContext(1528, 21, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n");
            EndContext();
#line 55 "C:\CodeCool\Web\PA\Share-Free2\Views\Group\MyGroups.cshtml"
   /* Join group = button, onclick -> XHR(POST) -> insert username
     * into group table (POSTGRES)
     * refresh my groups, or the page, and it will show user joined
     * in the choosen group
     --------------------------------------------------------
     Same with Leave group,
     button (leave) onclick -> XHR (POST) -> delete from group,
     where username = @username? Can this work in an ARRAY?
     */

#line default
#line hidden
            BeginContext(1981, 2, true);
            WriteLiteral("\r\n");
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
