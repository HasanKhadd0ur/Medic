using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class MedicalStateMedicineDTO : DTOBase
     {
        public int MedicineId { get; set; }
        public int MedicalStateId { get; set; }

    }
}
