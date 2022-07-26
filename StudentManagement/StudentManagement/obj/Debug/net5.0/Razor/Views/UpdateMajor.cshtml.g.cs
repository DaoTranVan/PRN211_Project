#pragma checksum "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71b1f531eb73add3dd9666abdc8b812cdb96ce5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UpdateMajor), @"mvc.1.0.view", @"/Views/UpdateMajor.cshtml")]
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
#line 6 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71b1f531eb73add3dd9666abdc8b812cdb96ce5a", @"/Views/UpdateMajor.cshtml")]
    public class Views_UpdateMajor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b1f531eb73add3dd9666abdc8b812cdb96ce5a3261", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Update Major</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71b1f531eb73add3dd9666abdc8b812cdb96ce5a5212", async() => {
                WriteLiteral(@"
    <section class=""h-100 bg-dark"">
        <form id=""form1"" class=""form1"" action=""/admin/updatemajors"" method=""post"">
            <div class=""container py-5 h-100"">
                <div class=""row d-flex justify-content-center align-items-center h-100"">
                    <div class=""col"">
                        <div class=""card card-registration my-4"">
                            <div class=""row g-0"">

                                <div class=""col-xl-12"">
                                    <div class=""card-body p-md-5 text-black"">
");
#nullable restore
#line 47 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
                                         if (ViewBag.suc != null)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h3 class=\"mb-3 text-uppercase\">Update Major</h3>\r\n");
                WriteLiteral("                                            <div class=\"mb-2\" style=\"color:red;\"><span>");
#nullable restore
#line 51 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
                                                                                  Write(ViewBag.Suc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></div>\r\n");
#nullable restore
#line 52 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <h3 class=\"mb-5 text-uppercase\">Update Major</h3>\r\n");
#nullable restore
#line 56 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
                                           Major s = ViewBag.Majors;

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <div class=\"form-outline mb-4\">\r\n                                            <input");
                BeginWriteAttribute("value", " value=\"", 2545, "\"", 2563, 1);
#nullable restore
#line 60 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
WriteAttributeValue("", 2553, s.MajorId, 2553, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""mid"" type=""text"" id=""form3Example90"" class=""form-control form-control-lg"" readonly/>
                                            <label class=""form-label"" for=""form3Example90"">MajorID</label>
                                        </div>
                                        <div class=""form-outline mb-4"" >
                                            <input");
                BeginWriteAttribute("value", " value=\"", 2937, "\"", 2957, 1);
#nullable restore
#line 64 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
WriteAttributeValue("", 2945, s.MajorName, 2945, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""name"" type=""text"" id=""form3Example90"" class=""form-control form-control-lg"" required/>
                                            <label class=""form-label"" for=""form3Example90"">Major Name</label>
                                        </div>

                                        <div class=""form-outline mb-4"">
                                            <input");
                BeginWriteAttribute("value", " value=\"", 3336, "\"", 3356, 1);
#nullable restore
#line 69 "D:\PRN211_Project\StudentManagement\StudentManagement\Views\UpdateMajor.cshtml"
WriteAttributeValue("", 3344, s.MajorDesc, 3344, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""desc"" type=""text"" id=""form3Example8"" class=""form-control form-control-lg"" required/>
                                            <label class=""form-label"" for=""form3Example8"">Major Desc</label>
                                        </div>


                                        <div class=""d-flex justify-content-end pt-3"">
                                            <button type=""button"" class=""btn btn-warning btn-lg"" onclick=""window.location='/student/home'"">Home</button>
                                            <button type=""button"" class=""btn btn-light btn-lg ms-2"" onclick=""window.location='/admin/majorlist'"">Back</button>
                                            <button id=""btnsubmit"" name=""submit"" value=""submit"" type=""submit"" class=""btn btn-warning btn-lg ms-2"">Update Major</button>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div");
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </form>\r\n\r\n    </section>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n<!-- MDB -->\r\n\r\n<script type=\"text/javascript\"\r\n        src=\"https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/4.3.0/mdb.min.js\"></script>\r\n</html>\r\n");
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
