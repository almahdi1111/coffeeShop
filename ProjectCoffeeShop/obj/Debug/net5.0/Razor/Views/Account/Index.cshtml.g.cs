#pragma checksum "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732c97c332c00ca17fa6061ca5e4f9b15c827ce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"732c97c332c00ca17fa6061ca5e4f9b15c827ce3", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00d4153e24de47afd91c77f105c83b97c67c2a43", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectCoffeeShop.Models.customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/header.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "732c97c332c00ca17fa6061ca5e4f9b15c827ce34948", async() => {
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
            WriteLiteral(@"

<div class=""container container-table table-responsive"">
    <table id=""tableItems"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
        <thead>
        <tr>
            <th class=""th-sm"">Frist name</th>
            <th class=""th-sm"">last name</th>
            <th class=""th-sm"">Email</th>
            <th class=""th-sm"">HashPassword</th>
            <th class=""th-sm"">Actions</th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 21 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
         foreach (var item in Model) {
            var TargetId="modalN"+@item.Id;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PasswordHash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td class=\'text-center\'>\r\n\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732c97c332c00ca17fa6061ca5e4f9b15c827ce38244", async() => {
                WriteLiteral("\r\n                                <i class=\"btn btn-danger btn-table-action fa fa-trash\"");
                BeginWriteAttribute("onclick", "  onclick=\"", 1553, "\"", 1596, 4);
                WriteAttributeValue("", 1564, "return", 1564, 6, true);
                WriteAttributeValue(" ", 1570, "functionConfirm(", 1571, 17, true);
#nullable restore
#line 45 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
WriteAttributeValue("", 1587, item.Id, 1587, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1595, ")", 1595, 1, true);
                EndWriteAttribute();
                WriteLiteral("> </i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
AddHtmlAttributeValue("", 1172, item.Id, 1172, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1429, "return", 1429, 6, true);
            AddHtmlAttributeValue(" ", 1435, "functionConfirm(\'", 1436, 18, true);
#nullable restore
#line 44 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
AddHtmlAttributeValue("", 1453, item.Id, 1453, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1461, "\')", 1461, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                               \r\n                 <a class=\'btn btn-primary btn-table-action\' data-toggle=\"modal\" data-target=\"#");
#nullable restore
#line 47 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
                                                                                          Write(TargetId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> <i class=\'fas fa-info\'></i></a>\r\n\r\n            </td>\r\n        </tr>\r\n         <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=", 1853, "", 1866, 1);
#nullable restore
#line 51 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
WriteAttributeValue("", 1857, TargetId, 1857, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
                          <div class=""modal-content"">
                            <div class=""modal-header"">
                              <h4 class=""modal-title"" id=""modalScrollableTitle"">User Detail</h4>
                              
                            </div>
                            <div class=""modal-body"">

                                <div class=""row"">
                  <!-- User Card -->
               <div class=""py-4"">
                      
                      
                      <div class=""info-container"">
                        <ul class=""list-unstyled"">
                          <li class=""mb-3"">
                            <span class=""fw-bold me-2"">User Name:</span>
                            <span>");
#nullable restore
#line 69 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
                             Write(Html.DisplayFor(model => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
                                                                   Write(Html.DisplayFor(model => item.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                          </li>\r\n                         \r\n                         \r\n                          <li class=\"mb-3\">\r\n                            <span class=\"fw-bold me-2\">Email</span>\r\n                            <span>");
#nullable restore
#line 75 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
                             Write(Html.DisplayFor(model => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                          </li>
                      
                          
                     
                          
                        </ul>

                       <hr/>
                       <br>
                                  </div>
                              </div>
                            </div>
                          </div>
                              
                            <div class=""modal-footer"">
                              <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">
                                Cancel
                              </button>
                         
                            </div>
                          </div>
                        </div>
                      </div>
");
#nullable restore
#line 99 "C:\Users\almahdi\source\repos\ProjectCoffeeShop\ProjectCoffeeShop\Views\Account\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n           \r\n        \r\n\r\n        \r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectCoffeeShop.Models.customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
