using ApplicationCore.Interfaces.ISpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IGenericRepository<T>  where  T : Entities.EntityBase 
    {
        
        public T Update(T entities);
        public T Insert(T entities);
        public T GetById(int id, ISpecification<T>? specification = null );
        public void Delete(int id);
        public IEnumerable<T> GetAll(ISpecification<T> specification);

    }
}
