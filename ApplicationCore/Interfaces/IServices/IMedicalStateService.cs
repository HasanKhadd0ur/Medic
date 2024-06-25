using ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicalStateService : IService<MedicalStateDTO>
    {
        public Task<IEnumerable<MedicalStateDTO>> GetAllPatientMedicalStates(int patientId);
        public MedicalStateDTO AddToPateint(int patientId , MedicalStateDTO medicalState);
        
      
    }
}
