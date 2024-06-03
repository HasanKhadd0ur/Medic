using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class Medicine : EntityBase
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

        #region Relations
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<MedicalState> MedicalStates { get; set; }
        public ICollection<MedicalStateMedicine> MedicalStateMedicines { get; set; }
        public ICollection<MedicineIngredient> MedicineIngredients { get; set; }
        #endregion Relations

        public void AddIngredient(Ingredient ingredient , int ratio ) {
            MedicineIngredients.Add(
                new MedicineIngredient
                {
                    Ingredient = ingredient,
                    Ratio = ratio,
                    Medicine = this
                });

        }
       
        
    }
}
