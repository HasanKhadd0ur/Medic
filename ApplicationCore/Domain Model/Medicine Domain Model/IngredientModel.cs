using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DomainModel
{
    public class IngredientModel : DomainBase
    {
        public String Name { get; set; }
        public String Description { get; set; }
       // public ICollection<MedicineModel> Medicines { get; set; }
     //   public ICollection<MedicineIngredientModel> MedicineIngredients { get; set; }



    }
}
