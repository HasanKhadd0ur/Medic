using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DomainModel;

namespace WebPresentation.Controllers
{

    [Authorize(Roles = "patient")]
    public class MedicalStateController : CRUDController<MedicalStateModel>
    {
        private readonly IMedicalStateService _medicalStateService;
        private readonly IPatientService _patientService;
        private readonly IMedicineService _medicineService;


        public MedicalStateController(UserManager<User> userManager,
            IMedicalStateService medicalStateService ,
            IPatientService patientService ,
            IMedicineService medicineService
            ) : base(userManager,medicalStateService)
        {
            _medicalStateService = medicalStateService;
            _patientService =patientService;
            _medicineService = medicineService;
        }

        public async override Task<IActionResult> Index( )
        {
                var u = GetUserId();
            var p = await _patientService.GetAll();
                 var pId= p.Where(p => p.User.Id == u).FirstOrDefault().Id;
                var meds =await ((IMedicalStateService )_service).GetAllPatientMedicalStates(pId);
                return View(meds);
            
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public override IActionResult Create(MedicalStateModel medicalState, int id)
        {
            if (ModelState.IsValid)
            {
                var uId = GetUserId();
                var p = _patientService.GetByUserId(uId).Id;
                if (medicalState.PrescriptionTime == DateTime.MinValue )
                    medicalState.PrescriptionTime = DateTime.Now;
                var n= ((IMedicalStateService)_service).AddToPateint(p,medicalState);
                
                return RedirectToAction("Details", "MedicalState" , new { Id =n.Id });
            }
            return View(medicalState);
        }


        //[HttpGet]
        //public IActionResult AddMedicine(int id)
        //{
        //    var all =  _medicineService.GetAll();
        //    ViewBag.MedicalStateId = id;
        //    return View(all);
        //}
        //[HttpPost]
        //[ActionName("AddMedicine")]
        //public IActionResult AddMedicineT(int id, int med)
        //{
        //   _medicineService.AddToMedicalState(new MedicalStateMedicineModel{MedicalStateId=id ,MedicineId=med });

        //    return RedirectToAction("Details", "MedicalState", new { Id = id });
        //}


        //[ActionName("RemoveMedicine")]
        //public IActionResult RemoveMedicinej(int id, int med)
        //{
        //    _medicineService.RemoveFromMedicalState(new MedicalStateMedicineModel { MedicalStateId = id, MedicineId = med });

        //    return RedirectToAction("Details", "MedicalState", new { Id = id });
        //}

        #region json 

        [HttpGet]
        public JsonResult GetMedicalStateMedicine(int id) {

            var r =  _medicalStateService.GetDetails(id).Result.Medicines;
            return Json(r);
        }

        [HttpPost]

        public JsonResult AddMedicine([FromBody]MedicalStateMedicineModel medicalStateMedicineModel)
        {
            try
            {
                _medicineService.AddToMedicalState(medicalStateMedicineModel);

                return Json("Added");
            }
            catch
            {

                return Json("faild");
            }
        }

        [HttpPost]
        public JsonResult RemoveMedicine([FromBody]MedicalStateMedicineModel medicalStateMedicineModel)
        {
            _medicineService.RemoveFromMedicalState(medicalStateMedicineModel);

            return Json("Reomved");
        }

        [Authorize(Roles = "patient")]
        public async Task<JsonResult> GetDetails(int? id)
        {

            if (id is null)
            {
                return Json("");
            }
            else
            {
                MedicineModel TModel = await _medicineService.GetDetails((int)id);
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

       

        #endregion json
    }
}
