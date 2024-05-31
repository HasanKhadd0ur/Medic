using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IIngredientService
    {
        public IEnumerable<Ingredient> GetAllIngredients();
        public void AddIngredient(Ingredient ingredient);
        public Ingredient Update(Ingredient ingredient);
        public Ingredient GetIngredientDetails(int id);
        public void Delete(int id);
    }
}
