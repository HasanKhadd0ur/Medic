using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IPatientService :IService<PatientModel>
    {

        public Task<IEnumerable<MedicalStateModel>> GetPatientMedicalStates(int patientId);
        public Task<MedicalStateModel> GetMedicalStateDetails(int id);
        public Task<PatientModel> GetByUserEmail(String email );
        public Task<PatientModel> GetByUserId(String email);

        //    public Task<IEnumerable<PatientModel>>GetAll();
        public void AddMedicalState(int patientId, MedicalStateModel medicalState);
       // public Patient GetDetails(int id);
      //  public void Insert(PatientModel patient);
      //  public void Update(Patient patient);
      //  public void Delete(int id);
        public bool PatientExists(int id);

    }
}
