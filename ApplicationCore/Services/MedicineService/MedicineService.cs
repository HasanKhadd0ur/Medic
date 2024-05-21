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

        public Medicine GetMedicineDetails(int id)
        {

            return _medicineUnitOfWork.Entity.GetById(id , i => i.MedicineIngredients , i => i.Ingredients );
            
        }
    }
}
