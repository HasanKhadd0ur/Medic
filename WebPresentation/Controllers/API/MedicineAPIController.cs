using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
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
    public class MedicineAPIController : CrudAPIController<MedicineModel>
    {
        public MedicineAPIController(
            IMedicineService medicalstateService,
            UserManager<User> userManager)
            : base(medicalstateService, userManager)
        {

        }

        [HttpPost("AddMedicineT")]
        public JsonResult AddMedicineT(int id, int med)
        {
            try
            {
                ((IMedicineService)_service).AddToMedicalState(new MedicalStateMedicineModel { MedicalStateId = id, MedicineId = med });

                return Json("Added");
            }
            catch
            {

                return Json("faild");
            }
        }

        [HttpPost("RemoveMedicineJ")]
        public JsonResult RemoveMedicineJ(int id, int med)
        {
            ((IMedicineService)_service).RemoveFromMedicalState(new MedicalStateMedicineModel { MedicalStateId = id, MedicineId = med });

            return Json("Reomved");
        }



    }
}
