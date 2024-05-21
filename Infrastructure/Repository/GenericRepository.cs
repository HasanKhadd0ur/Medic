using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
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

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {

            {
                IQueryable<T> queryable = _table;
                foreach (var includeProperty in includeProperties)
                {
                    queryable = queryable.Include(includeProperty);
                }
                return queryable.AsEnumerable();
            }
        }

        public T GetById(int id, params Expression<Func<T, object>>[] includeProperties)
        {


            IQueryable<T> query = _table;
            if (includeProperties is not null)
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            return query.Where(p => p.Id == id).First();
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
    }
}
