using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{ 
    public class MedicalStateModel : DomainBase
    {
        public int PatientId { get; set; }
       // public PatientModel Patient { get; set; }
        public String StateName { get; set; }
        public String StateDescription { get; set; }
        public DateTime PrescriptionTime { get; set; }
        public ICollection<MedicineModel> Medicines { get; set; }
       // public ICollection<MedicalStateMedicineModel> MedicalStateMedicines { get; set; }

    }
}
