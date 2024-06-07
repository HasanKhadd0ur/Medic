using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> :IUnitOfWork<T> where T : EntityBase
    {
        private readonly DbContext _context;
        private IGenericRepository<T> _entity;
        public UnitOfWork(DbContext context)
        {
            _context = context;
            _entity = new GenericRepository<T>(context);
        }

        public IGenericRepository<T> Entity
        {
            get
            {

                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }




        }

        void IUnitOfWork<T>.Save()
        {
            _context.SaveChanges();
        }

    }
}
