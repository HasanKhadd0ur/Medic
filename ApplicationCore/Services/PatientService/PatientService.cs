﻿using ApplicationCore.Entities;
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
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private PatientMedicinesSpecification _patientMedicinesSpecification;
        private MedicineIngredientSpecification _medicineIngredientSpecification;

        public PatientService(IUnitOfWork<Patient> patientUnitOfWork, IUnitOfWork<Medicine> medicineUnitOfWork)
        {
            _patientUnitOfWork = patientUnitOfWork;
            _medicineUnitOfWork = medicineUnitOfWork;
            _patientMedicinesSpecification = new PatientMedicinesSpecification();
            _medicineIngredientSpecification = new MedicineIngredientSpecification();
        }

        public IEnumerable<Medicine> GetPatientMedicines(int patientId) {

            return _patientUnitOfWork.Entity
                .GetById(
                patientId,_patientMedicinesSpecification
                ).Medicines.AsEnumerable();

        }
        public Medicine GetMedicineDetails(int id, params Expression<Func<Medicine, object>>[] includeProperties)
        {
           
            return _medicineUnitOfWork.Entity.GetById(id,_medicineIngredientSpecification);

        }
        public IEnumerable<Patient> GetAll(params Expression<Func<Patient, object>>[] includeProperties) {
            return _patientUnitOfWork.Entity.GetAll(_patientMedicinesSpecification);
        }
        public void AddMedicine(int patientId, Medicine medicine) {
            var ptient = _patientUnitOfWork.Entity.GetById(patientId,_patientMedicinesSpecification);
            if (medicine.Id != 0)

                foreach (var i in ptient.Medicines)
                {
                    if (i.Id.Equals(medicine.Id))
                        return;
                }

            ptient.PatientMedicines
                .Add(new PatientMedicine{
                        Medicine = medicine,
                        Patient =ptient ,
                        PrescripDate=DateTime.Now 

                });
            _patientUnitOfWork.Entity.Update(ptient);
            _patientUnitOfWork.Save();
        }
        public Patient GetById(int id, params Expression<Func<Patient, object>>[] includeProperties)
        {
            return _patientUnitOfWork.Entity.GetById(id, _patientMedicinesSpecification);

        }
        public void Insert(Patient owner)
        {

            _patientUnitOfWork.Entity.Insert(owner);

            _patientUnitOfWork.Save();
        }

        public void Update(Patient owner)
        {


            _patientUnitOfWork.Entity.Update(owner);
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