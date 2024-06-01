using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.PatientService
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork<Patient> _patientUnitOfWork;
        private readonly IUnitOfWork<MedicalState> _medicalStateUnitOfWork;
        private PatientMedicinesSpecification _patientMedicinesSpecification;
        private MedicalStateSpecification _medicalStateSpecification;

        public PatientService(
            IUnitOfWork<Patient> patientUnitOfWork,
            IUnitOfWork<MedicalState> medicalStateUnitOfWork)
        {
            _patientUnitOfWork = patientUnitOfWork;
            _medicalStateUnitOfWork = medicalStateUnitOfWork;
            _patientMedicinesSpecification = new PatientMedicinesSpecification();
            _medicalStateSpecification = new MedicalStateSpecification();
        }

        public IEnumerable<MedicalState> GetPatientMedicalStates(int patientId) {

            return _patientUnitOfWork.Entity
                .GetById(
                patientId,_patientMedicinesSpecification
                ).MedicalStates.AsEnumerable();

        }
        public MedicalState GetMedicalStateDetails(int id, params Expression<Func<MedicalState, object>>[] includeProperties)
        {
           
            return _medicalStateUnitOfWork.Entity.GetById(id,_medicalStateSpecification);

        }
        public IEnumerable<Patient> GetAll(params Expression<Func<Patient, object>>[] includeProperties) {
            return _patientUnitOfWork.Entity.GetAll(_patientMedicinesSpecification);
        }
        public void AddMedicalState (int patientId, MedicalState medicalState) {
            var ptient = _patientUnitOfWork.Entity.GetById(patientId,_patientMedicinesSpecification);
            if (medicalState.Id != 0)

                foreach (var i in ptient.MedicalStates)
                {
                    if (i.Id.Equals(medicalState.Id))
                        return;
                }

            ptient.MedicalStates
                .Add(medicalState
                );
            _patientUnitOfWork.Entity.Update(ptient);
            _patientUnitOfWork.Save();
        }
        public Patient GetById(int id, params Expression<Func<Patient, object>>[] includeProperties)
        {
            return _patientUnitOfWork.Entity.GetById(id, _patientMedicinesSpecification);

        }
        public void Insert(Patient patient)
        {

            _patientUnitOfWork.Entity.Insert(patient);

            _patientUnitOfWork.Save();
        }

        public void Update(Patient patient)
        {


            _patientUnitOfWork.Entity.Update(patient);
            _patientUnitOfWork.Save();
        }
        public void Delete(int id)
        {

            _patientUnitOfWork.Entity.Delete(id);
            _patientUnitOfWork.Save();
        }

        public bool PatientExists(int id)
        {
            return _patientUnitOfWork.Entity.GetById(id) is null ? false : true;
        }


    }
}
