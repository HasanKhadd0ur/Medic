using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.IngredientService
{
    public class IngredientService
    {
        private readonly IUnitOfWork<Ingredient> _ingredientUnitOfWork;

        public IngredientService(IUnitOfWork<Ingredient> ingredientUnitOfWork)
        {
            _ingredientUnitOfWork = ingredientUnitOfWork;
        }
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _ingredientUnitOfWork.Entity.GetAll(
                p=>p.MedicineIngredients 
                 );
        }
        public void AddIngredient(Ingredient ingredient)
        {

            _ingredientUnitOfWork.Entity.Insert(ingredient);
            _ingredientUnitOfWork.Save();

        }
        public Ingredient Update(Ingredient ingredient)
        {

            var r = _ingredientUnitOfWork.Entity.Update(ingredient);
            _ingredientUnitOfWork.Save();
            return r;
        }

        public Ingredient GetIngredientDetails(int id)
        {

            return _ingredientUnitOfWork.Entity.GetById(id, 
                i => i.MedicineIngredients,
                i => i.Medicines
                );

        }
        public void Delete(int id)
        {
            _ingredientUnitOfWork.Entity.Delete(id);
            _ingredientUnitOfWork.Save();
        }

    }
}
