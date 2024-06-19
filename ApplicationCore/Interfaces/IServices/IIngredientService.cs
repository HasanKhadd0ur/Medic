using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IIngredientService  : IService<IngredientModel>
    {
        public void AddToMedicine(MedicineIngredientModel medicineIngredientModel);
        public void RemoveFromMedicine(MedicineIngredientModel medicineIngredientModel);

    }
}
