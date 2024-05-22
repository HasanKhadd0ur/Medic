using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ViewModel
{
    public class PatientMedicineViewModel
    {
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Medicine> Medicines { get; set; }

    }
}
