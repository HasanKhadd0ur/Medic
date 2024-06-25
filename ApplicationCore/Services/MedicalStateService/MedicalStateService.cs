using System.Collections.Generic;
using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using AutoMapper;
using ApplicationCore.DTOs;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MedicalStateService :ServiceBase<MedicalState ,MedicalStateDTO>, IMedicalStateService
    {
        
        public MedicalStateService(
            IUnitOfWork<MedicalState> unitOfWork,
            IMapper Mapper
            ):base(unitOfWork,Mapper)
        {
            _specification = new MedicalStateWithMedicinesSpecification();
        }
        
        public MedicalStateDTO AddToPateint(int patientId , MedicalStateDTO medicalStateDto)
        {
            medicalStateDto.PatientId = patientId;
            
            var im = medicalStateDto;
            
            var r = _unitOfWork.Entity.Insert(_mapper.Map<MedicalState>(im));
            _unitOfWork.Commit();
            return _mapper.Map<MedicalStateDTO>(r);
        }

        
        public async Task<IEnumerable<MedicalStateDTO>> GetAllPatientMedicalStates(int patientId)
        {
           return _mapper.Map<IEnumerable<MedicalStateDTO>>(

                await _unitOfWork.MedicalStates.GetByPatient(patientId, _specification)
               
                );
        }

        
    }
}
