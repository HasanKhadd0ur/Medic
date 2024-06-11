using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicalStateService : IService<MedicalStateModel>
    {
        public IEnumerable<MedicalStateModel> GetAllPatientMedicalStates(int patientId);
        public MedicalStateModel AddMedicalStateToPateint(int patientId , MedicalStateModel medicalState);
        public void AddMedicine(int medicalStateId, int medicineId);
        public void RemoveMedicine(int medicalStateId, int medicineId);

        //  public MedicalState Update(MedicalState medicalState);
        //public MedicalState GetDetails(int medicalStateId);
        //public void Delete(int id);

    }
}
