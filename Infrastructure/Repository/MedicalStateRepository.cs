using ApplicationDomain.Abstraction;
using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MedicalStateRepository : GenericRepository<MedicalState>, IMedicalStateRepository
    {
        public MedicalStateRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<MedicalState>> GetByPatient(int patientId , ISpecification<MedicalState> specification)
        {
            specification.Criteria = p => p.PatientId == patientId;

           
            return GetAll(specification);
        }
    }
}
