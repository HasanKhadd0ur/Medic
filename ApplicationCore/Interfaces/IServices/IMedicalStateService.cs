using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicalStateService
    {
        public IEnumerable<MedicalState> GetAll(int patientId);
        public void Add(int patientId , MedicalState medicalState);
        public void AddMedicine(int medicalStateId, int medicineId);
        public MedicalState Update(MedicalState medicalState);
        public MedicalState GetDetails(int medicalStateId);
        public void Delete(int id);

    }
}
