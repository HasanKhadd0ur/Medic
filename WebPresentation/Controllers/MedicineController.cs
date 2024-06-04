using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Services;

using ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    [Authorize(Roles ="Admin")]
    public class MedicineController : BaseController<Medicine>
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

        public IActionResult Index()
        {
            var s = new PatientMedicineViewModel
            {
                Patients = _patientService.GetAll(p=> p.User ),
                Medicines = _medicineService.GetAllMedicines()
            };

            return View(s);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Medicine medicine, int id)
        {
            if (ModelState.IsValid)
            {
                _medicineService.AddMedicine(medicine);
                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }


        public IActionResult AddIngredints(int id ) {
            var s = _ingredientService.GetAllIngredients();
            ViewBag.MedicineId = id;
            return View(s);
        
        }
        [HttpPost]
        public IActionResult AddIngredints(int id , int med ,int ratio )
        {
            var s = _ingredientService.GetDetails(id);
            _medicineService.AddIngredient(med, ratio, s);

            return RedirectToAction("Details","Medicine", new { Id = med}) ;
        }

    }
}
