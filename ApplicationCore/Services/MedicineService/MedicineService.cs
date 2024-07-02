using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using System.Collections.Generic;
using AutoMapper;
using ApplicationCore.DTOs;
using ApplicationDomain.Exceptions;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MedicineService : ServiceBase<Medicine,MedicineDTO>,IMedicineService
    {
        private MedicalStateWithMedicinesSpecification _medicalSpecification;

        public MedicineService(
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IMapper Mapper 
            )
            :base(medicineUnitOfWork  , Mapper)
        {
            _specification = new MedicineWithIngredientsSpecification();
            _medicalSpecification = new MedicalStateWithMedicinesSpecification();
        }


        public  void AddToMedicalState(MedicalStateMedicineDTO medicalStateMedicineDto)
        {
            var medicalState =  _unitOfWork.Entity.GetById(medicalStateMedicineDto.MedicineId, _specification).Result;
            
            if (medicalState.MedicalStateMedicines is null)
                medicalState.MedicalStateMedicines = new List<MedicalStateMedicine>();
            
            foreach (var i in medicalState.MedicalStateMedicines)
            {
                if (
                    i.MedicalStateId == medicalStateMedicineDto.MedicalStateId
                        &&
                        i.MedicineId == medicalStateMedicineDto.MedicineId
                    )
                    throw new DomainException("the medicine already exist ");
            }
            if (medicalState.MedicalStateMedicines is null)
                medicalState.MedicalStateMedicines = new List<MedicalStateMedicine>();
            medicalState.MedicalStateMedicines.Add(
                _mapper.Map<MedicalStateMedicine>(medicalStateMedicineDto
                        )
                );


            _unitOfWork.Entity.Update(medicalState);
            _unitOfWork.Commit();
        }

        public void RemoveFromMedicalState(MedicalStateMedicineDTO medicalStateMedicineDto)
        {
            var medicalState = _unitOfWork.MedicalStates.GetById(medicalStateMedicineDto.MedicalStateId, _medicalSpecification).Result;
           
            if (medicalState.MedicalStateMedicines is null) {

                throw new DomainException("you dont have this medicine");

            }
            var d = _unitOfWork.Entity.GetById(medicalStateMedicineDto.MedicineId, _specification).Result;

            if (!medicalState.Medicines.Remove(d)) {

                throw new DomainException("you dont have this medicine");
            }
            _unitOfWork.MedicalStates.Update(medicalState);
            _unitOfWork.Commit();
        }

        public MedicineDTO GetMedicineIngredentisDetails(int medicineId) {

            return _mapper.Map<MedicineDTO>(
                        _unitOfWork.Entity
                            .GetById(medicineId ,
                                     _specification
                             )
                        );

        }

        public async Task<IEnumerable<MedicineIngredientDTO>> GetMedicineIngredients(int id)
        {
            var r = await _unitOfWork.Medicines.GetById(id,_specification);
            return _mapper.Map<IEnumerable<MedicineIngredientDTO>>( r.MedicineIngredients);
        }
    }
}
