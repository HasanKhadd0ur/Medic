﻿using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.DTOs;
using System.Threading.Tasks;
using WebPresentation.ViewModels;
using AutoMapper;

namespace WebPresentation.Controllers
{
   [Authorize(Roles = "Admin")]
    public class MedicineController : CRUDController<MedicineDTO,MedicineViewModel>
    {
        private readonly IIngredientService _ingredientService;
        
        public MedicineController(
            UserManager<User> userManager,
            IMedicineService medicineService ,
            IIngredientService ingredientService,
            IMapper mapper
            
            ):base(userManager ,medicineService,mapper)
        {
            _ingredientService =ingredientService;
        }



        #region json 

        [HttpPost]
        public async  Task<IActionResult> ReomveIngredient([FromBody] MedicineIngredientDTO medicineIngredientModel)
        {
             await _ingredientService.RemoveFromMedicine(medicineIngredientModel);

            return Ok(new {message = "removed" ,result ="Successed"});
        }

        [HttpPost]
        public async Task<IActionResult> AddIngredient([FromBody] MedicineIngredientDTO medicineIngredientModel)
        {
            await _ingredientService.AddToMedicine(medicineIngredientModel);
            return Ok(new { message = "added", result = "Successed" });
        }
        public async Task<IActionResult> GetMedcineIngredient(int id) {

            var r = await ((IMedicineService)_service).GetMedicineIngredients(id);

            return Ok(new { message = "removed", result = r });

        }
        #endregion json 

    }
}
