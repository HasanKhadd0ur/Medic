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
        [Required]
        [MinLength(5)]
        public String StateName { get; set; }
        [Display(Name = "State Name")]
        [Required]
        public String StateDescription { get; set; }

        [Display(Name = "State Name")]
        [Required]
        public DateTime PrescriptionTime { get; set; }
        public ICollection<MedicineViewModel> Medicines { get; set; }
       
    }
}
