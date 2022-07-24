#pragma checksum "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8659115f82e6fa85c11a0a8324dac6c0d284818c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RSClass), @"mvc.1.0.view", @"/Views/RSClass.cshtml")]
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
#line 6 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8659115f82e6fa85c11a0a8324dac6c0d284818c", @"/Views/RSClass.cshtml")]
    public class Views_RSClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8659115f82e6fa85c11a0a8324dac6c0d284818c3237", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Register Class</title>
    <!-- Font Awesome -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css""
          rel=""stylesheet"" />
    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap""
          rel=""stylesheet"" />
    <!-- MDB -->
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.css""
          rel=""stylesheet"" />
    <style>
        .card-registration .select-input.form-control[readonly]:not([disabled]) {
            font-size: 1rem;
            line-height: 2.15;
            padding-left: .75em;
            padding-right: .75em;
        }

        .card-registration .select-arrow {
            top: 13px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8659115f82e6fa85c11a0a8324dac6c0d284818c5190", async() => {
                WriteLiteral(@"
    <section class=""h-100 bg-dark"" style=""margin-top:170px;"">
        <form id=""form1"" class=""form1"" action=""/student/registerclasss"" method=""post"">
            <div class=""container py-5 h-100"">
                <div class=""row d-flex justify-content-center align-items-center h-100"">
                    <div class=""col"">
                        <div class=""card card-registration my-4"">
                            <div class=""row g-0"">
                                <div class=""card-body p-md-5 text-black"">
                                    
");
#nullable restore
#line 46 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                         if (ViewBag.suc != null)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h3 class=\"mb-3 text-uppercase\">Register Class</h3>\r\n");
                WriteLiteral("                                            <div class=\"mb-2\" style=\"color:red;\"><span>");
#nullable restore
#line 50 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                                                                  Write(ViewBag.Suc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n");
#nullable restore
#line 51 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h3 class=\"mb-5 text-uppercase\">Register Class</h3>\r\n");
#nullable restore
#line 55 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    \r\n\r\n\r\n");
#nullable restore
#line 59 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                       Student s = ViewBag.User;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"form-outline mb-4\">\r\n                                        <select name=\"classid\" class=\"form-select\"");
                BeginWriteAttribute("onchange", " onchange=\"", 2620, "\"", 2631, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 62 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                             foreach (Class c in ViewBag.Class)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <option");
                BeginWriteAttribute("value", " value=\"", 2818, "\"", 2836, 1);
#nullable restore
#line 64 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
WriteAttributeValue("", 2826, c.ClassId, 2826, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 64 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                                                       Write(c.ClassId == s.ClassId ? "selected" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(">");
#nullable restore
#line 64 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                                                                                                  Write(c.ClassName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</option>\r\n");
#nullable restore
#line 65 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\RSClass.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </select>
                                    </div>

                                    <div class=""d-flex justify-content-end pt-3"">
                                        
                                            <button type=""button"" class=""btn btn-warning btn-lg"" onclick=""window.location='/student/home'"">Home</button>
                                            <button type=""button"" class=""btn btn-light btn-lg ms-2"" onclick=""window.location='/student/registerclass'"">Reset all</button>
                                            <button id=""btnsubmit"" name=""submit"" value=""submit"" type=""submit"" class=""btn btn-warning btn-lg ms-2"">Register Class</button>
                                        

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- MDB -->\r\n\r\n<script type=\"text/javascript\"\r\n        src=\"https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.js\"></script>\r\n</html>\r\n\r\n");
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
