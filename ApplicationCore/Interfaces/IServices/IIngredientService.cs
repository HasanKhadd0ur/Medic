using ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IIngredientService  : IService<IngredientDTO>
    {
        public Task AddToMedicine(MedicineIngredientDTO medicineIngredientDto);
        public Task RemoveFromMedicine(MedicineIngredientDTO medicineIngredientDto);
        
    }
}
