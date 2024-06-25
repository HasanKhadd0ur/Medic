using ApplicationCore.DTOs;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using WebPresentation.ViewModel.Identity;
using WebPresentation.ViewModels;

namespace WebPresentation.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PatientsController : CRUDController<PatientDTO,PatientViewModel>
    {


        public PatientsController(
            UserManager<User> userManager,
            IPatientService patientService,
            IMapper mapper
            ) : base(userManager, patientService,mapper)
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
