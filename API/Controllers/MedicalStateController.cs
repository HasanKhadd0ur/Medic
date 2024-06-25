using ApplicationCore.DTOs;
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

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class MedicalStateController : CrudController<MedicalStateDTO>
    {
        private readonly IPatientService _patientService;
        
        public MedicalStateController(
            IMedicalStateService medicalstateService,
             IPatientService patientService,
            UserManager<User> userManager)
            :base(medicalstateService, userManager)
        {
            _patientService = patientService;
        }

        public  override async Task<IActionResult> GetAll()
        {
            var ps = await _patientService.GetByUserEmail(GetUserEmail());
            var pId=ps.Id;
            var meds = await ((IMedicalStateService)_service).GetAllPatientMedicalStates(pId);

            return Ok(meds);
        }

        [HttpGet("GetMedicines")]
        public  async Task<IActionResult> GetMedicalStateMedicine(int id)
        {

            var r = await ((IMedicalStateService)_service).GetDetails(id);
            return Ok(r.Medicines);
        }



    }
}
