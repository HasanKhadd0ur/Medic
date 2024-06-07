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
    public class MedicineService : IMedicineService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private MedicineIngredientSpecification _medicineIngredientSpecification;
        public MedicineService(
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IMapper medicineMapper )
        {
            _mapper = medicineMapper;
            _medicineUnitOfWork = medicineUnitOfWork;
            _medicineIngredientSpecification = new MedicineIngredientSpecification();
        }
        public async Task<IEnumerable<MedicineModel>> GetAllMedicines() {
            var m =  _mapper.Map<IEnumerable<MedicineModel>>(await _medicineUnitOfWork.Entity.GetAll(
                 _medicineIngredientSpecification
                 ));
            return m ;
        }
        public MedicineModel Create (MedicineModel medicineModel) {
            var r = _mapper.Map<MedicineModel>(new Medicine());
            var rr = _mapper.Map<Medicine>(new MedicineModel());

            var medicine = _mapper.Map<Medicine>(medicineModel);
            var m =  _medicineUnitOfWork.Entity.Insert(medicine);
            _medicineUnitOfWork.Save();
            return _mapper.Map<MedicineModel>(m);

        }
        public   void AddMedicineIngredient(int medicineId ,IngredientModel ingredientModel ) {

            var s = _medicineUnitOfWork.Entity.GetById(medicineId,_medicineIngredientSpecification).Result;
            s.Ingredients.Add(_mapper.Map<Ingredient>(ingredientModel));
            _medicineUnitOfWork.Entity.Update(s);
            _medicineUnitOfWork.Save();


        }
        public MedicineModel Update(MedicineModel medicineModel) {
            var medicine = _mapper.Map<Medicine>(medicineModel);
            var rm=_medicineUnitOfWork.Entity.Update(medicine);
            _medicineUnitOfWork.Save();
            var r =_mapper.Map<MedicineModel>(rm);

            return r;
        }
        public async Task<MedicineModel> GetDetails(int id)
        {
            var medicine = _mapper.Map<MedicineModel>(await _medicineUnitOfWork.Entity.GetById(id, _medicineIngredientSpecification));

            return medicine;
            
        }
        public MedicineModel GetMedicineIngredentisDetails(int medicineId) {
            return _mapper.Map<MedicineModel>(_medicineUnitOfWork.Entity
                .GetById(medicineId ,
                   _medicineIngredientSpecification));

        }

        public  void AddIngredient(int medicineId, int ratio , IngredientModel ingredient)
        {
            //   var m = _mapper.Map<Medicine>(GetMedicineIngredentisDetails(medicineId));
            var m =  _medicineUnitOfWork.Entity.GetById(medicineId,_medicineIngredientSpecification).Result;
            _medicineUnitOfWork.Save();
            if (ingredient.Id != 0)

                foreach (var i in m.Ingredients)
                {
                    if (i.Id.Equals(ingredient.Id))
                        return;
                }
            m.AddIngredient(_mapper.Map<Ingredient>(ingredient), ratio);
            _medicineUnitOfWork.Entity.Update(m);
            _medicineUnitOfWork.Save();
                
        }

        public void Delete(int id) {
            _medicineUnitOfWork.Entity.Delete(id);
            _medicineUnitOfWork.Save();
        }
    }
}
