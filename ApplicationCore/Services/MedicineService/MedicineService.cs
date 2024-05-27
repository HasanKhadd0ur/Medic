using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.MedicineService
{
    public class MedicineService
    {
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;

        public MedicineService(IUnitOfWork<Medicine> medicineUnitOfWork)
        {
            _medicineUnitOfWork = medicineUnitOfWork;
        }
        public IEnumerable<Medicine> GetAllMedicines() {
            return _medicineUnitOfWork.Entity.GetAll(
                  p => p.Category 
                , p => p.Ingredients
                , p => p.Patients
                );
        }
        public void AddMedicine(Medicine medicine) {
          
            _medicineUnitOfWork.Entity.Insert(medicine);
            _medicineUnitOfWork.Save();

        }
        public void AddMedicineIngredient(int medicineId ,Ingredient ingredient ) {

            var s =_medicineUnitOfWork.Entity.GetById(medicineId, p => p.Ingredients);
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

            return _medicineUnitOfWork.Entity.GetById(id , i => i.MedicineIngredients , i => i.Ingredients,c => c.Category );
            
        }
        public Medicine GetMedicineIngredentisDetails(int medicineId) {
            return _medicineUnitOfWork.Entity
                .GetById(medicineId ,
                    i => i.MedicineIngredients,
                    i => i.Ingredients,
                    c => c.Category);

        }
        public void AddIngredient(int medicineId, int ratio ,Ingredient ingredient) {
            var m = GetMedicineIngredentisDetails(medicineId);
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
