using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPresentation.ViewModel.Identity;

namespace WebPresentation.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PatientsController : CRUDController<PatientModel>
    {


        public PatientsController(UserManager<User> userManager,
            IPatientService patientService
            ) : base(userManager, patientService)
        {

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
