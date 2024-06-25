using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IService<T> where T : DTOBase   
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<IEnumerable<T>> GetByCriteria(Func<T,bool> Cretira);
        public Task<T> GetDetails(int Id);
        public void Delete(int Id);
        public T Update(T tModel);
        public T Create(T tModel);



    }
}
