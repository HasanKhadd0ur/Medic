using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPresentation.ViewModels
{
    public class IngredientViewModel : BaseViewModel
    {
        [Required]
        [MinLength(4)]
        public String Name { get; set; }
        public String Description { get; set; }

    }
}
