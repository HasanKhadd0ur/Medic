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
   [Authorize(Roles = "Admin")]
    public class MedicineController : CRUDController<MedicineModel>
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
        public IActionResult AddIngredints(int id ) {
            var s = _ingredientService.GetAll().Result;
            ViewBag.MedicineId = id;
            return View(s);
        
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GetIngredints(int id)
        {
            var s = _ingredientService.GetAll().Result;
            ViewBag.MedicineId = id;
            return Ok(s);

        }
        [Authorize(Roles = "Admin")]
        public IActionResult ReomveIngredints(int id ,int ing )
        {
            _ingredientService.RemoveFromMedicine(new MedicineIngredientModel {IngredientId=ing , MedicineId=id });

            return Ok(new {message = "removed" });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddIngredintsT( MedicineIngredientModel medicineIngredientModel)
        {
            _ingredientService.AddToMedicine(medicineIngredientModel);
            return Ok(new { message = "added"});
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddIngredints(int id , int med ,int ratio )
        {
            _ingredientService.AddToMedicine(new MedicineIngredientModel {Id=id ,MedicineId=med ,Ratio=ratio });
            return RedirectToAction("Details","Medicine", new { Id = med}) ;
        }

        #region json 

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

        [Authorize(Roles = "patient")]
        [HttpPost]
        public JsonResult AddMedicineT(int id, int med)
        {
            try
            {
                ((IMedicineService)_service).AddToMedicalState(new MedicalStateMedicineModel { MedicalStateId = id, MedicineId = med });

                return Json("Added");
            }
            catch
            {

                return Json("faild");
            }
        }
        [Authorize(Roles = "patient")]

        [HttpPost]
        public JsonResult RemoveMedicineJ(int id, int med)
        {
            ((IMedicineService)_service).RemoveFromMedicalState(new MedicalStateMedicineModel { MedicalStateId = id, MedicineId = med });

            return Json("Reomved");
        }

        #endregion json 

    }
}
