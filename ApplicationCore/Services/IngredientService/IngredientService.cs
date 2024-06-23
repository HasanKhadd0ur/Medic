using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.DomainModel;
using AutoMapper;

namespace ApplicationCore.Services
{
    public class IngredientService : ServiceBase<Ingredient,IngredientModel> , IIngredientService
    {
        public IngredientService(
            IUnitOfWork<Ingredient> unitOfWork,
            IMapper mapper
            ):base(unitOfWork,mapper)
        {
            _specification = new IngredientWithMedicinesSpecification();
        }


        public async Task<MedicineIngredientModel> AddToMedicine(MedicineIngredientModel medicineIngredientModel) {
           var medicine = await _unitOfWork.Entity.GetById(medicineIngredientModel.IngredientId,_specification);
            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientModel);
            medicine.MedicineIngredients.Add(
                medicineIngredient
                );
            _unitOfWork.Entity.Update(medicine);
            _unitOfWork.Commit();
            return medicineIngredientModel;
        }
        public async Task  RemoveFromMedicine(MedicineIngredientModel medicineIngredientModel)
        {
            var ingredient = await _unitOfWork.Ingredients.GetById(medicineIngredientModel.IngredientId, _specification);
           
            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientModel);
            var m =ingredient.MedicineIngredients.Where(p => p.MedicineId == medicineIngredientModel.MedicineId).FirstOrDefault();
            ingredient.MedicineIngredients.Remove(m);

            _unitOfWork.Entity.Update(ingredient);
            _unitOfWork.Commit();
        }

    }
}
