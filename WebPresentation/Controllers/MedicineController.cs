using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DomainModel;

namespace WebPresentation.Controllers
{
    public class MedicineController : BaseController<MedicineModel>
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMedicineService _medicineService;
        private readonly IPatientService _patientService;

        public MedicineController(UserManager<User> userManager,
            IMedicineService medicineService ,
            IIngredientService ingredientService ,
            IPatientService patientService

            ):base(userManager ,medicineService)
        {
            _ingredientService =ingredientService;
            _medicineService = medicineService;
            _patientService =patientService;

        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var s = _medicineService.GetAll().Result;
            

            return View(s);
        }

        [Authorize(Roles = "Admin")]
        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MedicineModel medicine, int id)
        {
            if (ModelState.IsValid)
            {

               var m = _medicineService.Create(medicine);
                return RedirectToAction("Details","Medicine",new { Id = m.Id});
            }
            return View(medicine);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AddIngredints(int id ) {
            var s = _ingredientService.GetAll().Result;
            ViewBag.MedicineId = id;
            return View(s);
        
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddIngredints(int id , int med ,int ratio )
        {
            _ingredientService.AddToMedicine(id,med,ratio);
            return RedirectToAction("Details","Medicine", new { Id = med}) ;
        }
        [Authorize(Roles ="patient")]
        public async Task<JsonResult>  GetDetails(int? id)
        {

            if (id is null)
            {
                return  Json("");
            }
            else
            {
                MedicineModel TModel = await _service.GetDetails((int)id);
                if (TModel is null)
                    return Json("");
                return Json(TModel);
            }
        }

        [Authorize(Roles = "patient")]
        [HttpGet]
        public JsonResult GetMedicines()
        {
            var all = _medicineService.GetAll().Result;

            return new JsonResult(all);

        }

    }
}
