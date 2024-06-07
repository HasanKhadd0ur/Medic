using ApplicationDomain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ApplicationDomain.Entities;
namespace ApplicationDomain.Repositories
{
    public interface IGenericRepository<T>  where  T : EntityBase 
    {
        
        public T Update(T entities);
        public T Insert(T entities);
        public Task<T> GetById(int id, ISpecification<T> specification = null );
        public void Delete(int id);
        public Task<IEnumerable<T>> GetAll(ISpecification<T> specification);

    }
}
