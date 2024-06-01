using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Specification;

namespace ApplicationCore.Services
{
    public class MedicalStateService : IMedicalStateService
    {
        private readonly IUnitOfWork<MedicalState> _medicalStateUnitOfWork;
        private readonly PatientService _patientService;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private readonly MedicalStateSpecification _medicalStateSpecification;
        private readonly MedicineIngredientSpecification _medicineSpecification;
        public MedicalStateService(
            IUnitOfWork<MedicalState> medicalUnitOfWork,
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IUnitOfWork<Patient> patientUnitOfWork
            )
        {
            _medicalStateUnitOfWork = medicalUnitOfWork;
            _medicalStateSpecification = new MedicalStateSpecification();
            _medicineUnitOfWork = medicineUnitOfWork;
            _patientService = new PatientService(patientUnitOfWork,medicalUnitOfWork);
            
        }
        public void Add(int patientId , MedicalState medicalState)
        {
            _patientService.AddMedicalState(patientId, medicalState);
        }

        public void AddMedicine(int medicalStateId, int medicineId)
        {
           var m = _medicalStateUnitOfWork.Entity.GetById(medicalStateId, _medicalStateSpecification);
            if (m.Medicines is null)
                m.Medicines = new List<Medicine>();
            var d =_medicineUnitOfWork.Entity.GetById(medicineId,_medicineSpecification );
            m.Medicines.Add(d );

            _medicalStateUnitOfWork.Entity.Update(m);
            _medicalStateUnitOfWork.Save();
        }

        public void Delete(int id)
        {
            _medicalStateUnitOfWork.Entity.Delete(id);
            _medicalStateUnitOfWork.Save();
        }

        public IEnumerable<MedicalState> GetAll(int patientId)
        {
           return  _patientService.GetPatientMedicalStates(patientId);
        }

        public MedicalState GetDetails(int medicalStateId)
        {
            return _patientService.GetMedicalStateDetails(medicalStateId);
        }

        public MedicalState Update(MedicalState medicalState)
        {
           var r = _medicalStateUnitOfWork.Entity.Update(medicalState);
           _medicalStateUnitOfWork.Save();
            return r; 
        }
    }
}
