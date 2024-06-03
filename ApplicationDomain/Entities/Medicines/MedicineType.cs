using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class MedicineType : EntityBase
    {
        public String TypeName { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
    }
}
