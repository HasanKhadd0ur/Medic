using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork<T> where T : Entities.EntityBase
    {

        IGenericRepository<T> Entity { get; }
        void Save();

    }
}
