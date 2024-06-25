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
using ApplicationCore.DTOs;

namespace ApplicationCore.Services
{
    public class PatientService : ServiceBase<Patient ,PatientDTO> , IPatientService
    {
        private MedicalStateWithMedicinesSpecification _medicalStateSpecification;
        
        public PatientService(
            IUnitOfWork<Patient> patientUnitOfWork,
            IMapper mapper )
            :base(patientUnitOfWork  , mapper)
        {
            _specification = new PatientWithMedicinesSpecification();
            _medicalStateSpecification = new MedicalStateWithMedicinesSpecification();
        }

        public async Task<IEnumerable<MedicalStateDTO>> GetPatientMedicalStates(int patientId) {


            return _mapper.Map<IEnumerable<MedicalStateDTO>>(
                await _unitOfWork.MedicalStates
                .GetByPatient(
                patientId, _medicalStateSpecification
                ));

        }
        
        public async Task< MedicalStateDTO> GetMedicalStateDetails(int id)
        {
           
            return _mapper.Map<MedicalStateDTO>(await  _unitOfWork.MedicalStates.GetById(id,_medicalStateSpecification));

        }

        public void AddMedicalState (int patientId, MedicalStateDTO medicalState) {
            var ptient = _unitOfWork.Entity.GetById(patientId,_specification).Result;
            
            
            ptient.MedicalStates.Add(_mapper.Map<MedicalState>(medicalState));
            
            _unitOfWork.Entity.Update(ptient);
            _unitOfWork.Commit();
        }
        
        public bool PatientExists(int id)
        {
            return _unitOfWork.Entity.GetById(id) is null ? false : true;
        }

        public async  Task<PatientDTO> GetByUserEmail(string email)
        {
            var ps = await  _unitOfWork.Entity.GetAll(_specification);
            return _mapper.Map<PatientDTO>(ps.Where(p => p.User.Email == email).FirstOrDefault());

        }
        public async Task<PatientDTO> GetByUserId(string id)
        {
            var ps = await _unitOfWork.Entity.GetAll(_specification);
            return _mapper.Map<PatientDTO>(ps.Where(p => p.User.Id == id).FirstOrDefault());

        }
    }
}
