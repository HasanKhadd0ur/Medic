using ApplicationDomain.Entities;
using System.Threading.Tasks;

namespace ApplicationDomain.Repositories
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        public Task<Patient> GetByUserId(string userId);
    }

}
