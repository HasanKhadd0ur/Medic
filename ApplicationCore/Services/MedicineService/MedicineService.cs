using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using System.Collections.Generic;
using AutoMapper;
using ApplicationCore.DomainModel;

namespace ApplicationCore.Services
{
    public class MedicineService : ServiceBase<Medicine,MedicineModel>,IMedicineService
    {
        private MedicalStateWithMedicinesSpecification _medicalSpecification;

        public MedicineService(
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IMapper Mapper )
            :base(medicineUnitOfWork  , Mapper)
        {
            _specification = new MedicineWithIngredientsSpecification();
            _medicalSpecification = new MedicalStateWithMedicinesSpecification();
        }



        public  void AddToMedicalState(MedicalStateMedicineModel medicalStateMedicineModel)
        {
            var medicine =  _unitOfWork.Entity.GetById(medicalStateMedicineModel.MedicineId, _specification).Result;

            //if (medicalState.Medicines is null)
            //    medicalState.Medicines = new List<Medicine>();

            //var medicine = await _medicineUnitOfWork.Entity.GetById(medicalStateMedicineModel.MedicineId, _medicineSpecification);
            if (medicine.MedicalStateMedicines is null)
                medicine.MedicalStateMedicines = new List<MedicalStateMedicine>();
            medicine.MedicalStateMedicines.Add(
                _mapper.Map<MedicalStateMedicine>( medicalStateMedicineModel
                        )
                );


            _unitOfWork.Entity.Update(medicine);
            _unitOfWork.Commit();
        }

        public void RemoveFromMedicalState(MedicalStateMedicineModel medicalStateMedicineModel)
        {
            var m = _unitOfWork.MedicalStates.GetById(medicalStateMedicineModel.MedicalStateId, _medicalSpecification).Result;
            //// throw an exception 
            //if (m.Medicines is null)
            //    m.Medicines = new List<Medicine>();
            var d = _unitOfWork.Entity.GetById(medicalStateMedicineModel.MedicineId, _specification).Result;
             m.Medicines.Remove(d);

            _unitOfWork.MedicalStates.Update(m);
            _unitOfWork.Commit();
        }

        public MedicineModel GetMedicineIngredentisDetails(int medicineId) {

            return _mapper.Map<MedicineModel>(_unitOfWork.Entity
                .GetById(medicineId ,
                   _specification));

        }

    }
}
