#pragma checksum "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4643ebfd967e7d8f889a03a8116a534950ad7f08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TheWall), @"mvc.1.0.view", @"/Views/Home/TheWall.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TheWall.cshtml", typeof(AspNetCore.Views_Home_TheWall))]
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
#line 1 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/_ViewImports.cshtml"
using TheWall;

#line default
#line hidden
#line 2 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/_ViewImports.cshtml"
using TheWall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4643ebfd967e7d8f889a03a8116a534950ad7f08", @"/Views/Home/TheWall.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d202197c3bfd1895a7b2b59f7940dc9c3d32218c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TheWall : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NewMessagePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
  
  ViewData["Title"] = "The Wall";

#line default
#line hidden
            BeginContext(39, 34, true);
            WriteLiteral("\n<div>\n  <p>Welcome to your wall, ");
            EndContext();
            BeginContext(74, 16, false);
#line 6 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                      Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(90, 6, true);
            WriteLiteral(" (id# ");
            EndContext();
            BeginContext(97, 14, false);
#line 6 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                                             Write(ViewBag.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(111, 38, true);
            WriteLiteral(")</p>\n  <!-- Post a new message -->\n  ");
            EndContext();
            BeginContext(149, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4643ebfd967e7d8f889a03a8116a534950ad7f084876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 23, true);
            WriteLiteral("\n  <div id=\"the-wall\">\n");
            EndContext();
#line 10 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
     foreach(var m in ViewBag.Messages)
    {

#line default
#line hidden
            BeginContext(252, 36, true);
            WriteLiteral("      <div>\n        <p>\n            ");
            EndContext();
            BeginContext(289, 18, false);
#line 14 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
       Write(m.Author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(307, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(309, 17, false);
#line 14 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                           Write(m.Author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(326, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(330, 36, false);
#line 14 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                                                Write(m.CreatedAt.ToString("MMMM dd yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(366, 60, true);
            WriteLiteral("\n        </p>\n        <p style=\"padding:0 10px;\">\n          ");
            EndContext();
            BeginContext(427, 13, false);
#line 17 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
     Write(m.MessageText);

#line default
#line hidden
            EndContext();
            BeginContext(440, 152, true);
            WriteLiteral("\n        </p>\n        <div>\n          <!-- <partial name=\"NewCommentPartial\"> -->\n            <div style=\"width:80%;margin:0 auto;\">\n              <ul>\n");
            EndContext();
#line 23 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                 foreach(var c in @ViewBag.Comments)
                {
                  if(@c.MessageId == @m.MessageId)
                  {

#line default
#line hidden
            BeginContext(734, 71, true);
            WriteLiteral("                    <div>\n                      \n                      ");
            EndContext();
            BeginContext(806, 13, false);
#line 29 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                 Write(c.CommentText);

#line default
#line hidden
            EndContext();
            BeginContext(819, 28, true);
            WriteLiteral("\n                    </div>\n");
            EndContext();
#line 31 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
                  }
                }

#line default
#line hidden
            BeginContext(885, 34, true);
            WriteLiteral("              </ul>\n              ");
            EndContext();
            BeginContext(919, 355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4643ebfd967e7d8f889a03a8116a534950ad7f089035", async() => {
                BeginContext(981, 286, true);
                WriteLiteral(@"
                <label for=""commentText"">Add a comment:</label>
                <textarea name=""commentText"" style=""width:100%;"" required></textarea>
                <input type=""submit"" value=""Comment"" style=""float:right;background-color:rgb(90, 90, 245);color:white;"">
              ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 933, "messages/", 933, 9, true);
#line 34 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
AddHtmlAttributeValue("", 942, m.MessageId, 942, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 954, "/NewComment", 954, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1274, 48, true);
            WriteLiteral("\n            </div>\n        </div>\n      </div>\n");
            EndContext();
#line 42 "/Users/rtongson/Documents/csharp/entity/TheWall/Views/Home/TheWall.cshtml"
    }

#line default
#line hidden
            BeginContext(1328, 15, true);
            WriteLiteral("  </div>\n</div>");
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
