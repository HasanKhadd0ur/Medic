using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.ISpecification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> :  IGenericRepository<T> where T : EntityBase
    {
        private readonly DbContext _context;
        private DbSet<T> _table;
        public GenericRepository(DbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }
        public void Delete(int id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
        }

        public IEnumerable<T> GetAll(ISpecification<T> specification)
        {

            
                IQueryable<T> queryable = _table;
                queryable = GetQuery(queryable, specification);

                return queryable.AsEnumerable();
        }

        public T GetById(int id, ISpecification<T>? specification)
        {


            IQueryable<T> query = _table;
            if(specification != null )
            query = GetQuery(query, specification);

            return query.Where(p => p.Id == id).FirstOrDefault();
        }

        public T Insert(T entity)
        {
            return _table.Add(entity).Entity;
        }

        public T Update(T entity)
        {
            var e =_table.Attach(entity).Entity;
            _context.Entry(entity).State = EntityState.Modified;

            return e;
        }
        public  IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            IQueryable<T> query = inputQuery;

            // modify the IQueryable using the specification's criteria expression
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // Includes all expression-based includes
            query = specification.Includes.Aggregate(query,
                                    (current, include) => current.Include(include));
            
            // Include any string-based include statements
            query = specification.ThenInclude.Aggregate(query,
                                    (current, include) => current.Include(include));

            // Apply ordering if expressions are set
            if (specification.OrderBy != null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            return query;
        }
    }
}
