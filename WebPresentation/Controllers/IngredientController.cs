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
using ApplicationCore.DomainModel;

namespace WebPresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IngredientController : BaseController<IngredientModel>
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(UserManager<User> userManager,
            IIngredientService ingredientSercie
            ) : base(userManager,ingredientSercie)
        
        {
            _ingredientService =ingredientSercie;
            
        }

        public IActionResult Index()
        {
            var s = _ingredientService.GetAllIngredients().Result;
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
        public IActionResult Create(IngredientModel ingredient, int id)
        {
            if (ModelState.IsValid)
            {

                _ingredientService.Create(ingredient);
                return RedirectToAction(nameof(Index));
            }
            return View(ingredient);
        }



        
    }
}
