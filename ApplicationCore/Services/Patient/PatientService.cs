using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.PatientService
{
    public class PatientService
    {
        private readonly IUnitOfWork<Patient> _patientUnitOfWork;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;

        public PatientService(IUnitOfWork<Patient> patientUnitOfWork, IUnitOfWork<Medicine> medicineUnitOfWork)
        {
            _patientUnitOfWork = patientUnitOfWork;
            _medicineUnitOfWork = medicineUnitOfWork;
        }

        public IEnumerable<Medicine> GetPatientMedicines(int patientId) {

            return _patientUnitOfWork.Entity.GetById(patientId, p => p.Medicines).Medicines.AsEnumerable();

        }
        public Medicine GetMedicineDetails(int id)
        {

            return _medicineUnitOfWork.Entity.GetById(id, i => i.MedicineIngredients, i => i.Ingredients);

        }
        public IEnumerable<Patient> getAll(params Expression<Func<Patient, object>>[] includeProperties) {
            return _patientUnitOfWork.Entity.GetAll(includeProperties);
        }
        public void AddMedicine(int patientId, Medicine medicine) {
            var ptient = _patientUnitOfWork.Entity.GetById(patientId, p => p.Medicines);
            ptient.Medicines.Add(medicine);
        }
        public Patient getById(int id, params Expression<Func<Patient, object>>[] includeProperties)
        {
            return _patientUnitOfWork.Entity.GetById(id, includeProperties);

        }
        public void insert(Patient owner)
        {

            _patientUnitOfWork.Entity.Insert(owner);

            _patientUnitOfWork.Save();
        }

        public void update(Patient owner)
        {


            _patientUnitOfWork.Entity.Update(owner);
            _patientUnitOfWork.Save();
        }
        public void delete(int id)
        {

            _patientUnitOfWork.Entity.Delete(id);
            _patientUnitOfWork.Save();
        }

        public bool ownerExists(int id)
        {
            return _patientUnitOfWork.Entity.GetById(id) is null ? false : true;
        }


    }
}
