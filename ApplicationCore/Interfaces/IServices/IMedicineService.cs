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
        public MedicineModel GetMedicineIngredentisDetails(int medicineId);
        public void AddToMedicalState(MedicalStateMedicineModel medicalStateMedicineModel);
        public void RemoveFromMedicalState(MedicalStateMedicineModel medicalStateMedicineModel);

    }
}
