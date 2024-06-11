using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{ 
    public class MedicalStateViewModel : BaseViewModel
    {
        public int PatientId { get; set; }
        public PatientViewModel Patient { get; set; }
        public String StateName { get; set; }
        public String StateDescription { get; set; }
        public DateTime PrescriptionTime { get; set; }
        public ICollection<MedicineViewModel> Medicines { get; set; }
       
    }
}
