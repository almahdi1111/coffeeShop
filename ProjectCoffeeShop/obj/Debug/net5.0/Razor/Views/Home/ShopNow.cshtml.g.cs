#pragma checksum "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edeb2f3dbc9979d2dd75524db214a9e3285a70a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShopNow), @"mvc.1.0.view", @"/Views/Home/ShopNow.cshtml")]
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
#line 1 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\_ViewImports.cshtml"
using ProjectCoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\_ViewImports.cshtml"
using ProjectCoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edeb2f3dbc9979d2dd75524db214a9e3285a70a6", @"/Views/Home/ShopNow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d4153e24de47afd91c77f105c83b97c67c2a43", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShopNow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCoffeeShop.Models.CoffeeStrength>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../shared/header.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid loading"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
  
    ViewData["Title"] = "Shop Coffee";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edeb2f3dbc9979d2dd75524db214a9e3285a70a64944", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
 foreach(var Strength in Model)
{
        var color ="";
        var card_style="" ;
        var button_style="";
        var title_style = "";
        var description_style = "";
    if(Strength.Strength=="white")
    {
        color = "white";
        card_style = "text-white bg-primary";
        button_style = "btn-outline-secondary button-card-white";
        title_style = "";
        description_style ="";
    }
    else
    {
         color = "black";
          card_style = "border-primary";
         button_style = "btn-primary button-card-black";
          title_style = "text-dark";
         description_style = "text-grey";
        
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 852, "\"", 892, 3);
            WriteAttributeValue("", 860, "container-", 860, 10, true);
#nullable restore
#line 33 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
WriteAttributeValue("", 870, color, 870, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 876, "container-fluid", 877, 16, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n<h1 class=\"text-center line-under-text\">");
#nullable restore
#line 34 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
                                   Write(Strength.Strength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"cart-items-container\">\r\n   <div class=\"row m-auto\">\r\n");
#nullable restore
#line 37 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
        foreach (var item in Strength.items)
      {
        //@{var imagename=(string)item.Id+".jpg");}

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-12 col-sm-6 col-md-4 col-lg-3 card-padding\">\r\n           <div");
            BeginWriteAttribute("class", " class=\"", 1221, "\"", 1250, 3);
            WriteAttributeValue("", 1229, "card", 1229, 4, true);
            WriteAttributeValue(" ", 1233, "mb-3", 1234, 5, true);
#nullable restore
#line 41 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
WriteAttributeValue(" ", 1238, card_style, 1239, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "edeb2f3dbc9979d2dd75524db214a9e3285a70a68809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1279, "~/img/shop_coffee/", 1279, 18, true);
#nullable restore
#line 42 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
AddHtmlAttributeValue("", 1297, item.ImagePath, 1297, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
AddHtmlAttributeValue("", 1345, item.Name, 1345, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               <div class=\"card-body\"><h5");
            BeginWriteAttribute("class", " class=\"", 1400, "\"", 1443, 3);
            WriteAttributeValue("", 1408, "card-title", 1408, 10, true);
            WriteAttributeValue(" ", 1418, "text-center", 1419, 12, true);
#nullable restore
#line 43 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
WriteAttributeValue(" ", 1430, title_style, 1431, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                   <p class=\"card-price\">R ");
#nullable restore
#line 44 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
                                      Write(item.sell);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p");
            BeginWriteAttribute("class", " class=\"", 1521, "\"", 1565, 3);
            WriteAttributeValue("", 1529, "card-description", 1529, 16, true);
#nullable restore
#line 44 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
WriteAttributeValue(" ", 1545, description_style, 1546, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1564, "", 1565, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
                                                                                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edeb2f3dbc9979d2dd75524db214a9e3285a70a612950", async() => {
                WriteLiteral("\r\n                    Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1682, "btn", 1682, 3, true);
#nullable restore
#line 45 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
AddHtmlAttributeValue(" ", 1685, button_style, 1686, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n   </div>\r\n    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 56 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Home\ShopNow.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCoffeeShop.Models.CoffeeStrength>> Html { get; private set; }
    }
}
#pragma warning restore 1591