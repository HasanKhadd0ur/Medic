using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MedicalStateMedicine : EntityBase
    {
        public int MedicineId { get; set; }
        public int MedicalStateId { get; set; }

        #region Navigation
        public Medicine Medicine { get; set; }
        public MedicalState MedicalState { get; set; }
        #endregion Navigation
    }
}
