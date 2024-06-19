#pragma checksum "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f715de657dda20a32548f34631b9d9ede67ca8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicine_Details), @"mvc.1.0.view", @"/Views/Medicine/Details.cshtml")]
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
using ApplicationCore.DomainModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using ApplicationDomain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f715de657dda20a32548f34631b9d9ede67ca8a", @"/Views/Medicine/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a5efe30164a0b2b148ed0b3ef352c1f6e80ba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicine_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicineModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid my-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIngredints", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Medicine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
  
    ViewData["Title"] = "Medicine Details ";

    Layout = "_AdminLayout";
    var a = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""page-section"">
    <div class=""container  h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col col-lg-8 mb-4 mb-lg-0"">
                <div class=""card mb-3"" style=""border-radius: .5rem;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 gradient-custom text-center text-black""
                             style=""border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f715de657dda20a32548f34631b9d9ede67ca8a6860", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 670, "~/img/portfolio/", 670, 16, true);
#nullable restore
#line 17 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
AddHtmlAttributeValue("", 686, Model.Image, 686, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h5>");
#nullable restore
#line 19 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                           Write(Model.TradeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>Category: ");
#nullable restore
#line 20 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                     Write(Model.Category is null ? "":Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f715de657dda20a32548f34631b9d9ede67ca8a9226", async() => {
                WriteLiteral("\r\n                                <i class=\"far fa-edit mb-5\"></i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
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
                        <div class=""col-md-8"">
                            <div class=""card-body p-4"">
                                <h6>Information:</h6>
                                <hr class=""mt-0 mb-4"">
                                <div class=""row pt-1"">
                                    <div class=""col-6 mb-3"">
                                        <h6>Description</h6>
                                        <p class=""text-muted"">");
#nullable restore
#line 33 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"col-6 mb-3\">\r\n                                        <h6>Medicine Type:");
#nullable restore
#line 36 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                     Write(Model.MedicineType?.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-muted\">Dosage : ");
#nullable restore
#line 37 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                                  Write(Model.Dosage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted\">Price : ");
#nullable restore
#line 38 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                                 Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                                <h6>Ingredients : </h6>
                                <hr class=""mt-0 mb-4"">
                                <div class=""row pt-1"">
                                    <table class=""table table-bordered"">
                                        <thead>
                                            <tr>
                                                <td>#</td>
                                                <td>Name</td>
                                                <td>Description</td>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 53 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                             foreach (var ing in Model.Ingredients)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr class=\" mb-3\">\r\n                                                    <td>");
#nullable restore
#line 56 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                    Write(a+=1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 57 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                   Write(ing.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 58 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                   Write(ing.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                                <div class=""row pt-1"">
                                    <div class=""col-6 mb-3"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f715de657dda20a32548f34631b9d9ede67ca8a16149", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                    <div class=\"col-6 mb-3\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f715de657dda20a32548f34631b9d9ede67ca8a17467", async() => {
                WriteLiteral("Add Ingredients ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
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

                                    <div class=""col-6 mb-3"">
                                        <button class=""btn btn-primary"" onclick=""fetchAll()"">Get All Ingredients </button>

                                    </div>
                                    <div id=""t"">
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""page-section mb-4 mt-4"">
    
    <div id=""mod"">

    </div>
</section>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        async function fetchAll() {
            try {
                debugger
                let response = await fetch('/Medicine/GetIngredints'); // Adjust the endpoint as needed
                if (response.ok) {
                    let medicines = await response.json();
                    //   showModal('',medicines);
                    populateTable(medicines,'t')
                } else {
                    console.error('Error:', response.statusText);
                    showToast(medicines, 'error');

                }
            } catch (error) {
                console.error('Fetch error:', error);
            }
        }
        async function updateMedicines() {
               let id =");
#nullable restore
#line 116 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                  Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            try {
                debugger
                let response = await fetch(`/MedicalState/GetMedicalStateMedicine/?id=${id}`); // Adjust the endpoint as needed
                if (response.ok) {
                    let medicines = await response.json();
                    populateTable(medicines, 'Ingredients_');
                } else {
                    console.error('Error:', response.statusText);
                }
            } catch (error) {
                console.error('Fetch error:', error);
            }
        }

        function populateTable(medicines,tableName) {


            let tableBody = document.querySelector('#' + tableName);
            tableBody.innerHTML = `
            <table class=""table"">
               <thead>
                <tr>
                    <td>Name</td>
                    <td>Description</td>
                    <td>Manage</td>
                </tr>
            </thead ><tbody id=""b""> </tbody></table>`;

             tableB");
                WriteLiteral(@"ody = document.querySelector('#b');

            medicines.forEach(medicine => {
                let row = document.createElement('tr');
                row.classList = ""mb-3""

                row.innerHTML = `
                    <td>${medicine.name}</td>
                    <td>${medicine.description}</td>
                    `;
                row.innerHTML +=
                    (tableName != ""t"") ?

                        `
                <td>

                    <button class=""btn btn-danger"" ondblclick=""ReomveIngredient(${medicine.id})"">Delete</button>
                    </td>
                ` :
                        `<td>
                        <button class=""btn btn-primary"" onclick=""addIngredient( ${medicine.id})"">Add</button>
    
                    </td>
                `

                tableBody.appendChild(row);
            });

            tableBody.innerHTML += ``;

        }

        async function addIngredient(med) {
            let id =");
#nullable restore
#line 179 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            try {
                var r;
                prompt(""what is the ratio"", r);
                let response = await fetch(`/Medicine/AddIngredintsT`, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({ ingredientId: ing, medicineId: med ,ratio:r}) // Adjust the body as needed
                });

                if (response.ok) {
                    let result = await response.json();
                    updateMedicines();
                    showToast('Medicine added successfully', 'Success');
                } else {
                    console.error('Error:', response.statusText);
                    showToast('Failed to add medicine', 'Error');
                }
            } catch (error) {
                console.error('Fetch error:', error);
                showToast('Failed to add medicine', 'Error');
            }
        }
");
                WriteLiteral("        async function DetailMedicine(med) {\r\n            let id =");
#nullable restore
#line 205 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            try {
                debugger
                let response = await fetch(`/Medicine/GetDetails/${med}`, {
                    method: 'GET',
                    headers: {
                        'Content-Type': 'application/json'
                    }
                 });

                if (response.ok) {
                    let result = await response.json();
                    console.log(result)
                    showModal('Medicine Details',result );
                } else {
                    console.error('Error:', response.statusText);
                    showToast('Failed to add medicine', 'Error');
                }
            } catch (error) {
                console.error('Fetch error:', error);
                showToast('Failed to add medicine', 'Error');
            }
        }

        async function ReomveMedicine(med) {
            let id =");
#nullable restore
#line 230 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            try {
                showToast('Loading ... ', 'Removing medicine');

                let response = await fetch(`/Medicine/RemoveMedicineJ?id=${id}&med=${med}`, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({ id: id, med: med }) // Adjust the body as needed
                });

                if (response.ok) {
                    let result = await response.json();

                    updateMedicines();

                    showToast('Medicine Reomved successfully', 'Success');
                } else {
                    console.error('Error:', response.statusText);
                    showToast('Failed to remove medicine', 'Error');
                }
            } catch (error) {
                console.error('Fetch error:', error);
                showToast('Failed to remove medicine', 'Error');
            }
        }");
                WriteLiteral(@"
        async function DeleteConfirm(id ) {
        }
        function showToast(message, title) {

            const modalBody = document.querySelector('#mod');
            modalBody.innerHTML = `
                   <div class=""modal fade"" id=""item"" tabindex=""-1"" aria-labelledby=""label-"" role=""dialog""
             aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header border-bottom-0"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">
                                <i class=""fas fa-times""></i>
                            </span>
                        </button>
                    </div>
                    <div class=""modal-body text-start p-3"">
                        <h5 class=""modal-title text-uppercase mb-5"" id=""exampleModalLabel"">${title}</h5>

                        <p class="" mb-5"">");
                WriteLiteral(@" ${message}</p>

                        <hr class=""mt-2 mb-4""
                            style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">
                    <div class=""modal-footer d-flex justify-content-center border-top-0 py-4"">

                        <button class=""btn btn-info"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">Close</button>
                    </div>
                </div>
            </div>
        </div>  `;
            // Show the modal
            const medicineModal = new bootstrap.Modal(document.getElementById('item'));
            medicineModal.show();


        }
        function showModal(message, result) {
            var s = result
            var t = 0;
            var r= ''
            for (i in s) {
                console.log(i)
                r+=`

                                                <tr class="" mb-3"">
                                                    <td>${s[i].name}</td>
");
                WriteLiteral(@"                                                    <td>${s[i].description}</td>
                                                    <td>
<button class=""btn btn-info""  onclick=""addIngredient(${s[i].id})"">Add</button>
</td>
                                                </tr>


            `}
            const modalBody = document.querySelector('#mod');
            modalBody.innerHTML = `
                   <div class=""modal fade portfolio-modal "" id=""item"" tabindex=""-1"" aria-labelledby=""label-"" role=""dialog""
             aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header border-bottom-0"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">
                                <i class=""fas fa-times""></i>
                            </span>
                        </button>
                    </di");
                WriteLiteral(@"v>
                    <div class=""modal-body text-start p-3"">
                        <h5 class=""modal-title text-uppercase mb-5"" id=""exampleModalLabel"">All Ingredients</h5>

                        <hr class=""mt-2 mb-4""
                            style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">
                        <table class=""table table-bordered"">
                                        <thead>
                                            <tr>
                                                <td>Name</td>
                                                <td>Description</td>
                                                <td>Manage</td>
                                            </tr>
                                        </thead>
                                        <tbody>

                            ${r}
                                </tbody>
</table>

                        <hr class=""mt-2 mb-4""
                         ");
                WriteLiteral(@"   style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">

                    </div>
                    <div class=""modal-footer d-flex justify-content-center border-top-0 py-4"">

                        <button class=""btn btn-info"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">Close</button>
                    </div>
                </div>
            </div>
        </div>  `;
            // Show the modal
            const medicineModal = new bootstrap.Modal(document.getElementById('item'));
            medicineModal.show();

        }
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicineModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
