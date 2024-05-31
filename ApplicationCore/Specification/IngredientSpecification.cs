using ApplicationCore.Entities;
using ApplicationCore.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specification
{
    public class IngredientSpecification : BaseSpecification<Ingredient>
    {

        public IngredientSpecification()

        {
            AddInclude(p => p.MedicineIngredients);
            AddInclude(p => p.Medicines);
            

        }

    
    }
}
