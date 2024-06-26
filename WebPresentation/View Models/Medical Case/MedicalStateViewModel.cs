using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{ 
    public class MedicalStateViewModel : BaseViewModel
    {
        public int PatientId { get; set; }
        public PatientViewModel Patient { get; set; }

        [Display(Name ="State Name")]
        public String StateName { get; set; }
        public String StateDescription { get; set; }
        public DateTime PrescriptionTime { get; set; }
        public ICollection<MedicineViewModel> Medicines { get; set; }
       
    }
}
