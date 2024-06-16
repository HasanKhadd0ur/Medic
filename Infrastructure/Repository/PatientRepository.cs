using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;
using ApplicationDomain.Specification;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async  Task<Patient> GetByUserId(string userId)
        {
            var spec = new PatientWithMedicinesSpecification();
            spec.Criteria = p => p.User.Id == userId;

            IQueryable<Patient> queryable = _table;
            queryable = GetQuery(queryable, spec);

            return  await queryable.FirstOrDefaultAsync();
        }
    }
}
