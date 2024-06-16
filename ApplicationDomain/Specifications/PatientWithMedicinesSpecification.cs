using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
{
    public class PatientWithMedicinesSpecification : BaseSpecification<Patient>
    {
        public PatientWithMedicinesSpecification()
        {
            AddInclude(p => p.MedicalStates);
            AddInclude(p => p.User);
           
            AddThenInclude("MedicalStates.Medicines");
            
        }

    }
}
