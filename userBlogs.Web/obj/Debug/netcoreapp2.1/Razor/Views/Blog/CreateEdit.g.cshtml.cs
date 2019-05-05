#pragma checksum "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc1c1afd0a27599abbcde80f055d0386349c7070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_CreateEdit), @"mvc.1.0.view", @"/Views/Blog/CreateEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/CreateEdit.cshtml", typeof(AspNetCore.Views_Blog_CreateEdit))]
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
#line 1 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\_ViewImports.cshtml"
using userBlogs.Web;

#line default
#line hidden
#line 2 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\_ViewImports.cshtml"
using userBlogs.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc1c1afd0a27599abbcde80f055d0386349c7070", @"/Views/Blog/CreateEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344e42dcf1281a5b6f2901657299efe8ee49232e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_CreateEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<userBlogs.Web.ViewModels.BlogAddVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Snimi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
  
    ViewData["Title"] = "CreateEdit";

#line default
#line hidden
            BeginContext(91, 2505, true);
            WriteLiteral(@"
<h2>Create/Edit</h2>



    <script>
        $().ready(function () {

            $(""#createEditForm"").validate({
                onfocusout: function (element) {
                    $(element).valid();
                },
                rules: {
                    Title: {
                        required: true,
                        maxlength: 64
                    },
                    Summary: {
                        required: true,
                        maxlength: 350
                    },
                    Content:
                    {
                        required: true,
                        maxlength: 3500
                    }


                },
                messages: {

                    Title: {
                        required: ""Field is required"",
                        maxlength: ""Maximum length is 64""
                    },
                    Summary: {
                        required: ""Field is required"",
                      ");
            WriteLiteral(@"  maxlength: ""Maximum length is 350""
                    },
                    Content:
                    {
                        required: ""Field is required"",
                        maxlength: ""Maximum length is 3500""

                    }

                }
            });
        });




        var label = document.createElement(""label"");
        var node = document.createTextNode(""Date cannot be in the past"");
        var errorLabel = document.getElementById(""errorLabel"");
        label.appendChild(node);





        function checkDate() {





                var selectedText = document.getElementById(""Datum"").value;
                var selectedDate = new Date(selectedText);

            var now = new Date();
            now.setHours(0, 0, 0, 0);
            selectedDate.setHours(0, 0, 0, 0);

                if (selectedDate < now) {

                    datumProvjera = false;


                } else {
                    datumProvjera = true;
    ");
            WriteLiteral(@"            }

                if (!datumProvjera) {

                    $(""#Datum"").addClass(""netacanDatum"");

                    errorLabel.appendChild(label);

                } else {


                    $(""#Datum"").removeClass(""netacanDatum"");

                    errorLabel.removeChild(label);
                }

          
                return datumProvjera;



    


          

        }




</script>



");
            EndContext();
            BeginContext(2596, 1372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4e0d0c9c8c4d74ad95901b62101487", async() => {
                BeginContext(2663, 122, true);
                WriteLiteral("\r\n    <div class=\"formContainer pl-3\">\r\n        <div class=\"form-group\">\r\n\r\n            <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2785, "\"", 2806, 1);
#line 127 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 2793, Model.userId, 2793, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2807, 51, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"blogId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2858, "\"", 2879, 1);
#line 128 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 2866, Model.blogId, 2866, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2880, 61, true);
                WriteLiteral(" />\r\n\r\n            <div>\r\n                <input name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2941, "\"", 2961, 1);
#line 131 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 2949, Model.Title, 2949, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2962, 193, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Title\" />\r\n               \r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <div>\r\n                <input name=\"Summary\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3155, "\"", 3177, 1);
#line 139 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 3163, Model.summary, 3163, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3178, 241, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Summary\" id=\"summary\" />\r\n\r\n               \r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <div>\r\n                <textarea name=\"Content\" id=\"content\" cols=\"95\">");
                EndContext();
                BeginContext(3420, 13, false);
#line 150 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
                                                           Write(Model.Content);

#line default
#line hidden
                EndContext();
                BeginContext(3433, 171, true);
                WriteLiteral(" </textarea> \r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <div>\r\n                <input class=\"form-control\" type=\"datetime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3604, "\"", 3624, 1);
#line 159 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 3612, Model.datum, 3612, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3625, 248, true);
                WriteLiteral(" id=\"Datum\" name=\"Datum\" onchange=\"checkDate()\" />\r\n\r\n                <div id=\"errorLabel\"> </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <input type=\"submit\" class=\"btn btn-light\" value=\"Save\" onclick=\"return checkDate() \" />\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3873, "\"", 3914, 2);
                WriteAttributeValue("", 3880, "/user/details?userId=", 3880, 21, true);
#line 167 "C:\Users\Faruk\source\repos\userBlogs\userBlogs.Web\Views\Blog\CreateEdit.cshtml"
WriteAttributeValue("", 3901, Model.userId, 3901, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3915, 46, true);
                WriteLiteral(" class=\"btn btn-dark\" >Close</a>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3968, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<userBlogs.Web.ViewModels.BlogAddVM> Html { get; private set; }
    }
}
#pragma warning restore 1591