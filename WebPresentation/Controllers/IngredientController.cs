using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.IngredientService;
using ApplicationCore.Services.MedicineService;
using ApplicationCore.Services.PatientService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    public class IngredientController : BaseController
    {
        private readonly IngredientService _ingredientService;
        private readonly MedicineService _medicineService;


        public IngredientController(UserManager<User> userManager,
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IUnitOfWork<Ingredient> ingredientUnitOfWork) : base(userManager)
        {
            _ingredientService = new IngredientService(ingredientUnitOfWork);
            _medicineService = new MedicineService(medicineUnitOfWork);
            
        }

        public IActionResult Index()
        {
            var s = _ingredientService.GetAllIngredients();
            return View(s);
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = _ingredientService.GetIngredientDetails((int)id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return View(ingredient);
        }

        // GET: Projects/Create
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

        // GET: Projects/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingredient = _ingredientService.GetIngredientDetails((int)id);
            if (ingredient == null)
            {
                return NotFound();
            }
            return View(ingredient);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Ingredient ingredient)
        {
            if (id != ingredient.Id)
            {

                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ingredientService.Update(ingredient);

                }
                catch (DbUpdateConcurrencyException)
                {/*
                    if (!_medicineService.projectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                */
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ingredient);
        }

        // GET: Projects/Delete/5
        public IActionResult Delete(int id)
        {

            var ingredient = _ingredientService.GetIngredientDetails(id);

            if (ingredient == null)
            {
                return NotFound();
            }

            return View(ingredient);
        }
        public IActionResult AddIngredints(int id)
        {
            var s = _ingredientService.GetAllIngredients();
            ViewBag.MedicineId = id;
            return View(s);

        }


        
        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _ingredientService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
