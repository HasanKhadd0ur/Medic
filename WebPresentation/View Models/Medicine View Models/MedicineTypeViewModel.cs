using System;
using System.ComponentModel.DataAnnotations;

namespace WebPresentation.ViewModels
{
    public class MedicineTypeViewModel : BaseViewModel
    {
        [Display(Name = "Medicine Type ")]
        public String TypeName { get; set; }
    }
}