using System;
using System.ComponentModel.DataAnnotations;

namespace WebPresentation.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        [Display(Name = "Category Name")]
        public String Name { get; set; }
    }
}