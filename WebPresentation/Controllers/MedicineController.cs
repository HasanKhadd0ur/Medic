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
    public class MedicineController : BaseController
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMedicineService _medicineService;
        private readonly IPatientService _patientService;

        public MedicineController(UserManager<User> userManager,
            IMedicineService medicineService ,
            IIngredientService ingredientService ,
            IPatientService patientService

            ):base(userManager)
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicineService.GetMedicineDetails((int)id);

            if (medicine == null)
            {
                return NotFound();
            }

            return View(medicine);
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

        // GET: Projects/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicineService.GetMedicineDetails((int)id);
            if (medicine == null)
            {
                return NotFound();
            }
            return View(medicine);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Edit(int id,Medicine medicine)
        {
            if (id != medicine.Id)
            {
                
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _medicineService.Update(medicine);

                }
                catch (DbUpdateConcurrencyException)
                {/*
                    if (!_medicineService.projectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                */
                }
                return RedirectToAction(nameof(Index));
            }
            return View(medicine);
        }

        // GET: Projects/Delete/5
        public IActionResult Delete(int id)
        {

            var project = _medicineService.GetMedicineDetails(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
        public IActionResult AddIngredints(int id ) {
            var s = _ingredientService.GetAllIngredients();
            ViewBag.MedicineId = id;
            return View(s);
        
        }
        [HttpPost]
        public IActionResult AddIngredints(int id , int med ,int ratio )
        {
            var s = _ingredientService.GetIngredientDetails(id);
            _medicineService.AddIngredient(med, ratio, s);

            return RedirectToAction("Details","Medicine", new { Id = med}) ;
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _medicineService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
