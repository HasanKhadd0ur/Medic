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
    [Authorize]
    public class MedicalStateController : BaseController
    {
        private readonly IMedicalStateService _medicalStateService;
        private readonly IMedicineService _medicineService;
        private readonly IPatientService _patientService;

        public MedicalStateController(UserManager<User> userManager,
            IMedicalStateService medicalStateService ,
            IPatientService patientService ,
            IMedicineService medicineService 
            ) : base(userManager)
        {
            _medicalStateService = medicalStateService;
            _medicineService = medicineService;
            _patientService =patientService;

        }

        public IActionResult Index(int?  id )
        {
                var u = GetUserId();
                var pId = _patientService.GetAll().Where(p => p.User.Id == u).FirstOrDefault().Id;
                var meds = _medicalStateService.GetAllPatientMedicalStates(pId);
                return View(meds);
            
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicalStateService.GetDetails((int)id);

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
                _medicalStateService.Add(p,medicalState);
                return RedirectToAction("Details", "MedicalState", new { Id = id });
            }
            return View(medicalState);
        }

        // GET: Projects/Edit/5
        public IActionResult Edit(int? id)
        {

            var uId = GetUserId();

            var p = _patientService.GetAll(
                 )
                .Where(
                    u => u.User.Id == uId
                    )
                .FirstOrDefault();

            ViewBag.id = p.Id;
            if (id == null)
            {
                return NotFound();
            }

            var medicine = _medicalStateService.GetDetails((int)id);
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
        public IActionResult Edit(int id,int pId , MedicalState medicalState)
        {
            if (id != medicalState.Id)
            {

                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    medicalState.PatientId = pId;
                    // _patientService.UpdateMedicalState(p.Id, medicalState);
                   _medicalStateService.Update(medicalState );

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
                return RedirectToAction("Details","MedicalState",new { Id =id});
            }
            return View(medicalState);
        }

        // GET: Projects/Delete/5
        public IActionResult Delete(int id)
        {

            var project = _medicalStateService.GetDetails(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
        public IActionResult AddMedicine(int id)
        {
            var s = _medicineService.GetAllMedicines();
            ViewBag.MedicalStateId = id;
            return View(s);

        }
        [HttpPost]
        public IActionResult AddMedicine(int id, int med)
        {
            _medicalStateService.AddMedicine(id ,med);

            return RedirectToAction("Details", "MedicalState", new { Id = id });
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _medicalStateService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
