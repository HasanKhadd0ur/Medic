using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{
    public class PatientModel : DomainBase
    {


        public String  UserId { get; set; }
        public User User { get; set; }
        public String BIO { get; set; }

        #region Relations
        public ICollection<MedicalStateModel> MedicalStates { get; set; }
        //public ICollection<Medicine> Medicines { get; set; }
       // public ICollection<PatientMedicine> PatientMedicines { get; set; }
        #endregion Relations
    }
}
