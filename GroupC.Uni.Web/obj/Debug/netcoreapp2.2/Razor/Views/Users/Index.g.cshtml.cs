#pragma checksum "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5126515f0041baed74bd3dc39609b04e39bdae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Web;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\_ViewImports.cshtml"
using GroupC.Uni.Core.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5126515f0041baed74bd3dc39609b04e39bdae", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c6523b3a210845cd006427ce69aedbc96e4d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admins/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:dimgray"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Students/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/TestCenters/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 120, true);
            WriteLiteral("<style>\r\n    #ImageDisplay {\r\n        width: 50px;\r\n    }\r\n</style>\r\n<!--actual conten-->\r\n\r\n<section class=\"content\">\r\n");
            EndContext();
            BeginContext(173, 28, true);
            WriteLiteral("        <div class=\" row\">\r\n");
            EndContext();
            BeginContext(269, 415, true);
            WriteLiteral(@"            <div class=""col-md-4"">
                <div class=""info-box"">
                    <!-- Apply any bg-* class to to the icon to color it -->
                    <span class=""info-box-icon bg-red""><i class=""fa fa-user""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Admins</span>
                        <span class=""info-box-more"">");
            EndContext();
            BeginContext(684, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5126515f0041baed74bd3dc39609b04e39bdae6500", async() => {
                BeginContext(732, 22, true);
                WriteLiteral("click to add new Admin");
                EndContext();
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
            BeginContext(758, 548, true);
            WriteLiteral(@"</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""info-box"">
                    <!-- Apply any bg-* class to to the icon to color it -->
                    <span class=""info-box-icon bg-aqua""><i class=""fa fa-book""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Students</span>
                        <span class=""info-box-more"">");
            EndContext();
            BeginContext(1306, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5126515f0041baed74bd3dc39609b04e39bdae8451", async() => {
                BeginContext(1356, 24, true);
                WriteLiteral("click to add new Student");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1384, 554, true);
            WriteLiteral(@"</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""info-box"">
                    <!-- Apply any bg-* class to to the icon to color it -->
                    <span class=""info-box-icon bg-yellow""><i class=""fa fa-bank""></i></span>
                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Test Centers</span>
                        <span class=""info-box-more"">");
            EndContext();
            BeginContext(1938, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5126515f0041baed74bd3dc39609b04e39bdae10412", async() => {
                BeginContext(1991, 28, true);
                WriteLiteral("click to add new Test Center");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2023, 175, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <!-- /.info-box-content -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /.info-box -->\r\n");
            EndContext();
            BeginContext(2230, 145, true);
            WriteLiteral("    <div class=\"box\" style=\"padding: 20px\">\r\n\r\n        <div class=\"box-header\">\r\n            <h2 class=\"box-title\">Users</h2>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(2545, 160, true);
            WriteLiteral("        <table class=\"table\" id=\"UsersTable\" style=\"margin:20px\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2706, 40, false);
#line 63 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2746, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2826, 41, false);
#line 66 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2867, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(2947, 47, false);
#line 69 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3074, 44, false);
#line 72 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(3118, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(3198, 44, false);
#line 75 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ImageURL));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 81 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3433, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3518, 39, false);
#line 85 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3649, 40, false);
#line 88 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3689, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3781, 46, false);
#line 91 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3827, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3919, 43, false);
#line 94 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserType));

#line default
#line hidden
            EndContext();
            BeginContext(3962, 128, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td align=\"center\">\r\n                            <img id=\"ImageDisplay\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4090, "\"", 4110, 1);
#line 97 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
WriteAttributeValue("", 4096, item.ImageURL, 4096, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4111, 94, true);
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4205, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5126515f0041baed74bd3dc39609b04e39bdae17506", async() => {
                BeginContext(4278, 6, true);
                WriteLiteral("Update");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4288, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4414, 109, true);
            WriteLiteral("                            <a class=\"btn btn-sm btn-danger delete\"\r\n                               data-id=\"");
            EndContext();
            BeginContext(4524, 7, false);
#line 103 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4531, 249, true);
            WriteLiteral("\"\r\n                               data-controller=\"Users\"\r\n                               data-action=\"Delete\"\r\n                               data-body-message=\"Are you sure you want to remove this User, Please Notice you can\'t delete an Admin?\">\r\n");
            EndContext();
            BeginContext(4887, 116, true);
            WriteLiteral("                                delete\r\n                            </a>\r\n                            </td>\r\n</tr>\r\n");
            EndContext();
#line 112 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.Web\Views\Users\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5022, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
