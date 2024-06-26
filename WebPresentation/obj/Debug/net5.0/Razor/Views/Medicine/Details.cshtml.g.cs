#pragma checksum "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3adb1006546d7a2aac9737521701c9562d1419eb"
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
using WebPresentation.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using ApplicationDomain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using ApplicationCore.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3adb1006546d7a2aac9737521701c9562d1419eb", @"/Views/Medicine/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a2f5fee0d7223f937b9f0309fc3b9062263e26d", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicine_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedicineViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid my-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIngredints", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Medicine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    ViewData["Controller"] = "Medicine";
    Layout = "_AdminLayout";
    var a = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""page-section"">
    <div class=""container  h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col col-lg-8 mb-4 mb-lg-0"">
                <div class=""card mb-3"" style=""border-radius: .5rem;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 gradient-custom text-center text-black""
                             style=""border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3adb1006546d7a2aac9737521701c9562d1419eb6604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 716, "~/img/portfolio/", 716, 16, true);
#nullable restore
#line 18 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
AddHtmlAttributeValue("", 732, Model.Image, 732, 12, false);

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
#line 20 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                           Write(Model.TradeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p>Category: ");
#nullable restore
#line 21 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                     Write(Model.Category is null ? "":Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <button class=\"btn btn-warning btn-edit\" data-id=\"");
#nullable restore
#line 22 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</button>\r\n                            <button class=\"btn btn-danger btn-delete\" data-id=\"");
#nullable restore
#line 23 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                                          Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Delete</button>
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
#line 32 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"col-6 mb-3\">\r\n                                        <h6>Type:");
#nullable restore
#line 35 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                            Write(Model.MedicineType?.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-muted\">Dosage : ");
#nullable restore
#line 36 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                                  Write(Model.Dosage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"text-muted\">Price : ");
#nullable restore
#line 37 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
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
                                    <table id=""Ingredients_"" class=""table table-bordered"">
                                        <thead>
                                            <tr>
                                                <td>#</td>
                                                <td>Name</td>
                                                <td>Description</td>
                                                <td>Ratio</td>
                                                <td>Manage</td>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 54 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                             foreach (var ing in Model.MedicineIngredients)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr class=\" mb-3\">\r\n                                                <td>");
#nullable restore
#line 57 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                                Write(a+=1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 58 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                               Write(ing.Ingredient.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 59 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                               Write(ing.Ingredient.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 60 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
                                               Write(ing.Ratio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    <button class=\"btn btn-danger\"");
            BeginWriteAttribute("ondblclick", " ondblclick=\'", 3643, "\'", 3800, 16);
            WriteAttributeValue("", 3656, "DeleteConfirm(\"Delete", 3656, 21, true);
            WriteAttributeValue(" ", 3677, "Confirm\",", 3678, 10, true);
            WriteAttributeValue(" ", 3687, "\"Are", 3688, 5, true);
            WriteAttributeValue(" ", 3692, "you", 3693, 4, true);
            WriteAttributeValue(" ", 3696, "sure", 3697, 5, true);
            WriteAttributeValue(" ", 3701, "you", 3702, 4, true);
            WriteAttributeValue(" ", 3705, "want", 3706, 5, true);
            WriteAttributeValue(" ", 3710, "to", 3711, 3, true);
            WriteAttributeValue(" ", 3713, "delete", 3714, 7, true);
#nullable restore
#line 62 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
WriteAttributeValue(" ", 3720, ing.Ingredient.Name, 3721, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3741, "From", 3742, 5, true);
            WriteAttributeValue(" ", 3746, "this", 3747, 5, true);
            WriteAttributeValue(" ", 3751, "medicine\",", 3752, 11, true);
            WriteAttributeValue(" ", 3762, "\"ReomveIngredient\",", 3763, 20, true);
