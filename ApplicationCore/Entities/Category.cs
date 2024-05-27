using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Category : EntityBase
    {
        public String Name { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public void  AddMedicine(Medicine medicine) {

            Medicines.Add(medicine);
        }
    }
}
