using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;
using ApplicationDomain.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MedicineRepository : GenericRepository<Medicine> ,IMedicineRepository
    {
        public MedicineRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public  Task<IEnumerable<Medicine>> GetByMedicalState(int medicalStateId)
        {
            var spec = new MedicineIngredientSpecification();

            spec.Criteria = p => p.MedicalStates.All(s=>s.Id ==medicalStateId );

            return  GetAll(spec);
        }
    }
}
