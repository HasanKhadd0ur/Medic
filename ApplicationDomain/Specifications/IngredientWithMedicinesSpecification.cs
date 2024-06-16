using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
{
    public class IngredientWithMedicinesSpecification : BaseSpecification<Ingredient>
    {

        public IngredientWithMedicinesSpecification()

        {
            AddInclude(p => p.MedicineIngredients);
            AddInclude(p => p.Medicines);
            

        }

    
    }
}
