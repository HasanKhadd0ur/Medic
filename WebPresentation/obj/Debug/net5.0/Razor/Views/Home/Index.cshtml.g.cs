#pragma checksum "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using WebPresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using WebPresentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using ApplicationCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afde39527760d3d287f4d84a4731a7fb9211e4e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MedicalState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/noData.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("figure-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(" ;\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
  
    var userName = UserManager.GetUserName(User);
    ViewData["title"] = "Home - " + userName;

    ViewData["userName"] = Model.User.FirstName + " " + Model.User.LastName;
    ViewBag.Avatar = Model.User.Avatar;

    ViewBag.owner = Model;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Masthead -->\r\n<header class=\"masthead bg-primary text-white text-center\">\r\n    <div class=\"container d-flex align-items-center flex-column\">\r\n\r\n        <!-- Masthead Avatar Image -->\r\n        <img class=\"masthead-avatar mb-5\"");
            BeginWriteAttribute("src", " src=\"", 759, "\"", 788, 2);
            WriteAttributeValue("", 765, "/img/", 765, 5, true);
#nullable restore
#line 27 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 770, Model.User.Avatar, 770, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:50%\"");
            BeginWriteAttribute("alt", " alt=\"", 815, "\"", 821, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <!-- Masthead Heading -->\r\n        <h1 class=\"masthead-heading text-uppercase mb-0\">");
#nullable restore
#line 30 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                     Write(Model.User.FirstName +" "+ Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

        <!-- Icon Divider -->
        <div class=""divider-custom divider-light"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Masthead Subheading -->
        <p class=""masthead-subheading font-weight-light mb-0"">");
#nullable restore
#line 42 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                         Write(Model.BIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</header>\r\n\r\n<section id=\"services\" class=\" services \">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>Your medical State  </h2>\r\n            <p>Here you can create new medical state ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d10386", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".</p>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
             if (Model.MedicalStates.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"text-center\">You dont have any  MedicalState</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d12152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
            }
            else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                 foreach (var item in Model.MedicalStates)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\"><i class=\"fas fa-heartbeat\"></i></div>\r\n                            <h4>");
#nullable restore
#line 69 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                           Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 70 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                          Write(item.StateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Prescriped at ");
#nullable restore
#line 70 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                  Write(item.PrescriptionTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a  data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 71 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-primary\" >\r\n                            Details</a>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>

    </div>
</section><!-- End Services Section -->

<!--<section class=""page-section "">
    <div class=""container-fluid"">-->

        <!-- Portfolio Grid Items -->
        <!--<div class=""row d-flex flex-wrap justify-content-sm-center"">
