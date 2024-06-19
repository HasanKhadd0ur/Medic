using System.Collections.Generic;
using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Abstraction;
using ApplicationDomain.Specification;
using AutoMapper;
using ApplicationCore.DomainModel;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class MedicalStateService :ServiceBase<MedicalState ,MedicalStateModel>, IMedicalStateService
    {
        
        public MedicalStateService(
            IUnitOfWork<MedicalState> unitOfWork,
            IMapper Mapper
            ):base(unitOfWork,Mapper)
        {
            _specification = new MedicalStateWithMedicinesSpecification();
        
        }
        public MedicalStateModel AddToPateint(int patientId , MedicalStateModel medicalStateModel)
        {
            medicalStateModel.PatientId = patientId;
            
            var im =medicalStateModel;
            
            var r = _unitOfWork.Entity.Insert(_mapper.Map<MedicalState>(im));
            _unitOfWork.Commit();
            return _mapper.Map<MedicalStateModel>(r);
        }

        
        public async Task<IEnumerable<MedicalStateModel>> GetAllPatientMedicalStates(int patientId)
        {
           return _mapper.Map<IEnumerable<MedicalStateModel>>(

                await _unitOfWork.MedicalStates.GetByPatient(patientId, _specification)
               
                );
        }

        
    }
}
