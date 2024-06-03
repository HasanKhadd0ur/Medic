using ApplicationDomain.Entities;
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
using ApplicationCore.Interfaces.IServices;

namespace WebPresentation.Controllers
{

[Authorize(Roles ="patient")]
    public class HomeController : BaseController
    {
        private readonly IPatientService _patientService;
        private readonly IMedicineService _medicineService;

        private readonly UserManager<User> _userManager;
        
        public HomeController(
                UserManager<User> userManager,
                IPatientService patientService,
                IMedicineService medicineService
            ):base(userManager)
        {
            _userManager = userManager;
            _medicineService = medicineService;
            _patientService = patientService;
            
        }

        public IActionResult Index()
        {
            var u = GetCurrentUser();
            var userId = GetUserId();
            
            var ownesr = _patientService
                .GetAll(
                 )
                .Where(
                    u => u.User.Id == userId
                    )
                .FirstOrDefault();

            return View(ownesr);
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
