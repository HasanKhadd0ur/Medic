using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities 
{ 
    public class MedicalState : EntityBase
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public String StateName { get; set; }
        public String StateDescription { get; set; }
        public DateTime PrescriptionTime { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<MedicalStateMedicine> MedicalStateMedicines { get; set; }

    }
}
