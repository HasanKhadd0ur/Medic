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
using ApplicationCore.Mapper;
using AutoMapper;
using ApplicationCore.DomainModel;

namespace ApplicationCore.Services
{
    public class MedicineService : ServiceBase<Medicine,MedicineModel>,IMedicineService
    {
    
        public MedicineService(
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IMapper Mapper )
            :base(medicineUnitOfWork  , Mapper)
        {
            _specification = new MedicineIngredientSpecification();
        }

        public   void AddMedicineIngredient(int medicineId ,IngredientModel ingredientModel ) {

            var s = _unitOfWork.Entity.GetById(medicineId,_specification).Result;
            s.Ingredients.Add(_mapper.Map<Ingredient>(ingredientModel));
            _unitOfWork.Entity.Update(s);
            _unitOfWork.Save();


        }
       
    
        public MedicineModel GetMedicineIngredentisDetails(int medicineId) {
            return _mapper.Map<MedicineModel>(_unitOfWork.Entity
                .GetById(medicineId ,
                   _specification));

        }

        //public  void AddIngredient(int medicineId, int ratio , IngredientModel ingredient)
        //{
        //    //   var m = _mapper.Map<Medicine>(GetMedicineIngredentisDetails(medicineId));
        //    var m =  _unitOfWork.Entity.GetById(medicineId,_specification).Result;
        //    _unitOfWork.Save();
        //    if (ingredient.Id != 0)

        //        foreach (var i in m.Ingredients)
        //        {
        //            if (i.Id.Equals(ingredient.Id))
        //                return;
        //        }
        //    m.AddIngredient(_mapper.Map<Ingredient>(ingredient), ratio);
        //    _unitOfWork.Entity.Update(m);
        //    _unitOfWork.Save();
                
        //}
    }
}
