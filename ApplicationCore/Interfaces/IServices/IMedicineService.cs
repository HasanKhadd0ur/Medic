using ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicineService :IService<MedicineDTO>
    {
        public MedicineDTO GetMedicineIngredentisDetails(int medicineId);
        public void AddToMedicalState(MedicalStateMedicineDTO medicalStateMedicineModel);
        public void RemoveFromMedicalState(MedicalStateMedicineDTO medicalStateMedicineModel);
        public Task<IEnumerable<MedicineIngredientDTO>> GetMedicineIngredients( int id);

    }
}
