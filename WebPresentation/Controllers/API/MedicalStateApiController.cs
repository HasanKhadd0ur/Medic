using ApplicationCore.DomainModel;
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
    public class MedicalStateApiController : CrudAPIController<MedicalStateModel>
    {
        private readonly IPatientService _patientService;
        
        public MedicalStateApiController(
            IMedicalStateService medicalstateService,
             IPatientService patientService,
            UserManager<User> userManager)
            :base(medicalstateService, userManager)
        {
            _patientService = patientService;
        }

        public  override async Task<IActionResult> GetAll()
        {
            string u = GetUserId();
            var ps = await _patientService.GetAll();
            var pId=ps.Where(p => p.User.Id == u).FirstOrDefault().Id;
            var meds = ((IMedicalStateService)_service).GetAllPatientMedicalStates(pId);

            return Ok(meds);
        }

        [HttpGet("GetMedicines")]
        public  async Task<JsonResult> GetMedicalStateMedicine(int id)
        {

            var r = await ((IMedicalStateService)_service).GetDetails(id);
            return Json(r.Medicines);
        }



    }
}
