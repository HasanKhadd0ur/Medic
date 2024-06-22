using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{
    public class MedicineIngredientModel : DomainBase
    {
        public int Ratio { get; set; }
        public int MedicineId { get; set; }
        public int IngredientId { get; set; }

        public MedicineModel Medicine { get; set; }
        public IngredientModel Ingredient { get; set; }
    }
}
