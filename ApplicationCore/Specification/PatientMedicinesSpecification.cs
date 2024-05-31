using ApplicationCore.Entities;
using ApplicationCore.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specification
{
    public class PatientMedicinesSpecification : BaseSpecification<Patient>
    {
        public PatientMedicinesSpecification()
        {
            AddInclude(p => p.Medicines);
            AddInclude(p => p.User);
            AddInclude(p=> p.PatientMedicines);
            
        }

    }
}
