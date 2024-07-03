using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using WebPresentation.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using ApplicationDomain.Exceptions;
using WebPresentation.Filters.ImageLoad;
using WebPresentation.Filters.ModelStateValidation;

namespace WebPresentation.Controllers
{

    [Authorize(Roles = "patient")]
    public class MedicalStateController : CRUDController<MedicalStateDTO,MedicalStateViewModel>
    {
        private readonly IMedicalStateService _medicalStateService;
        private readonly IPatientService _patientService;
        private readonly IMedicineService _medicineService;


        public MedicalStateController(UserManager<User> userManager,
            IMedicalStateService medicalStateService ,
            IPatientService patientService ,
            IMedicineService medicineService,
            IMapper mapper
            ) : base(userManager,medicalStateService,mapper)
        {
            _medicalStateService = medicalStateService;
            _patientService =patientService;
            _medicineService = medicineService;
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [StateValidationFilter]
        [ImageLoadFilter]
        public override IActionResult Create(MedicalStateViewModel medicalState, int id)
        {
            if (ModelState.IsValid)
            {
                var uId = GetUserId();
                var patientId = _patientService.GetByUserId(uId).Result.Id;
                if (medicalState.PrescriptionTime == DateTime.MinValue )
                    medicalState.PrescriptionTime = DateTime.Now;

                var n= ((IMedicalStateService)_service)
                            .AddToPateint(patientId, _mapper.Map<MedicalStateDTO>(medicalState));

                return Json(new { success = true, redirectUrl = Url.Action("Details", new { id = medicalState.Id }) });
            }
            return PartialView(medicalState);
        }

        #region json 

        [HttpGet]
        public async Task<IActionResult> GetMedicalStateMedicine(int id) {

            var all = await _medicalStateService.GetDetails(id);
            return Ok(new { message = "Succed", result = all.Medicines });
        }

        [HttpPost]

        public async Task<IActionResult> AddMedicine([FromBody]MedicalStateMedicineVModel medicalStateMedicine)
        {
            try
            {
                var medical = await _medicalStateService.GetDetails(medicalStateMedicine.MedicalStateId);
                if(!criteria(medical))
                    return Ok(new { message = "You try to add a medicine for other patient and this is wrong , you shouldn't add a medicine for others", result = "faild" });

                var medicalStateMedicineModel = _mapper.Map<MedicalStateMedicineDTO>(medicalStateMedicine);
                _medicineService.AddToMedicalState(medicalStateMedicineModel);

                return Ok(new { message = "The medicine Added Successfully", result = "add" }); 
            }
            catch(DomainException e )
            {

                return Ok(new { message = e.Message, result = "faild" });
            }

            catch
            {

                return Ok(new { message = "Some thing went wrong", result = "faild" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveMedicine([FromBody]MedicalStateMedicineVModel medicalStateMedicine)
        {
            MedicalStateMedicineDTO medicalStateMedicineModel = _mapper.Map<MedicalStateMedicineDTO>(medicalStateMedicine);
            try
            {
                var medical = await _medicalStateService.GetDetails(medicalStateMedicine.MedicalStateId);
                if (!criteria(medical))
                    return Ok(new { message = "You try to Reomve a medicine for other patient and this is wrong , you shouldn't remove a medicine for others maybe this kill him", result = "faild" });

                _medicineService.RemoveFromMedicalState(medicalStateMedicineModel);

                return Ok(new { message = "the medicine reomved Successfully", result = "removed" });

            }


            catch (DomainException e)
            {

                return Ok(new { message = e.Message, result = "faild" });
            }

            catch
            {

                return Ok(new { message = "something went wrong", result = "faild" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetALLMedicines()
        {
            var all = await _medicineService.GetAll();

            return Ok(new { message = "Succed", result = all });

        }
        public async Task<IActionResult> GetMedicineDetails(int? id )
        {
            if (id is null )
                return Ok(new { message = "No ID Provided", result = "Faild" });

            var all = await _medicineService.GetDetails((int)id);
            if(all is null )
                return NotFound(new { message = "No Data Found", result = "Faild" });

            return Ok(new { message = "Succed", result = all });

        }

        #endregion json
        protected override Func<MedicalStateDTO, bool> GetCriteria()
        {

            var u = _patientService.GetByUserId(GetUserId()).Result.Id;
            return p => p.PatientId == u; ;
        }

    }
}
