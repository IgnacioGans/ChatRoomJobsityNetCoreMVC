#pragma checksum "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4949e4ac4fd05317f111fc99b40e423cf892a9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\_ViewImports.cshtml"
using ChatRoomJobsityMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\_ViewImports.cshtml"
using ChatRoomJobsityMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4949e4ac4fd05317f111fc99b40e423cf892a9f3", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2400b00ab2cb6167abdee7623d19e94aa1cd428a", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatRoomJobsityMVC.Models.UsersModel.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/signin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4949e4ac4fd05317f111fc99b40e423cf892a9f35015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""form-signin"">
    <ul class=""nav nav-tabs nav-fill"" id=""JsAndCsharpLogin"" role=""tablist"">
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link active"" id=""csharp-login-tab"" data-toggle=""tab"" href=""#csharp"" role=""tab"" aria-controls=""csharp-login"" aria-selected=""true"">Csharp Login</a>
        </li>
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link"" id=""javascritp-login-tab"" data-toggle=""tab"" href=""#javascript"" role=""tab"" aria-controls=""javascritp-login"" aria-selected=""false"">Javascript Login (Ajax)</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""JsAndCsharpLoginContent"">
        <div class=""tab-pane fade show active"" id=""csharp"" role=""tabpanel"" aria-labelledby=""csharp-tab"">
");
#nullable restore
#line 17 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml"
             using (Html.BeginForm("LoginT", "Login", FormMethod.Post, new { enctype = "multipart/form-data", @class = "" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <img class=""mt-4 mb-4 mx-auto d-block"" src=""https://www.jobsity.com/themes/custom/jobsity/images/logo/brand-jobsity.svg"" alt=""jobsity Logo"">
                <h1 class=""h3 mb-3 font-weight-normal"">Please sign in</h1>
                <label for=""inputEmail"" class=""sr-only"">User Name</label>
");
#nullable restore
#line 22 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml"
           Write(Html.TextBoxFor(m => m.username, new { @type = "text", @class = "form-control", placeholder = "user", required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n");
#nullable restore
#line 24 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml"
           Write(Html.TextBoxFor(m => m.password, new { @type = "password", @class = "form-control", placeholder = "password", required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-lg btn-primary btn-block\" type=\"submit\">Sign in</button>\r\n                <p class=\"mt-5 mb-3 text-muted\">© 2017-2021</p>\r\n");
#nullable restore
#line 28 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"tab-pane fade\" id=\"javascript\" role=\"tabpanel\" aria-labelledby=\"javascript-login-tab\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4949e4ac4fd05317f111fc99b40e423cf892a9f39196", async() => {
                WriteLiteral(@"
                <img class=""mt-4 mb-4 mx-auto d-block"" src=""https://www.jobsity.com/themes/custom/jobsity/images/logo/brand-jobsity.svg"" alt=""jobsity Logo"">
                <h1 class=""h3 mb-3 font-weight-normal"">Please sign in</h1>
                <label for=""inputEmail"" class=""sr-only"">User</label>
                <input type=""text"" id=""user2"" class=""form-control"" placeholder=""Username""");
                BeginWriteAttribute("required", " required=\"", 2468, "\"", 2479, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 2480, "\"", 2492, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <label for=\"inputPassword\" class=\"sr-only\">Password</label>\r\n                <input type=\"password\" id=\"pass2\" class=\"form-control\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 2666, "\"", 2677, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <button id=\"sendForm\" class=\"btn btn-lg btn-primary btn-block\" type=\"button\">Sign in</button>\r\n                <p class=\"mt-5 mb-3 text-muted\">© 2017-2021</p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4949e4ac4fd05317f111fc99b40e423cf892a9f311919", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script>\r\n        // Url for the request\r\n        var url = \'");
#nullable restore
#line 52 "C:\Users\gans1\Documents\remking\ChatRoomJobsityNetCoreMVC\ChatRoom_Jobsity\ChatRoomJobsityMVC\Views\Login\Index.cshtml"
              Write(Url.Action("Test1", "Login"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        let tryThisMethod = MethodTest(url);
        console.log(tryThisMethod)
        function MethodTest(url) {
            // Making our request
            fetch(url, { method: 'POST' })
                .then(Result => Result.json())
                .then(string => {

                    // Printing our response
                    console.log(string);

                    // Printing our field of our response
                    return `Test Controller Javascript Vanilla :  ${string.message}`;
                })
                .catch(errorMsg => { return ""Message Not Found""; });
            //return ""Message Not Found""
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatRoomJobsityMVC.Models.UsersModel.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
