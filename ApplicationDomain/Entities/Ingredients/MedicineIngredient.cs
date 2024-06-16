using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class MedicineIngredient : EntityBase
    {
        public int Ratio { get; set; }
        public int MedicineId { get; set; }
        public int IngredientId { get; set; }

        public Medicine Medicine { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
