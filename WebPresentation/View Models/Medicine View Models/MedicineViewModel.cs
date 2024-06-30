using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace WebPresentation.ViewModels
{
    public class MedicineViewModel : BaseViewModel , IImageForm
    {

        public String TradeName { get; set; }
        public String ScintificName { get; set; }
        public String ManufactureName { get; set; }
        public String SideEffect { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public int Dosage { get; set; }
        public CategoryViewModel Category { get; set; }
        public MedicineTypeViewModel MedicineType { get; set; }
        public ICollection<IngredientViewModel> Ingredients { get; set; }
        public ICollection<MedicineIngredientViewModel> MedicineIngredients { get; set; }
       
        public IFormFile ImageFile { get ; set; }
        public string ImageName { get ; set ; }
    }
}
