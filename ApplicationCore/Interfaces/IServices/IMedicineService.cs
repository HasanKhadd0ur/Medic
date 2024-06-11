using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicineService :IService<MedicineModel>
    {
       // public Task<IEnumerable<MedicineModel>> GetAllMedicines();
     //   public void AddMedicine(MedicineModel medicine);
        public void AddMedicineIngredient(int medicineId, IngredientModel ingredient);
        public MedicineModel GetMedicineIngredentisDetails(int medicineId);
        
    }
}
