using ApplicationCore.DTOs;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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
                var patient = _mapper.Map<Patient>(Input.Patient);
                var user = new User
                {
                    NormalizedEmail = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Avatar = Input.ImageName,
                    UserName = Input.Email,
                    Email = Input.Email,
                    Patient = patient,
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

        public override async Task<IActionResult> DeleteConfirmed(int id)
        {
            PatientDTO DetailDto = await _service.GetDetails(id);

            if (DetailDto == null || !criteria(DetailDto))
            {
                return PartialView("PartialNotFound");
            }
            var r =await _userManager.DeleteAsync(DetailDto.User);
            
            _service.Delete(id);

            return RedirectToAction("Index");
        }

    }
}
