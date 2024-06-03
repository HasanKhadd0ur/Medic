using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ViewModel
{
    public class MedicineViewModel 
    {

        public String TradeName { get; set; }
        public String ScintificName { get; set; }
        public String ManufactureName { get; set; }
        public String SideEffect { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public String Image { get; set; }
        public int Dosage { get; set; }
        public Category Category { get; set; }
        public MedicineType MedicineType { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<MedicalState> MedicalStates { get; set; }

    }
}
