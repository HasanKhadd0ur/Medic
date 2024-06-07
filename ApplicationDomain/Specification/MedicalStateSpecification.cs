using ApplicationDomain.Entities;
using ApplicationDomain.Specification.BaseSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Specification
{
    public class MedicalStateSpecification : BaseSpecification<MedicalState>
    {

        public MedicalStateSpecification()

        {
            AddInclude(p => p.MedicalStateMedicines);
            AddInclude(p => p.Medicines);
            AddInclude(p => p.Patient);

            AddThenInclude("MedicalStateMedicines.Medicine");
            AddThenInclude("Medicines.Category");
            AddThenInclude("Medicines.MedicineType");


        }
    }
   
    
}
