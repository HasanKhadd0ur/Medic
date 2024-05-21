using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Patient : EntityBase
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Avatar { get; set; }
        public User User { get; set; }
        public String BIO { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<PatientMedicine> PatientMedicines { get; set; }
       
    }
}
