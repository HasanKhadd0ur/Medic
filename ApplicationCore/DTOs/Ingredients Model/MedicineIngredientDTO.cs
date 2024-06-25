using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class MedicineIngredientDTO : DTOBase
    {
        public int Ratio { get; set; }
        public int MedicineId { get; set; }
        public int IngredientId { get; set; }

        public MedicineDTO Medicine { get; set; }
        public IngredientDTO Ingredient { get; set; }
    }
}
