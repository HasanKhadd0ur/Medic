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
using ApplicationCore.DomainModel;

namespace WebPresentation.Controllers
{

[Authorize(Roles ="patient")]
    public class HomeController : BaseController
    {
        private readonly IPatientService _patientService;
        
        public HomeController(
                UserManager<User> userManager,
                IPatientService patientService
            ):base(userManager)
        {
            _patientService = patientService;
            
        }

        private PatientModel _getCurrentPatient() {
            var u = GetCurrentUser();
            var userId = GetUserId();

            var patient = _patientService
                .GetAll(
                 ).Result
                .Where(
                    u => u.User.Id == userId
                    )
                .FirstOrDefault();
            return patient;

        }
        public IActionResult Index()
        {

            return View(_getCurrentPatient());
        }


        public   IActionResult Details(int? id ) {

            return View(_getCurrentPatient());
        
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
