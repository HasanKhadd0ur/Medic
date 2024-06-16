using ApplicationDomain.Abstraction;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Repositories
{
    public interface IMedicineRepository : IGenericRepository<Medicine>
    {
        public Task<IEnumerable<Medicine>> GetByMedicalState(int medicalStateId );
    }
}
