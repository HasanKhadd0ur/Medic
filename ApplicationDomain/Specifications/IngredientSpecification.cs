using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
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
