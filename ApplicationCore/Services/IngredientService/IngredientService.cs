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
    public class IngredientService :IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<Ingredient> _ingredientUnitOfWork;
        
        private IngredientSpecification _IngredientSpecification;


        public IngredientService(
            IUnitOfWork<Ingredient> ingredientUnitOfWork,
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _ingredientUnitOfWork = ingredientUnitOfWork;
            _IngredientSpecification = new IngredientSpecification();
        }
        public async  Task<IEnumerable<IngredientModel>> GetAllIngredients()
        {
            return _mapper.Map<IEnumerable<IngredientModel>>(await _ingredientUnitOfWork.Entity.GetAll(
                _IngredientSpecification 
                 ));
        }
        public IngredientModel Create(IngredientModel ingredient)
        {

            var ing = _ingredientUnitOfWork.Entity.Insert(_mapper.Map<Ingredient>(ingredient));
            _ingredientUnitOfWork.Save();
            return _mapper.Map<IngredientModel>(ing);
        }
        public IngredientModel Update(IngredientModel ingredient)
        {

            var r = _ingredientUnitOfWork.Entity.Update(_mapper.Map<Ingredient>(ingredient));
            _ingredientUnitOfWork.Save();
            return _mapper.Map<IngredientModel>(r);
        }

        public void AddToMedicine(int ingredientId, int medicineId, int ratio) {
           var r = _ingredientUnitOfWork.Entity.GetById(ingredientId,_IngredientSpecification).Result;
            r.MedicineIngredients.Add(
                new MedicineIngredient { IngredientId = ingredientId , MedicineId=medicineId ,Ratio=ratio}
                );
            _ingredientUnitOfWork.Entity.Update(r);
            _ingredientUnitOfWork.Save();
        }
        public async Task<IngredientModel> GetDetails(int id)
        {

            return   _mapper.Map<IngredientModel>(await _ingredientUnitOfWork.Entity.GetById(id, 
                _IngredientSpecification));

        }

        public void Delete(int id)
        {
            _ingredientUnitOfWork.Entity.Delete(id);
            _ingredientUnitOfWork.Save();
        }

    }
}
