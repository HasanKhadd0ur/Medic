using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicalStateService : IService<MedicalState>
    {
        public IEnumerable<MedicalState> GetAll();

        public IEnumerable<MedicalState> GetAllPatientMedicalStates(int patientId);
        public MedicalState Add(int patientId , MedicalState medicalState);
        public void AddMedicine(int medicalStateId, int medicineId);
        public void RemoveMedicine(int medicalStateId, int medicineId);

        //  public MedicalState Update(MedicalState medicalState);
        //public MedicalState GetDetails(int medicalStateId);
        //public void Delete(int id);

    }
}
