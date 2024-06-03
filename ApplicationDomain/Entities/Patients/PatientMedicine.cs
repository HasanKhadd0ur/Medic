using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class PatientMedicine : EntityBase
    {
        public DateTime PrescripDate { get; set; }
        public int MedicineId { get; set; }
        public int PatientId { get; set; }
        public Medicine Medicine { get; set; }
        public Patient Patient { get; set; }
    }
}
