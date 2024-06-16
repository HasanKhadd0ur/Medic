using ApplicationDomain.Entities;
using ApplicationDomain.Repositories;
using ApplicationDomain.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IngredientRepository : GenericRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Ingredient>> GetByName(String Name)
        {
            var spec = new IngredientWithMedicinesSpecification();
            spec.Criteria = p => p.Name == Name;

            IQueryable<Ingredient> queryable = _table;
            queryable = GetQuery(queryable, spec);

            return await queryable.ToListAsync();

        }
    }
}
