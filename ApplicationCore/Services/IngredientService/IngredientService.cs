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
using ApplicationDomain.Exceptions;

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
            if (medicine.MedicineIngredients is null)
                medicine.MedicineIngredients = new List<MedicineIngredient>();
            foreach (var i in medicine.MedicineIngredients)
            {
                if (
                    i.MedicineId ==medicineIngredientDto.MedicineId
                        &&
                        i.IngredientId == medicineIngredientDto.IngredientId
                    )
                    throw new DomainException("the ingredient already exist in the medicine  ");
            }
            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientDto);
            medicine.MedicineIngredients.Add(
                medicineIngredient
                );
            try
            {
                _unitOfWork.Entity.Update(medicine);
            }
            catch {
                throw new DomainException("the ingredient not exist ");

            }
            _unitOfWork.Commit();
       
        }

        public async Task  RemoveFromMedicine(MedicineIngredientDTO medicineIngredientDto)
        {
            var ingredient = await _unitOfWork.Ingredients.GetById(medicineIngredientDto.IngredientId, _specification);
            if (ingredient.MedicineIngredients is null)
                throw new DomainException("you dont have this ingredient");

            MedicineIngredient medicineIngredient = _mapper.Map<MedicineIngredient>(medicineIngredientDto);
            var m =ingredient.MedicineIngredients.Where(p => p.MedicineId == medicineIngredientDto.MedicineId).FirstOrDefault();
            if(m is null )
                throw new DomainException("the medicine doesn't exist ");

            if (!ingredient.MedicineIngredients.Remove(m))
                throw new DomainException("you dont have this ingredient");

            _unitOfWork.Entity.Update(ingredient);
            _unitOfWork.Commit();
        }

    }
}
