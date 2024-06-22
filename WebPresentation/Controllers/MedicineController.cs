using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.DomainModel;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
   [Authorize(Roles = "Admin")]
    public class MedicineController : CRUDController<MedicineModel>
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMedicineService _medicineService;
        private readonly IPatientService _patientService;

        public MedicineController(UserManager<User> userManager,
            IMedicineService medicineService ,
            IIngredientService ingredientService ,
            IPatientService patientService

            ):base(userManager ,medicineService)
        {
            _ingredientService =ingredientService;
            _medicineService = medicineService;
            _patientService =patientService;

        }




        [Authorize(Roles = "Admin")]
        [HttpPost]
        public  IActionResult ReomveIngredient([FromBody] MedicineIngredientModel medicineIngredientModel)
        {
             _ingredientService.RemoveFromMedicine(medicineIngredientModel);

            return Ok(new {message = "removed" });
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddIngredints([FromBody] MedicineIngredientModel medicineIngredientModel)
        {
            await _ingredientService.AddToMedicine(medicineIngredientModel);
            return Ok(new { message = "added"});
        }



        #region json 

        //[Authorize(Roles = "Admin")]
        //public IActionResult AddIngredints(int id)
        //{
        //    var s = _ingredientService.GetAll().Result;
        //    ViewBag.MedicineId = id;
        //    return View(s);

        //}
        //[Authorize(Roles = "Admin")]
        //[HttpPost]
        //public IActionResult AddIngredints(int id, int med, int ratio)
        //{
        //    _ingredientService.AddToMedicine(new MedicineIngredientModel { Id = id, MedicineId = med, Ratio = ratio });
        //    return RedirectToAction("Details", "Medicine", new { Id = med });
        //}

        #endregion json 

    }
}
