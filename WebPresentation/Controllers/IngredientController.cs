using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebPresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IngredientController : BaseController<Ingredient>
    {
        private readonly IIngredientService _ingredientService;
        private readonly IMedicineService _medicineService;


        public IngredientController(UserManager<User> userManager,
            IMedicineService medicineService ,
            IIngredientService ingredientSercie
            ) : base(userManager,ingredientSercie)
        
        {
            _ingredientService =ingredientSercie;
            _medicineService = medicineService;
            
        }

        public IActionResult Index()
        {
            var s = _ingredientService.GetAllIngredients();
            return View(s);
        }


     
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ingredient ingredient, int id)
        {
            if (ModelState.IsValid)
            {
                _ingredientService.AddIngredient(ingredient);
                return RedirectToAction(nameof(Index));
            }
            return View(ingredient);
        }

        public IActionResult AddIngredints(int id)
        {
            var s = _ingredientService.GetAllIngredients();
            ViewBag.MedicineId = id;
            return View(s);

        }


        
    }
}
