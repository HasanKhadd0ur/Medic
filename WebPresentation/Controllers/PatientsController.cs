using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPresentation.ViewModel.Identity;

namespace WebPresentation.Controllers
{
    public class PatientsController : BaseController<PatientModel>
    {
        private readonly IMedicalStateService _medicalStateService;
        private readonly IPatientService _patientService;
        private readonly IMedicineService _medicineService;
        private readonly SignInManager<User> _signInManager;


        public PatientsController(UserManager<User> userManager,
            IMedicalStateService medicalStateService,
            IPatientService patientService,
            IMedicineService medicineService,
            SignInManager<User> signInManager
            ) : base(userManager, patientService)
        {
            _signInManager = signInManager;
            _medicalStateService = medicalStateService;
            _patientService = patientService;
            _medicineService = medicineService;
        }

        public IActionResult Index()
        {
            var patiens = ((IPatientService)_service).GetAll().Result;
            return View(patiens);

        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RegisterationInputModel Input, int id)
        {
            if (ModelState.IsValid)
            {
                    var user = new User
                    {
                        NormalizedEmail = Input.Email,
                        FirstName = Input.FirstName,
                        LastName = Input.LastName,
                        Avatar = Input.Avatar,
                        UserName = Input.Email,
                        Email = Input.Email,
                        Patient = Input.Patient,
                        CreationTime = DateTime.Now,

                    };

                    var result  =_userManager.CreateAsync(user, Input.Password).Result;

                    if (result.Succeeded) {
                        return RedirectToAction("Index", "Patients");

                    }
                    else return View(Input);


                }
                return View(Input);
        }


    }
}
