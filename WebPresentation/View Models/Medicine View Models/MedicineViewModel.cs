using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public class MedicineViewModel : BaseViewModel
    {

        public String TradeName { get; set; }
        public String ScintificName { get; set; }
        public String ManufactureName { get; set; }
        public String SideEffect { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public String Image { get; set; }
        public int Dosage { get; set; }
        public String Category { get; set; }
        public String MedicineType { get; set; }
        public ICollection<IngredientViewModel> Ingredients { get; set; }
        public ICollection<MedicineIngredientViewModel> MedicineIngredients { get; set; }

    }
}
