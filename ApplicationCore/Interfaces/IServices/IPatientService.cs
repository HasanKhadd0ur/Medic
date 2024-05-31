using ApplicationCore.Entities;
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

        public IEnumerable<Medicine> GetPatientMedicines(int patientId);
        public Medicine GetMedicineDetails(int id, params Expression<Func<Medicine, object>>[] includeProperties);
        public IEnumerable<Patient> GetAll(params Expression<Func<Patient, object>>[] includeProperties);
        public void AddMedicine(int patientId, Medicine medicine);
        public Patient GetById(int id, params Expression<Func<Patient, object>>[] includeProperties);
        public void Insert(Patient owner);
        public void Update(Patient owner);
        public void Delete(int id);
        public bool PatientExists(int id);

    }
}
