#pragma checksum "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e510ed68986b920290ced8458e9985171f2bd0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e510ed68986b920290ced8458e9985171f2bd0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afde39527760d3d287f4d84a4731a7fb9211e4e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/noData.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("figure-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MedicinesGalary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MedicineDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
  
    ViewData["title"] = "Home - " + UserManager.GetUserName(User);

    ViewData["userName"] = Model.FirstName + " " + Model.LastName;

    ViewBag.owner = Model;
    var top = Model.Medicines.Where(t => t.Dosage > 0).ToList();
    var i = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Masthead -->\r\n<header class=\"masthead bg-primary text-white text-center\">\r\n    <div class=\"container d-flex align-items-center flex-column\">\r\n\r\n        <!-- Masthead Avatar Image -->\r\n        <img class=\"masthead-avatar mb-5\"");
            BeginWriteAttribute("src", " src=\"", 760, "\"", 784, 2);
            WriteAttributeValue("", 766, "/img/", 766, 5, true);
#nullable restore
#line 27 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 771, Model.Avatar, 771, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-radius:50%\"");
            BeginWriteAttribute("alt", " alt=\"", 811, "\"", 817, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        <!-- Masthead Heading -->\r\n        <h1 class=\"masthead-heading text-uppercase mb-0\">");
#nullable restore
#line 30 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                     Write(Model.FirstName +" "+ Model.LastName);

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
            WriteLiteral(@"</p>

    </div>
</header>

<!-- Portfolio Section -->
<section class=""page-section portfolio"" id=""portfolio"">
    <div class=""container-fluid"">

        <!-- Portfolio Section Heading -->
        <h2 class="" page-section-heading text-center text-uppercase text-secondary mb-0"">Patient Medicine</h2>
        <!-- Icon Divider -->

        <div class="" divider-custom"">
            <div class=""divider-custom-line""></div>

            <div class=""divider-custom-icon"">
                <i class=""fas fa-star""></i>
            </div>
            <div class=""divider-custom-line""></div>
        </div>

        <!-- Portfolio Grid Items -->
        <div class=""row d-flex flex-wrap justify-content-sm-around"">
");
#nullable restore
#line 66 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
             if (Model.Medicines.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2 class=\"text-center\">You dont have any  Medicine</h2>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33e510ed68986b920290ced8458e9985171f2bd011263", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
            }
            else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                 foreach (var item in Model.Medicines)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card col-md-4 col-lg-4 m-1 \" style=\"width: 10rem;\">\r\n                        <img class=\" card-img-top mw-30 mh-30 card-img-top\" style=\"height:250px;max-width:270px ;\"");
            BeginWriteAttribute("src", " src=", 2647, "", 2685, 1);
#nullable restore
#line 77 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 2652, "/img/portfolio/" +item.Image , 2652, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ) alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 79 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">project cost : ");
#nullable restore
#line 80 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <a href=\"#\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#item-");
#nullable restore
#line 82 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">go to descriptiuon </a>\r\n                        </div>\r\n                    </div>");
#nullable restore
#line 84 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <!-- /.row -->\r\n\r\n    </div>\r\n</section>\r\n<section class=\"page-section bg-primary  text-white mb-0\" id=\"topThree\">\r\n    <div >\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e510ed68986b920290ced8458e9985171f2bd015015", async() => {
                WriteLiteral("Go to Add Medicine to your profile ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                               WriteLiteral(Model.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e510ed68986b920290ced8458e9985171f2bd018412", async() => {
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
#line 158 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
 foreach (var item in Model.Medicines)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Portfolio Modal  -->\r\n    <div class=\"portfolio-modal modal fade\"");
            BeginWriteAttribute("id", " id=\"", 6895, "\"", 6915, 2);
            WriteAttributeValue("", 6900, "item-", 6900, 5, true);
#nullable restore
#line 161 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 6905, item.Id, 6905, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" role=\"dialog\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 6944, "\"", 6976, 2);
            WriteAttributeValue("", 6962, "label-", 6962, 6, true);
#nullable restore
#line 161 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 6968, item.Id, 6968, 8, false);

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
#line 175 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                                                Write(item.Name);

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
                                <img class=""img-fluid rounded mb-5""");
            BeginWriteAttribute("src", " src=", 8384, "", 8421, 1);
#nullable restore
#line 185 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 8389, "/img/portfolio/"+item.Image , 8389, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" )");
            BeginWriteAttribute("alt", " alt=\"", 8423, "\"", 8429, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <!-- Portfolio Modal - Text -->\r\n                                <p class=\"mb-5\">medicine Description : ");
#nullable restore
#line 187 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-5\">medicine price : ");
#nullable restore
#line 188 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"mb-5\">medicine Dosage : ");
#nullable restore
#line 189 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
                                                             Write(item.Dosage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33e510ed68986b920290ced8458e9985171f2bd027057", async() => {
                WriteLiteral("View More ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 191 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"
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
#line 204 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Home\Index.cshtml"

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
