using ApplicationDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class MedicineRepository : GenericRepository<Medicine> 
    {
        public MedicineRepository(DbContext dbContext) : base(dbContext)
        {
        }

    }
}
