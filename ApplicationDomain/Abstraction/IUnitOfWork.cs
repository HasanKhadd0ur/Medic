using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;

namespace ApplicationDomain.Abstraction
{
    public interface IUnitOfWork<T> where T : EntityBase
    {

        IGenericRepository<T> Entity { get; }
        void Save();

    }
}
