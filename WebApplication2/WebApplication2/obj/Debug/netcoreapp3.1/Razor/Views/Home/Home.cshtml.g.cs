#pragma checksum "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0d5ced79f67fdf128281b4c71571b08fb69f69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#line 5 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b0d5ced79f67fdf128281b4c71571b08fb69f69", @"/Views/Home/Home.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!doctype html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b0d5ced79f67fdf128281b4c71571b08fb69f694206", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 391, "\"", 401, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
        <meta name=""generator"" content=""Hugo 0.79.0"">
        <title>Product example · Bootstrap v5.0</title>

        <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.0/examples/product/"">



        <!-- Bootstrap core CSS -->
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b0d5ced79f67fdf128281b4c71571b08fb69f695140", async() => {
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
                WriteLiteral(@"

        <style>
            .bd-placeholder-img {
                font-size: 1.125rem;
                text-anchor: middle;
                -webkit-user-select: none;
                -moz-user-select: none;
                user-select: none;
            }
        </style>


        <!-- Custom styles for this template -->
        <link href=""~product.css"" rel=""stylesheet"">
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b0d5ced79f67fdf128281b4c71571b08fb69f697425", async() => {
                WriteLiteral(@"

        <header class=""site-header sticky-top py-1"">
            <nav class=""container d-flex flex-column flex-md-row justify-content-between"">
                <a class=""py-2"" href=""/home"" aria-label=""Product"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""none"" stroke=""currentColor"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" class=""d-block mx-auto"" role=""img"" viewBox=""0 0 24 24""><title>Product</title><circle cx=""12"" cy=""12"" r=""10"" /><path d=""M14.31 8l5.74 9.94M9.69 8h11.48M7.38 12l5.74-9.94M9.69 16L3.95 6.06M14.31 16H2.83m13.79-4l-5.74 9.94"" /></svg>
                </a>


               
                <a class=""py-2 d-none d-md-inline-block"" href=""/category"">Category</a>



");
#nullable restore
#line 52 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                  
                    if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"py-2 d-none d-md-inline-block\" href=\"/admin\">AdminPanel</a>\r\n");
                WriteLiteral("                        <a class=\"py-2 d-none d-md-inline-block\" href=\"/logout\">");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                                                                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 58 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                    }
                    else if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"py-2 d-none d-md-inline-block\" href=\"/logout\">");
#nullable restore
#line 61 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                                                                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 62 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"py-2 d-none d-md-inline-block\" href=\"/login\">Login</a>\r\n                        <a class=\"py-2 d-none d-md-inline-block\" href=\"/regist\">Registration</a>\r\n");
#nullable restore
#line 67 "C:\Users\LENOVO\Desktop\sharp\WebApplication2\WebApplication2\Views\Home\Home.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"




            </nav>
        </header>

        <main>
            <div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light"">
                <div class=""col-md-5 p-lg-5 mx-auto my-5"">
                    <h1 class=""display-4 fw-normal"">Punny headline</h1>
                    <p class=""lead fw-normal"">And an even wittier subheading to boot. Jumpstart your marketing efforts with this example based on Apple’s marketing pages.</p>
                    <a class=""btn btn-outline-secondary"" href=""#"">Coming soon</a>
                </div>
                <div class=""product-device shadow-sm d-none d-md-block""></div>
                <div class=""product-device product-device-2 shadow-sm d-none d-md-block""></div>
            </div>

            <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
                <div class=""bg-dark me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden"">
                    <div class=""my-3 py-3"">
            ");
                WriteLiteral(@"            <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-light shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""my-3 p-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-dark shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
            </div>

            <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""");
                WriteLiteral(@"my-3 p-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-dark shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
                <div class=""bg-primary me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden"">
                    <div class=""my-3 py-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-light shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
            </div>

            <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidd");
                WriteLiteral(@"en"">
                    <div class=""my-3 p-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-white shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""my-3 py-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-white shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
            </div>

            <div class=""d-md-flex flex-md-equal w-100 my-md-3 ps-md-3"">
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5");
                WriteLiteral(@" text-center overflow-hidden"">
                    <div class=""my-3 p-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-white shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
                <div class=""bg-light me-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
                    <div class=""my-3 py-3"">
                        <h2 class=""display-5"">Another headline</h2>
                        <p class=""lead"">And an even wittier subheading.</p>
                    </div>
                    <div class=""bg-white shadow-sm mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
                </div>
            </div>
        </main>

        <footer class=""container py-5"">
        </footer>


        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b0d5ced79f67fdf128281b4c71571b08fb69f6916150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
