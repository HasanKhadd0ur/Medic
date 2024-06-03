using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicineService
    {
        public IEnumerable<Medicine> GetAllMedicines();
        public void AddMedicine(Medicine medicine);
        public void AddMedicineIngredient(int medicineId, Ingredient ingredient);
        public Medicine Update(Medicine medicine);
        public Medicine GetMedicineDetails(int id);
        public Medicine GetMedicineIngredentisDetails(int medicineId);
        public void AddIngredient(int medicineId, int ratio, Ingredient ingredient);
        public void Delete(int id);
    
    }
}
