#pragma checksum "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1eec2f1d098490b3bb05719e41bec20bf41d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
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
#line 1 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\_ViewImports.cshtml"
using Login_Registration_Page;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\_ViewImports.cshtml"
using Login_Registration_Page.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\_ViewImports.cshtml"
using PPEsOrderingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\_ViewImports.cshtml"
using PPEsOrderingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1eec2f1d098490b3bb05719e41bec20bf41d52", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34d3b69b819bd29f3d946f45d4276f768f9c284", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PPEsOrderingSystem.Models.StoreViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #c0a1ef;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c1eec2f1d098490b3bb05719e41bec20bf41d525189", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4 text-white\">Welcome to our Store</h1>\r\n\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
             foreach (var item in Model.ProductList.OrderBy(p => p.Price).ToList())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-sm-6\" style=\"width: 27rem; padding-left: 100px; margin-top: 40px;\">\r\n                    <div class=\"card\" style=\"width: 16rem;\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c1eec2f1d098490b3bb05719e41bec20bf41d526128", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 655, "~/img/products/", 655, 15, true);
#nullable restore
#line 17 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
AddHtmlAttributeValue("", 670, item.ImagePath, 670, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-primary\">View Product</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\gabriel\Source\Repos\gerardgabrielparinas\PPEsOrderingSystem-OTIS2\PPESOrderingSystem\Views\Store\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Login_Registration_Page.Data.ApplicationDbContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PPEsOrderingSystem.Models.StoreViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
