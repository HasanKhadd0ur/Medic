using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.MedicineService;
using ApplicationCore.Services.PatientService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebPresentation.Models;

namespace WebPresentation.Controllers
{

    [Authorize]
    public class HomeController : BaseController
    {
        private readonly PatientService _patientService;
        private readonly MedicineService _medicineService;
        private readonly UserManager<User> _userManager;
        private readonly User _user;
        private readonly Patient _patient;

        public HomeController(UserManager<User> userManager,IUnitOfWork<Patient> patientUnitOfWork, IUnitOfWork<Medicine> medicineUnitOfWork):base(userManager)
        {
            _userManager = userManager;

            _patientService = new PatientService(patientUnitOfWork,medicineUnitOfWork);
            //   var userid = _userManager.GetUserAsync(User);
            _medicineService = new MedicineService(medicineUnitOfWork);
            _user = _userManager.Users.FirstOrDefault();
            _patient = _patientService.getAll(u => u.User, u => u.Medicines).Where(u => u.User.Id == _user.Id).FirstOrDefault();

        }

        public IActionResult Index()
        {
            var u = GetCurrentUser();
            var userId = GetUserId();
            
            var ownesr = _patientService.getAll(u=>u.User , u => u.Medicines).Where(u => u.User.Id == userId).FirstOrDefault();

            return View(ownesr);
        }

        public IActionResult MedicineDetails(int id ) {
            var s = _patientService.GetMedicineDetails(id, i => i.MedicineIngredients, i => i.Ingredients , i => i.Category );
            return View(s);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddMedicine(int id) {
            var userId = _userManager.GetUserId(User);

            var patient = _patientService.getAll(u => u.User, u => u.Medicines)
                .Where(u => u.User.Id ==userId ).FirstOrDefault();
            var m =_medicineService.GetMedicineDetails(id);
            _patientService.AddMedicine(patient.Id, m);
            
            return RedirectToAction("Index","Home");
                
        }
        public IActionResult MedicinesGalary() {

            return View(_medicineService.GetAllMedicines());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
