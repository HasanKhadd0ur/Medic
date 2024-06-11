using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ApplicationCore.DomainModel;

namespace ApplicationCore.Services
{
    public class PatientService : ServiceBase<Patient ,PatientModel> , IPatientService
    {
        private readonly IUnitOfWork<MedicalState> _medicalStateUnitOfWork;
        private MedicalStateSpecification _medicalStateSpecification;

        public PatientService(
            IUnitOfWork<Patient> patientUnitOfWork,
            IUnitOfWork<MedicalState> medicalStateUnitOfWork,
            IMapper mapper )
            :base(patientUnitOfWork  , mapper)
        {
            _medicalStateUnitOfWork = medicalStateUnitOfWork;
            _specification = new PatientMedicinesSpecification();
            _medicalStateSpecification = new MedicalStateSpecification();
        }
        
        public IEnumerable<MedicalStateModel> GetPatientMedicalStates(int patientId) {

            return _mapper.Map<IEnumerable<MedicalStateModel>>( _unitOfWork.Entity
                .GetById(
                patientId,_specification
                ).Result.MedicalStates.AsEnumerable());

        }

        public async Task< MedicalStateModel> GetMedicalStateDetails(int id)
        {
           
            return _mapper.Map<MedicalStateModel>(await  _medicalStateUnitOfWork.Entity.GetById(id,_medicalStateSpecification));

        }
        public void AddMedicalState (int patientId, MedicalStateModel medicalState) {
            var ptient = _unitOfWork.Entity.GetById(patientId,_specification).Result;
            
            
            ptient.MedicalStates.Add(_mapper.Map<MedicalState>(medicalState));
            
            _unitOfWork.Entity.Update(ptient);
            _unitOfWork.Save();
        }
        
        public bool PatientExists(int id)
        {
            return _unitOfWork.Entity.GetById(id) is null ? false : true;
        }


    }
}
