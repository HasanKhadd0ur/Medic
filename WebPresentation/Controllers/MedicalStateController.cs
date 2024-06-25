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

        public async override Task<IActionResult> Index( )
        {
            
            var u = GetUserId();
            var p = await _patientService.GetByUserId(u);
            var pId= p.Id;
            var meds =await ((IMedicalStateService )_service).GetAllPatientMedicalStates(pId);
                
            return View(_mapper.Map<IEnumerable<MedicalStateViewModel>>(meds));
            
        }


        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public override IActionResult Create(MedicalStateViewModel medicalState, int id)
        {
            if (ModelState.IsValid)
            {
                var uId = GetUserId();
                var p = _patientService.GetByUserId(uId).Id;
                if (medicalState.PrescriptionTime == DateTime.MinValue )
                    medicalState.PrescriptionTime = DateTime.Now;
                var n= ((IMedicalStateService)_service).AddToPateint(p,_mapper.Map<MedicalStateDTO>(medicalState));
                
                return RedirectToAction("Details", "MedicalState" , new { Id =n.Id });
            }
            return View(medicalState);
        }

        
        #region json 

        [HttpGet]
        public async Task<IActionResult> GetMedicalStateMedicine(int id) {

            var all = await _medicalStateService.GetDetails(id);
            return Ok(new { message = "Succed", result = all.Medicines });
        }

        [HttpPost]

        public IActionResult AddMedicine([FromBody]MedicalStateMedicineVModel medicalStateMedicine)
        {
            try
            {
                var medicalStateMedicineModel = _mapper.Map<MedicalStateMedicineDTO>(medicalStateMedicine);
                _medicineService.AddToMedicalState(medicalStateMedicineModel);

                return Ok(new { message = "Succed", result = "add" }); 
            }
            catch(DomainException e )
            {

                return NotFound(new { message = e.Message, result = "faild" });
            }

            catch
            {

                return NotFound(new { message = "Error ", result = "faild" });
            }
        }

        [HttpPost]
        public IActionResult RemoveMedicine([FromBody]MedicalStateMedicineVModel medicalStateMedicine)
        {
            MedicalStateMedicineDTO medicalStateMedicineModel = _mapper.Map<MedicalStateMedicineDTO>(medicalStateMedicine);
            try
            {
                _medicineService.RemoveFromMedicalState(medicalStateMedicineModel);

                return Ok(new { message = "Succed", result = "removed" });

            }


            catch (DomainException e)
            {

                return NotFound(new { message = e.Message, result = "faild" });
            }

            catch
            {

                return NotFound(new { message = "Error ", result = "faild" });
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
    }
}
