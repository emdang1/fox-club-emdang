#pragma checksum "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\TrickCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4799902d49a3f49f41e0c02dde31f9789c5f7a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TrickCenter), @"mvc.1.0.view", @"/Views/Home/TrickCenter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TrickCenter.cshtml", typeof(AspNetCore.Views_Home_TrickCenter))]
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
#line 1 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\TrickCenter.cshtml"
using FoxClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4799902d49a3f49f41e0c02dde31f9789c5f7a6", @"/Views/Home/TrickCenter.cshtml")]
    public class Views_Home_TrickCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fox>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(54, 80, true);
            WriteLiteral("\r\n\r\n<h2>TrickCenter</h2>\r\n<ul>\r\n    <li><a href=\"/\">Home Page</a></li>\r\n    <li>");
            EndContext();
            BeginContext(135, 79, false);
#line 9 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\TrickCenter.cshtml"
   Write(Html.ActionLink("Nutrition store", "NutritionStore", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(214, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(230, 73, false);
#line 10 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\TrickCenter.cshtml"
   Write(Html.ActionLink("Trick Center", "TrickCenter", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(303, 332, true);
            WriteLiteral(@"</li>
</ul>

<form action=""/trickcenter"" method=""post"">

    <select name=""trick"">
        <option value=""HTML"">HTML</option>
        <option value=""JavaScript"">JavaScript</option>
        <option value=""C#"">C#</option>
        <option value=""ASP.NET"">ASP.NET</option>
    </select>

    <input type=""hidden"" name=""name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 635, "\"", 654, 1);
#line 22 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\TrickCenter.cshtml"
WriteAttributeValue("", 643, Model.Name, 643, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(655, 58, true);
            WriteLiteral(" />\r\n    <button type=\"submit\">Learn</button>\r\n\r\n\r\n</form>");
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