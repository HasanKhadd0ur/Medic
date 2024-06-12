﻿using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
{
    public class MedicineIngredientSpecification : BaseSpecification<Medicine>
    {

        public MedicineIngredientSpecification( )
               
        {
            AddInclude(p => p.MedicineIngredients);
            AddInclude(p => p.Category);
            AddInclude(p => p.MedicineType);
            AddInclude(p => p.MedicalStates);
            AddInclude(p => p.Ingredients);

            AddThenInclude("MedicineIngredients.Ingredient");
            

        }
    }
}