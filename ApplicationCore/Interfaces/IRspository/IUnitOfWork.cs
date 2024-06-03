using ApplicationDomain.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork<T> where T : EntityBase
    {

        IGenericRepository<T> Entity { get; }
        void Save();

    }
}
