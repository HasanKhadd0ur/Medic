using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public class MedicineIngredientViewModel : BaseViewModel
    {
        public int Ratio { get; set; }
        public int MedicineId { get; set; }
        public int IngredientId { get; set; }

        public IngredientViewModel Ingredient { get; set; }
    }
}
