using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
{
    public class PatientMedicinesSpecification : BaseSpecification<Patient>
    {
        public PatientMedicinesSpecification()
        {
            AddInclude(p => p.MedicalStates);
            AddInclude(p => p.User);
           
            AddThenInclude("MedicalStates.Medicines");
            
        }

    }
}
