﻿using ApplicationCore.Entities;
using ApplicationCore.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specification
{
    class MedicalStateSpecification : BaseSpecification<MedicalState>
    {

        public MedicalStateSpecification()

        {
            AddInclude(p => p.MedicalStateMedicines);
            AddInclude(p => p.Medicines);
            AddInclude(p => p.Patient);
            
            AddThenInclude("MedicalStateMedicines.Medicine");


        }
    }
    {
    }
}