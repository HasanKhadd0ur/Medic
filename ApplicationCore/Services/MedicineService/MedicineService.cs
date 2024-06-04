using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Mapper;
using AutoMapper;
using ApplicationCore.ViewModel;

namespace ApplicationCore.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly MedicineMapper _mapper;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private MedicineIngredientSpecification _medicineIngredientSpecification;
        public MedicineService(
            IUnitOfWork<Medicine> medicineUnitOfWork,
            MedicineMapper medicineMapper )
        {
            _mapper = medicineMapper;
            _medicineUnitOfWork = medicineUnitOfWork;
            _medicineIngredientSpecification = new MedicineIngredientSpecification();
        }
        public IEnumerable<Medicine> GetAllMedicines() {
            return  _medicineUnitOfWork.Entity.GetAll(
                 _medicineIngredientSpecification
                 );
        }
        public void AddMedicine(Medicine medicine) {
            
            _medicineUnitOfWork.Entity.Insert(medicine);
            _medicineUnitOfWork.Save();

        }
        public void AddMedicineIngredient(int medicineId ,Ingredient ingredient ) {

            var s =_medicineUnitOfWork.Entity.GetById(medicineId,_medicineIngredientSpecification);
            s.Ingredients.Add(ingredient);
            _medicineUnitOfWork.Entity.Update(s);
            _medicineUnitOfWork.Save();


        }
        public Medicine Update(Medicine medicine) {

            var r=_medicineUnitOfWork.Entity.Update(medicine);
            _medicineUnitOfWork.Save();
            return r;
        }
        public Medicine GetMedicineDetails(int id)
        {

            return _medicineUnitOfWork.Entity.GetById(id, _medicineIngredientSpecification);
            
        }
        public Medicine GetMedicineIngredentisDetails(int medicineId) {
            return _medicineUnitOfWork.Entity
                .GetById(medicineId ,
                   _medicineIngredientSpecification);

        }
        public void AddIngredient(int medicineId, int ratio ,Ingredient ingredient) {
            var m = GetMedicineIngredentisDetails(medicineId);
            if(ingredient.Id!= 0 )

            foreach (var i in m.Ingredients) {
                if (i.Id.Equals(ingredient.Id))
                    return;
            }
            m.AddIngredient(ingredient ,ratio );
            _medicineUnitOfWork.Entity.Update(m);
            _medicineUnitOfWork.Save();
        }
        public void Delete(int id) {
            _medicineUnitOfWork.Entity.Delete(id);
            _medicineUnitOfWork.Save();
        }
    }
}
