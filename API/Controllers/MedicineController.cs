using ApplicationCore.DTOs;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
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
    public class MedicineController : CrudController<MedicineDTO>
    {
        public MedicineController(
            IMedicineService medicalstateService,
            UserManager<User> userManager)
            : base(medicalstateService, userManager)
        {

        }

        [HttpPost("AddMedicineT")]
        public IActionResult AddMedicineT(int id, int med)
        {
            try
            {
                ((IMedicineService)_service).AddToMedicalState(new MedicalStateMedicineDTO { MedicalStateId = id, MedicineId = med });

                return Ok(new {message= "Added"});
            }
            catch
            {

                return NotFound(new { message = "faild" });
            }
        }

        [HttpPost("RemoveMedicineJ")]
        public IActionResult RemoveMedicineJ(int id, int med)
        {
            ((IMedicineService)_service).RemoveFromMedicalState(new MedicalStateMedicineDTO { MedicalStateId = id, MedicineId = med });

            return Ok(new { message = "REmoved" });
        }



    }
}
