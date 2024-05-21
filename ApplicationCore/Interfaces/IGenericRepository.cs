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
        public T GetById(int id, params Expression<Func<T, object>>[] includeProperties);
        public void Delete(int id);
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);

    }
}
