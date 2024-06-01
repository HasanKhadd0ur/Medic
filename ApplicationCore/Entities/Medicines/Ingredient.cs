using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Ingredient : EntityBase
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public ICollection<MedicineIngredient> MedicineIngredients { get; set; }



    }
}