");
#nullable restore
#line 88 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
             if (Model.MedicalStates.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"text-center\">You dont have any  MedicalState</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d16106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
            }
            else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                 foreach (var item in Model.MedicalStates)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\"><i class=\"fas fa-heartbeat\"></i></div>\r\n                            <h4><a");
            BeginWriteAttribute("href", " href=\"", 3550, "\"", 3557, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                      Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <p>");
#nullable restore
#line 101 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                          Write(item.StateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <a href=\"#\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 102 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">go to descriptiuon </a>

                        </div>
                    </div>
                    <div class=""col-lg-4"">
                            <div class=""card m-3"">
                                <img src=""/img/portfolio/flappy.png""
                                     class=""card-img-top img-fluid"" style=""max-height:250px ""
                                     alt=""Waterfall"" />
                                <div class=""card-body"">
                                    <h5 class=""card-title"">");
#nullable restore
#line 112 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                      Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 114 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                   Write(item.StateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <br />\r\n                                        Date : ");
#nullable restore
#line 116 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                          Write(item.PrescriptionTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n                                        Medicines : ");
#nullable restore
#line 118 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                               Write(item.Medicines.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </p>\r\n                                    <a href=\"#\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 121 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">go to descriptiuon </a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 125 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>-->
        <!-- /.row -->

    <!--</div>
</section>-->
<section class=""page-section bg-primary  text-white mb-0"" id=""topThree"">
    <div class=""container-fluid"">
        <!-- Portfolio Section Heading -->
        <h2 class="" page-section-heading text-center text-uppercase text-secondary mb-0"">For more Medicine</h2><br />
        <h2 class="" page-section-heading text-center  text-secondary   mb-0"" style=""color :white!important ;"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d22166", async() => {
                WriteLiteral("Go to You Medical States profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h2>
        <!-- Icon Divider -->

    </div>

</section>

<!-- Contact Section -->
<section class=""page-section"" id=""contact"">
    <div class=""container"">

        <!-- Contact Section Heading -->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>

        <!-- Icon Divider -->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Contact Section Form -->
        <div class=""row"">
            <div class=""col-lg-8 mx-auto"">
                <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19. -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d24478", async() => {
                WriteLiteral(@"
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Name</label>
                            <input class=""form-control"" id=""name"" type=""text"" placeholder=""Name"" required=""required"" data-validation-required-message=""Please enter your name."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Email Address</label>
                            <input class=""form-control"" id=""email"" type=""email"" placeholder=""Email Address"" required=""required"" data-validation-required-message=""Please enter your email address."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </d");
                WriteLiteral(@"iv>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Phone Number</label>
                            <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""Phone Number"" required=""required"" data-validation-required-message=""Please enter your phone number."">
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Message</label>
                            <textarea class=""form-control"" id=""message"" rows=""5"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter a message.""></textarea>
                            <p class=""help-block text-danger""></p>
                        </div>
     ");
                WriteLiteral(@"               </div>
                    <br>
                    <div id=""success""></div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary btn-xl"" id=""sendMessageButton"">Send</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n<!-- Modals -->\r\n");
#nullable restore
#line 204 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
 foreach (var item in Model.MedicalStates)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Portfolio Modal  -->\r\n    <div class=\"portfolio-modal modal fade\"");
            BeginWriteAttribute("id", " id=\"", 9025, "\"", 9045, 2);
            WriteAttributeValue("", 9030, "item-", 9030, 5, true);
#nullable restore
#line 207 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 9035, item.Id, 9035, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 9074, "\"", 9106, 2);
            WriteAttributeValue("", 9092, "label-", 9092, 6, true);
#nullable restore
#line 207 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 9098, item.Id, 9098, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">

        <div class=""modal-dialog modal-xl"" role=""document"">
            <div class=""modal-content"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">
                        <i class=""fas fa-times""></i>
                    </span>
                </button>
                <div class=""modal-body text-center"">
                    <div class=""container"">
                        <div class=""row justify-content-center"">
                            <div class=""col-lg-8"">
                                <!-- Portfolio Modal - Title -->
                                <h2 class=""portfolio-modal-title text-secondary text-uppercase mb-0"">");
#nullable restore
#line 221 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                                <!-- Icon Divider -->
                                <div class=""divider-custom"">
                                    <div class=""divider-custom-line""></div>
                                    <div class=""divider-custom-icon"">
                                        <i class=""fas fa-star""></i>
                                    </div>
                                    <div class=""divider-custom-line""></div>
                                </div>
                                <!-- Portfolio Modal - Image -->
                                <img class=""img-fluid rounded mb-5"" src=""/img/portfolio/ecole.png""");
            BeginWriteAttribute("alt", " alt=\"", 10550, "\"", 10556, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <!-- Portfolio Modal - Text -->\r\n                                <p class=\"mb-5\">State Description : ");
#nullable restore
#line 233 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                               Write(item.StateDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-5\">State Name : ");
#nullable restore
#line 234 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                        Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-5\">State Time : ");
#nullable restore
#line 235 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                        Write(item.PrescriptionTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f05ebe4ffce4b1d702b897aa6d6bea59c99deb2d32795", async() => {
                WriteLiteral("View More ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 237 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(@"
                                <button class=""btn btn-primary"" href=""#"" data-dismiss=""modal"">
                                    <i class=""fas fa-times fa-fw""></i>
                                    Close Window
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
");
#nullable restore
#line 250 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
