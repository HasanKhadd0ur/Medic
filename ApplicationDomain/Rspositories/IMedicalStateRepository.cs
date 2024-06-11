using ApplicationDomain.Abstraction;
using ApplicationDomain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationDomain.Repositories
{
    public interface IMedicalStateRepository : IGenericRepository<MedicalState>
    {
        public Task<IEnumerable<MedicalState>> GetByPatient(int patientId, ISpecification<MedicalState> specification);
    }

}
