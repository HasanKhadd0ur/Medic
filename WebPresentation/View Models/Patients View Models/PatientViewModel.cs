using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public class PatientViewModel : BaseViewModel
    {


        public String  UserId { get; set; }
        public User User { get; set; }
        public String BIO { get; set; }

        #region Navigations
        public ICollection<MedicalStateViewModel> MedicalStates { get; set; }
        #endregion Navigations
    }
}
