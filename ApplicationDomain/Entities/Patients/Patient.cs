using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class Patient : EntityBase
    {


        public String  UserId { get; set; }
        public User User { get; set; }
        public String BIO { get; set; }

        #region manage 
        public void AddMedicalState(MedicalState medicalState) {

            MedicalStates.Add(medicalState);
        }

        #endregion manage

        #region Navigations
        public ICollection<MedicalState> MedicalStates { get; set; }
     
        #endregion Navigations
    }
}
