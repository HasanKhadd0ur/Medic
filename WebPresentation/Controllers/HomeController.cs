using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
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
    public class HomeController : Controller
    {
        private readonly PatientService _patientService;
        private readonly UserManager<User> _userManager;

        public HomeController(UserManager<User> userManager,IUnitOfWork<Patient> patientUnitOfWork, IUnitOfWork<Medicine> medicineUnitOfWork)
        {
            _userManager = userManager;
            _patientService = new PatientService(patientUnitOfWork,medicineUnitOfWork);
        }

        [Authorize]
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            //      var s = User.Claims.Where(u => u.Type == "UserName");
            var ownesr = _patientService.getAll(u=>u.User , u => u.Medicines).Where(u => u.User.Id == userId).FirstOrDefault();


            return View(ownesr);
        }

        public IActionResult MedicineDetails(int id ) {
            var s = _patientService.GetMedicineDetails(id);
            return View(s);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
