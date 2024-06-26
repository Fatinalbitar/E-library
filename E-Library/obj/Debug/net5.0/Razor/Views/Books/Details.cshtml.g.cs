#pragma checksum "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5767c69535fec7f86fda175a1d26b6decb177af3c27118fb66219a47cd8564d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\_ViewImports.cshtml"
using E_Library

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\_ViewImports.cshtml"
using E_Library.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5767c69535fec7f86fda175a1d26b6decb177af3c27118fb66219a47cd8564d9", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"049dc42ca4faa9ea1e4b373568069b4691577fed6045ef985987193eefd43b59", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Library.Models.Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var lookupItems = new Dictionary<int, string>
    {
        { 1, "Horror" },
        { 2, "Romance" },
        { 3, "History" },
        { 4, "Short Story" }
    };

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"wraper\">\r\n\r\n    <div class=\"card\">\r\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 334, "\"", 356, 1);
            WriteAttributeValue("", 340, 
#nullable restore
#line 17 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
                                        Model.ImagePath

#line default
#line hidden
#nullable disable
            , 340, 16, false);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" width=\"500\" height=\"500\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
            Write(
#nullable restore
#line 19 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
                                    Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" by ");
            Write(
#nullable restore
#line 19 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
                                                   Model.Author

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h5>\r\n            <h6 class=\"card-subtitle mb-2 text-muted\">");
            Write(
#nullable restore
#line 20 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
                                                       lookupItems[Model.Category]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h6>\r\n            <p class=\"card-text\">");
            Write(
#nullable restore
#line 21 "C:\Users\PC\Desktop\New folder (2)\E-Library\E-Library\Views\Books\Details.cshtml"
                                  Model.Shortcut

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5767c69535fec7f86fda175a1d26b6decb177af3c27118fb66219a47cd8564d95951", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Library.Models.Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
