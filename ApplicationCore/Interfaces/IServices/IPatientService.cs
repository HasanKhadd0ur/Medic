using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IPatientService :IService<PatientDTO>
    {

        public Task<IEnumerable<MedicalStateDTO>> GetPatientMedicalStates(int patientId);
        public Task<MedicalStateDTO> GetMedicalStateDetails(int id);
        public Task<PatientDTO> GetByUserEmail(String email );
        public Task<PatientDTO> GetByUserId(String email);

        //    public Task<IEnumerable<PatientModel>>GetAll();
        public void AddMedicalState(int patientId, MedicalStateDTO medicalState);
       // public Patient GetDetails(int id);
      //  public void Insert(PatientModel patient);
      //  public void Update(Patient patient);
      //  public void Delete(int id);
        public bool PatientExists(int id);

    }
}
