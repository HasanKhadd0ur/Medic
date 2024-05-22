using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Medicine : EntityBase
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public String Image { get; set; }
        public int Dosage { get; set; }
        public Category Category { get; set; }
        public MedicineType MedicineType { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<MedicineIngredient> MedicineIngredients { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public ICollection<PatientMedicine> PatientMedicines { get; set; }
        



    }
}
