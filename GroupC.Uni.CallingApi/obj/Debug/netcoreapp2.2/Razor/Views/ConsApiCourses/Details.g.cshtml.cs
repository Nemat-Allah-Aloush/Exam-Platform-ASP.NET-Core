#pragma checksum "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dde779ef92db56f4b6a4f1850e7745745dd549c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConsApiCourses_Details), @"mvc.1.0.view", @"/Views/ConsApiCourses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ConsApiCourses/Details.cshtml", typeof(AspNetCore.Views_ConsApiCourses_Details))]
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
#line 1 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\_ViewImports.cshtml"
using GroupC.Uni.CallingApi;

#line default
#line hidden
#line 2 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\_ViewImports.cshtml"
using GroupC.Uni.CallingApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dde779ef92db56f4b6a4f1850e7745745dd549c6", @"/Views/ConsApiCourses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e66d6cde3473289782194d658083a73068dc77", @"/Views/_ViewImports.cshtml")]
    public class Views_ConsApiCourses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupC.Uni.Core.Entities.Exam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1148, true);
            WriteLiteral(@"<style>

    col-lg-6 h2 {
        font-size: 48px;
        color: #40424a;
        font-family: 'Josefin Sans', sans-serif;
    }

    .hero-info dl dt span {
        color: #40424a;
        display: inline-block;
        min-width: 220px;
    }

    /*.hero-info dl dd {
        font-size: 18px;
        color: #808181;
    }*/
</style>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xl-10 offset-xl-1"">
                <div class=""row"">
                    <div class=""col-sm-3""> </div>
                    <div class=""col-sm-6 box-body with-border"" style=""background-color:white; border-top: 3px solid #d2d6de;"">
                        <div class=""col-sm-7"">
                            <div style=""border-bottom: 1px solid #d2d6de;"">
                                <h3>Exam Details</h3>

                            </div>
                            <div class=""hero-info"">
                                <div></di");
            WriteLiteral("v>\r\n                                <dl>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1187, 53, false);
#line 38 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DurationInMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 169, true);
            WriteLiteral("\r\n                                        \r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1410, 49, false);
#line 42 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.DurationInMinutes));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 129, true);
            WriteLiteral("\r\n                                    </dd>\r\n\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1589, 50, false);
#line 46 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.QuestionsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(1767, 46, false);
#line 49 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.QuestionsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(1941, 42, false);
#line 52 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2111, 43, false);
#line 55 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 127, true);
            WriteLiteral("\r\n                                    </dd>\r\n                                    <dt>\r\n                                        ");
            EndContext();
            BeginContext(2282, 46, false);
#line 58 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TestCenter));

#line default
#line hidden
            EndContext();
            BeginContext(2328, 127, true);
            WriteLiteral("\r\n                                    </dt>\r\n                                    <dd>\r\n                                        ");
            EndContext();
            BeginContext(2456, 47, false);
#line 61 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.TestCenter.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 777, true);
            WriteLiteral(@"
                                    </dd>
                                    <dt>Questions </dt>
                                    <dd>
                                        <table class=""table"" id=""#QuestionExamTable"">
                                            <thead>
                                                <tr>
                                                    <th>Text</th>
                                                    <th>Mark</th>
                                                    <th>Topic Name</th>
                                                    <th>Choices</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
            EndContext();
#line 75 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                 foreach (var item in Model.ExamQuestions)
                                                {


#line default
#line hidden
            BeginContext(3425, 119, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td> ");
            EndContext();
            BeginContext(3545, 18, false);
#line 79 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                        Write(item.Question.Text);

#line default
#line hidden
            EndContext();
            BeginContext(3563, 68, true);
            WriteLiteral("</td>\r\n                                                        <td> ");
            EndContext();
            BeginContext(3632, 9, false);
#line 80 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                        Write(item.Mark);

#line default
#line hidden
            EndContext();
            BeginContext(3641, 68, true);
            WriteLiteral("</td>\r\n                                                        <td> ");
            EndContext();
            BeginContext(3710, 24, false);
#line 81 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                        Write(item.Question.Topic.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3734, 135, true);
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <ol>\r\n");
            EndContext();
#line 84 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                 foreach (var ch in item.Question.Choices)
                                                                {
                                                                    

#line default
#line hidden
#line 87 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                     if (ch.Type)
                                                                    {

#line default
#line hidden
            BeginContext(4313, 100, true);
            WriteLiteral("                                                                        <li style=\"color:limegreen\">");
            EndContext();
            BeginContext(4414, 7, false);
#line 89 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                                               Write(ch.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4421, 5, true);
            WriteLiteral("</li>");
            EndContext();
#line 89 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                                                                 }

#line default
#line hidden
#line 90 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                     if (!ch.Type)
                                                                    {

#line default
#line hidden
            BeginContext(4584, 94, true);
            WriteLiteral("                                                                        <li style=\"color:red\">");
            EndContext();
            BeginContext(4679, 7, false);
#line 92 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                                         Write(ch.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4686, 5, true);
            WriteLiteral("</li>");
            EndContext();
#line 92 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                                                           }

#line default
#line hidden
#line 92 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"
                                                                                                            
                                                                }

#line default
#line hidden
            BeginContext(4761, 191, true);
            WriteLiteral("                                                            </ol>\r\n                                                        </td>\r\n\r\n                                                    </tr>\r\n");
            EndContext();
#line 98 "C:\Users\ASUS\Desktop\Azure\GroupC.Uni.CallingApi\Views\ConsApiCourses\Details.cshtml"

                                                }

#line default
#line hidden
            BeginContext(5005, 396, true);
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </dd>
                                </dl>
                            </div>                          
                        </div>
                    </div>


                </div>

            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupC.Uni.Core.Entities.Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
