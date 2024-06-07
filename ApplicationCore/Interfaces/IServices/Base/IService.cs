using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IService<T> where T : class   
    {
        public  Task<T> GetDetails(int Id);
        public void Delete(int Id);
        public T Update(T tModel);
        public T Create(T tModel);



    }
}
