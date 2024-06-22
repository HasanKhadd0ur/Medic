using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{
    public class MedicalStateMedicineModel : DomainBase
     {


        public int MedicineId { get; set; }
        public int MedicalStateId { get; set; }

        #region Navigation
       // public MedicineModel Medicine { get; set; }
       // public MedicalStateModel MedicalState { get; set; }
        #endregion Navigation
    }
}
