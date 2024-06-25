using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class MedicineDTO : DTOBase
    {

        public String TradeName { get; set; }
        public String ScintificName { get; set; }
        public String ManufactureName { get; set; }
        public String SideEffect { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public String Image { get; set; }
        public int Dosage { get; set; }
        public CategoryDTO Category { get; set; }
        public MedicineTypeDTO MedicineType { get; set; }
        public ICollection<IngredientDTO> Ingredients { get; set; }
        public ICollection<MedicineIngredientDTO> MedicineIngredients { get; set; }

    }
}
