using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{ 
    public class MedicalStateDTO : DTOBase
    {
        public int PatientId { get; set; }
        public String StateName { get; set; }
        public String StateDescription { get; set; }
        public DateTime PrescriptionTime { get; set; }
        public ICollection<MedicineDTO> Medicines { get; set; }
       
    }
}
