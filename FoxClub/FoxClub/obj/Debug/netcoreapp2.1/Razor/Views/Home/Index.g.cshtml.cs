#pragma checksum "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa3bdbe32841743a7b2cb95ebf37c2298ac5d4d"
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
#line 1 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
using FoxClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa3bdbe32841743a7b2cb95ebf37c2298ac5d4d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fox>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Images/greenfox.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Green Fox Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 71, true);
            WriteLiteral("\r\n<h2>Index / Info</h2>\r\n<ul>\r\n    <li><a href=\"/\">Home Page</a></li>\r\n");
            EndContext();
            BeginContext(258, 10, true);
            WriteLiteral("\r\n    <li>");
            EndContext();
            BeginContext(269, 62, false);
#line 10 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Profile", "Index", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(331, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(347, 79, false);
#line 11 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Nutrition store", "NutritionStore", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(426, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(442, 73, false);
#line 12 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Trick Center", "TrickCenter", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(515, 18, true);
            WriteLiteral("</li>\r\n\r\n</ul>\r\n\r\n");
            EndContext();
            BeginContext(533, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "06a543e2a63c4456b7d14aaf61afc8dc", async() => {
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
            EndContext();
            BeginContext(597, 13, true);
            WriteLiteral("\r\n<p>This is ");
            EndContext();
            BeginContext(611, 10, false);
#line 17 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(621, 23, true);
            WriteLiteral(" currently living on a ");
            EndContext();
            BeginContext(645, 10, false);
#line 17 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
                                        Write(Model.Food);

#line default
#line hidden
            EndContext();
            BeginContext(655, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(661, 11, false);
#line 17 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
                                                        Write(Model.Drink);

#line default
#line hidden
            EndContext();
            BeginContext(672, 11, true);
            WriteLiteral(". He knows ");
            EndContext();
            BeginContext(684, 24, false);
#line 17 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
                                                                               Write(Model.ListOfTricks.Count);

#line default
#line hidden
            EndContext();
            BeginContext(708, 39, true);
            WriteLiteral(" tricks.</p>\r\n\r\n<h2>Known tricks</h2>\r\n");
            EndContext();
#line 20 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
 if (Model.ListOfTricks.Count == 0)
{

#line default
#line hidden
            BeginContext(787, 61, true);
            WriteLiteral("    <p>You dont know any tricks yet. Go and learn some.</p>\r\n");
            EndContext();
#line 23 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(860, 10, true);
            WriteLiteral("    <ul>\r\n");
            EndContext();
#line 27 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
         foreach (var trick in Model.ListOfTricks)
        {

#line default
#line hidden
            BeginContext(933, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(950, 5, false);
#line 29 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
           Write(trick);

#line default
#line hidden
            EndContext();
            BeginContext(955, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 30 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(973, 11, true);
            WriteLiteral("    </ul>\r\n");
            EndContext();
#line 32 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(987, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fox> Html { get; private set; }
    }
}
#pragma warning restore 1591