#nullable restore
#line 62 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
WriteAttributeValue("", 3782, ing.IngredientId, 3782, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3799, ")", 3799, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                                </td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3adb1006546d7a2aac9737521701c9562d1419eb16637", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                    <div class=\"col-6 mb-3\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3adb1006546d7a2aac9737521701c9562d1419eb17955", async() => {
                WriteLiteral("Add Ingredients ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
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
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col-12 col-lg-10 mb-4 mb-lg-0"">
                <div class=""card mb-3"" style=""border-radius: .5rem;"">

                    <div id=""t"">
                    </div>
                </div>
            </div>
            </div>
        </div>
</section>
<div id=""mod"">

</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        async function fetchAll() {
            try {
                debugger
                let response = await fetch('/Ingredient/GetAll'); // Adjust the endpoint as needed
                if (response.ok) {
                    let medicines = await response.json();
                    //   showModal('',medicines);
                    populateTable(medicines.result,'t')
                } else {
                    console.error('Error:', response.statusText);
                    showToast(medicines, 'error');

                }
            } catch (error) {
                console.error('Fetch error:', error);
            }
        }
        async function updateIngredients() {
            let id =");
#nullable restore
#line 131 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            debugger;
            try {
                let response = await fetch(`/Medicine/GetMedcineIngredient/${id}`); // Adjust the endpoint as needed
                if (response.ok) {
                    let medicines = await response.json();
                    medicines = medicines.medicineIngredients
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
                    ${tableName==""t"" ?"" "":""<td>Ratio</td>""}
                    <td>Mana");
                WriteLiteral(@"ge</td>

                </tr>
            </thead ><tbody id=""b""> </tbody></table>`;

             tableBody = document.querySelector('#b');

            medicines.forEach(medicine => {
                let row = document.createElement('tr');
                row.classList = ""mb-3""

                row.innerHTML = `
                    <td>${medicine.name}</td>
                    <td>${medicine.description}</td>
                    ${tableName == ""t"" ? "" "" : medicine.ratio}
                    `;
                row.innerHTML +=
                    (tableName != ""t"") ?

                        `
                <td>

                                                    <button class=""btn btn-danger"" ondblclick='DeleteConfirm(""Delete Confirm"", ""Are you sure you want to delete ${medicine.name}From this medicine"", ""ReomveIngredient"",${medicine.ingredient.id})'>Delete</button>

</td>
                ` :
                        `<td>
                        <button class=""btn btn-primary""");
                WriteLiteral(@" onclick=""addIngredient( ${medicine.id})"" data-dismiss=""modal"" aria-label=""Close"">Add</button>

                    </td>
                `

                tableBody.appendChild(row);
            });

            tableBody.innerHTML += ``;

        }
        function addIngredient(med) {
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
             ");
                WriteLiteral(@"       <div class=""modal-body text-start p-3"">
                        <h5 class=""modal-title text-uppercase mb-5"" id=""exampleModalLabel"">chose the ratio</h5>

                        <p class="" mb-5""> what is the ratio </p>
                        <input type=""number"" value=1 id=""r"">
                        <hr class=""mt-2 mb-4""
                            style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">
                    <div class=""modal-footer d-flex justify-content-center border-top-0 py-4"">

                        <button class=""btn btn-info"" onclick=""addIngredientT(${med})""  data-dismiss=""modal"" aria-label=""Close"">Add</button>
                        <button class=""btn btn-primary""  data-dismiss=""modal"" aria-label=""Close"">Close</button>

                    </div>
                </div>
            </div>
        </div>  `;
            // Show the modal
            const medicineModal = new bootstrap.Modal(document.getElementById('item");
                WriteLiteral("\'));\r\n            medicineModal.show();\r\n\r\n\r\n        }\r\n        async function addIngredientT(med) {\r\n            let id =");
#nullable restore
#line 233 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            try {
                var r = document.getElementById('r').value;
                console.log(r)

                let response = await fetch(`/Medicine/AddIngredient`, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({ IngredientId: med , MedicineId:id ,Ratio:r}) // Adjust the body as needed
                });

                if (response.ok) {
                    let result = await response.json();
                    updateIngredients();
                    showToast('Medicine added successfully', 'Success');
                } else {
                    console.error('Error:', response.statusText);
                    showToast('Failed to add medicine', 'Error');
                }
            } catch (error) {
                console.error('Fetch error:', error);
                showToast('Failed to add medicine', 'Error');
   ");
                WriteLiteral("         }\r\n        }\r\n        async function DetailMedicine(med) {\r\n            let id =");
#nullable restore
#line 260 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
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

        async function ReomveIngredient(med) {
            let id =");
#nullable restore
#line 285 "C:\Users\HASAN\Desktop\Medic\WebPresentation\Views\Medicine\Details.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            try {
               /// showToast('Loading ... ', 'Removing medicine');

                let response = await fetch(`/Medicine/ReomveIngredient`, {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({ MedicineId: id, IngredientId: med }) // Adjust the body as needed
                });

                if (response.ok) {
                    let result = await response.json();

                    updateIngredients();

                    showToast('Medicine Reomved successfully', 'Success');
                } else {
                    console.error('Error:', response.statusText);
                    showToast('Failed to remove medicine', 'Error');
                }
            } catch (error) {
                console.error('Fetch error:', error);
                showToast('Failed to remove medicine', 'Error');
            }
      ");
                WriteLiteral(@"  }

        async function DeleteConfirm(title, message, action, param) {
            debugger
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

                        <p class="" mb-5""> ${me");
                WriteLiteral(@"ssage}</p>

                        <hr class=""mt-2 mb-4""
                            style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">
                    <div class=""modal-footer d-flex justify-content-center border-top-0 py-4"">

                        <button class=""btn btn-danger"" onclick=""${action}(${param})"" data-dismiss=""modal"" aria-label=""Close"">Delete</button>

                        <button class=""btn btn-info"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">Close</button>
                    </div>
                </div>
            </div>
        </div>  `;
            // Show the modal
            const medicineModal = new bootstrap.Modal(document.getElementById('item'));
            medicineModal.show();

        }
        function showToast(message, title) {
            const Modal = new bootstrap.Modal(document.getElementById('item'));
            //    Modal.close();
            try {
                Modal.dispose();");
                WriteLiteral(@"
            } catch { }

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

                        <p class="" mb-5""> ${message}</p>

                        <hr class=""mt-2 mb-4""
          ");
                WriteLiteral(@"                  style=""height: 0; background-color: transparent; opacity: .75; border-top: 2px dashed #9e9e9e;"">
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
                                                    <td>${s[i].description}<");
                WriteLiteral(@"/td>
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
                    </div>
                    <div class=""modal-body text-start p-3"">
           ");
                WriteLiteral(@"             <h5 class=""modal-title text-uppercase mb-5"" id=""exampleModalLabel"">All Ingredients</h5>

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
                            style=""height: 0; background-color: transparent; opacity: .75; border-top");
                WriteLiteral(@": 2px dashed #9e9e9e;"">

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
