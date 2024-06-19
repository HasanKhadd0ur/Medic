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
        private IIngredientRepository _ingredients;
        private IMedicalStateRepository _medicalStates;
        private IPatientRepository _patients;
        private IMedicineRepository _medicines;



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

        public IIngredientRepository Ingredients
        {
            get
            {

                return _ingredients ?? (_ingredients = new IngredientRepository(_context));
            }

        }

        public IMedicalStateRepository MedicalStates
        {
            get
            {

                return _medicalStates ?? (_medicalStates = new MedicalStateRepository(_context));
            }

        }

        public IPatientRepository Patients
        {
            get
            {

                return _patients ?? (_patients = new PatientRepository(_context));
            }

        }

        public IMedicineRepository Medicines
        {
            get
            {

                return _medicines ?? (_medicines = new MedicineRepository(_context));
            }

        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public void RollBack() { 
        
        }

    }
}
