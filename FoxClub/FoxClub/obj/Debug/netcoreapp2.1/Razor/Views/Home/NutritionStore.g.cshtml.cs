#pragma checksum "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\NutritionStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878db05514dd24aeaa58155662d6ec916c5bd150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NutritionStore), @"mvc.1.0.view", @"/Views/Home/NutritionStore.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NutritionStore.cshtml", typeof(AspNetCore.Views_Home_NutritionStore))]
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
#line 1 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\NutritionStore.cshtml"
using FoxClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878db05514dd24aeaa58155662d6ec916c5bd150", @"/Views/Home/NutritionStore.cshtml")]
    public class Views_Home_NutritionStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fox>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(54, 83, true);
            WriteLiteral("\r\n\r\n<h2>NutritionStore</h2>\r\n<ul>\r\n    <li><a href=\"/\">Home Page</a></li>\r\n    <li>");
            EndContext();
            BeginContext(138, 79, false);
#line 9 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\NutritionStore.cshtml"
   Write(Html.ActionLink("Nutrition store", "NutritionStore", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(217, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(233, 73, false);
#line 10 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\NutritionStore.cshtml"
   Write(Html.ActionLink("Trick Center", "TrickCenter", new { name = Model.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(306, 536, true);
            WriteLiteral(@"</li>
</ul>

<form action=""/nutritionstore"" method=""post"">

    <select name=""food"">
        <option value=""pizza"">Pizza</option>
        <option value=""kebab"">Kebab</option>
        <option value=""kfc"">KFC</option>
        <option value=""enchiladas"">Enchiladas</option>
    </select>

    <select name=""drink"">
        <option value=""beer"">Beer</option>
        <option value=""water"">Water</option>
        <option value=""lemonade"">Lemonade</option>
        <option value=""tequilla"">Tequilla</option>
    </select>

");
            EndContext();
            BeginContext(902, 36, true);
            WriteLiteral("    <input type=\"hidden\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 938, "\"", 957, 1);
#line 30 "C:\Users\dangm\Desktop\greenfox\emdang1\week-07\day-05\FoxClub\FoxClub\Views\Home\NutritionStore.cshtml"
WriteAttributeValue("", 946, Model.Name, 946, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(958, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(1009, 62, true);
            WriteLiteral("\r\n\r\n\r\n    <button type=\"submit\">Change</button>\r\n\r\n</form>\r\n\r\n");
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