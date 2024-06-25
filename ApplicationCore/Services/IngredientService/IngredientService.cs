using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using AutoMapper;
using System.Collections.Generic;

namespace ApplicationCore.Services
{
    public class IngredientService : ServiceBase<Ingredient,IngredientDTO> , IIngredientService
    {
        public IngredientService(
            IUnitOfWork<Ingredient> unitOfWork,
            IMapper mapper
            ):base(unitOfWork,mapper)
        {
            _specification = new IngredientWithMedicinesSpecification();
        }


        public async Task AddToMedicine(MedicineIngredientDTO medicineIngredientDto) {
           var medicine = await _unitOfWork.Entity.GetById(medicineIngredientDto.IngredientId,_specification);
            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientDto);
            medicine.MedicineIngredients.Add(
                medicineIngredient
                );
            _unitOfWork.Entity.Update(medicine);
            _unitOfWork.Commit();
       
        }

        public async Task  RemoveFromMedicine(MedicineIngredientDTO medicineIngredientDto)
        {
            var ingredient = await _unitOfWork.Ingredients.GetById(medicineIngredientDto.IngredientId, _specification);
           
            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientDto);
            var m =ingredient.MedicineIngredients.Where(p => p.MedicineId == medicineIngredientDto.MedicineId).FirstOrDefault();
            ingredient.MedicineIngredients.Remove(m);

            _unitOfWork.Entity.Update(ingredient);
            _unitOfWork.Commit();
        }

    }
}
