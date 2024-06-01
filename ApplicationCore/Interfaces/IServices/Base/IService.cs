using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IService<T> where T : class   
    {

        public IEnumerable<T> GetAll(int Id);
        public void Add(int  Id, T entity);
        public T Update(T entity);
        public T GetDetails(int Id);
        public void Delete(int Id);


    }
}
