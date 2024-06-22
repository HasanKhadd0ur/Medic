using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{
    public class MedicineModel : DomainBase
    {

        public String TradeName { get; set; }
        public String ScintificName { get; set; }
        public String ManufactureName { get; set; }
        public String SideEffect { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public String Image { get; set; }
        public int Dosage { get; set; }
        public CategoryModel Category { get; set; }
        public MedicineTypeModel MedicineType { get; set; }
        public ICollection<IngredientModel> Ingredients { get; set; }
     //  public ICollection<MedicalStateModel> MedicalStates { get; set; }
     //   public ICollection<MedicalStateMedicineModel> MedicalStateMedicines { get; set; }
        public ICollection<MedicineIngredientModel> MedicineIngredients { get; set; }

    }
}
