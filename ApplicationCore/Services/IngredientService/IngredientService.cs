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
            IUnitOfWork<Ingredient> ingredientUnitOfWork,
            IMapper mapper
            ):base(ingredientUnitOfWork,mapper)
        {
            _specification = new IngredientSpecification();
        }


        public void AddToMedicine(int ingredientId, int medicineId, int ratio) {
           var r = _unitOfWork.Entity.GetById(ingredientId,_specification).Result;
            r.MedicineIngredients.Add(
                new MedicineIngredient { IngredientId = ingredientId , MedicineId=medicineId ,Ratio=ratio}
                );
            _unitOfWork.Entity.Update(r);
            _unitOfWork.Save();
        }

    }
}
