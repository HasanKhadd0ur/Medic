using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class MedicalStateApiController : BaseController
    {
        private readonly IPatientService _patientService;
        private readonly IMedicalStateService _Service;

        public MedicalStateApiController(
            IMedicalStateService medicineService,
             IPatientService patientService,
            UserManager<User> userManager)
            :base(userManager)
        {
            _patientService = patientService;
            _Service = medicineService;
        }

        public async Task<IActionResult> GetAll()
        {
            string u = GetUserId();
            var pId = _patientService.GetAll().Result.Where(p => p.User.Id == u).FirstOrDefault().Id;
            var meds = _Service.GetAllPatientMedicalStates(pId);

            return Ok(meds);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medicine = await _Service.GetDetails(id);
            if (medicine == null)
            {
                return NotFound();
            }
            return Ok(medicine);
        }
    }
}
