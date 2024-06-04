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

namespace WebPresentation.Controllers
{

    [Authorize(Roles = "patient")]
    public class MedicalStateController : BaseController<MedicalState>
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

        public IActionResult Index( )
        {
                var u = GetUserId();
                var pId = _patientService.GetAll().Where(p => p.User.Id == u).FirstOrDefault().Id;
                var meds = _medicalStateService.GetAllPatientMedicalStates(pId);
                return View(meds);
            
        }


        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MedicalState medicalState, int id)
        {
            if (ModelState.IsValid)
            {
                var uId = GetUserId();
                var p = _patientService.GetAll(
                     )
                    .Where(
                        u => u.User.Id == uId
                        )
                    .FirstOrDefault().Id;
                if (medicalState.PrescriptionTime == DateTime.MinValue )
                    medicalState.PrescriptionTime = DateTime.Now;
                var n= _medicalStateService.Add(p,medicalState);
                return RedirectToAction("Details", "MedicalState", new { Id = n.Id });
            }
            return View(medicalState);
        }

        [HttpGet]
        public IActionResult AddMedicine(int id)
        {
            var all =  _medicineService.GetAllMedicines();
            ViewBag.MedicalStateId = id;
            return View(all);
        }

        [HttpPost]
        public IActionResult AddMedicine(int id, int med)
        {
            _medicalStateService.AddMedicine(id ,med);

            return RedirectToAction("Details", "MedicalState", new { Id = id });
        }
        [HttpPost]
        public IActionResult RemoveMedicine(int id, int med)
        {
            _medicalStateService.RemoveMedicine(id, med);

            return RedirectToAction("Details", "MedicalState", new { Id = id });
        }

    }
}
