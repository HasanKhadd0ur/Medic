using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;

namespace ApplicationDomain.Abstraction
{
    public interface IUnitOfWork<T> where T : EntityBase
    {

        IGenericRepository<T> Entity { get; }
        IIngredientRepository Ingredients { get; }
        IMedicalStateRepository MedicalStates { get; }
        IPatientRepository Patients { get;  }
        IMedicineRepository Medicines { get; }

        void Commit();
    //    void Rollback();
    }
}
