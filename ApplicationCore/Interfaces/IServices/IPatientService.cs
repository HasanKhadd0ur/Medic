using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IPatientService 
    {

        public IEnumerable<MedicalState> GetPatientMedicalStates(int patientId);
        public MedicalState GetMedicalStateDetails(int id, params Expression<Func<MedicalState, object>>[] includeProperties);
        public IEnumerable<Patient> GetAll(params Expression<Func<Patient, object>>[] includeProperties);
        public void AddMedicalState(int patientId, MedicalState medicalState);
        public Patient GetById(int id, params Expression<Func<Patient, object>>[] includeProperties);
        public void Insert(Patient patient);
        public void Update(Patient patient);
        public void Delete(int id);
        public bool PatientExists(int id);

    }
}
