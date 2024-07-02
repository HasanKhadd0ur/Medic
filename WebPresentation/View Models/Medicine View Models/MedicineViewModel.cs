using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebPresentation.ViewModels
{
    public class MedicineViewModel : BaseViewModel , IImageForm
    {
        [Display(Name ="Trade Name ")]
        public String TradeName { get; set; }
        [Display(Name = "Scintific Name ")]
        public String ScintificName { get; set; }
        [Display(Name = "Manufacture Name ")]
        public String ManufactureName { get; set; }

        [Display(Name = "Side Effect")]
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
