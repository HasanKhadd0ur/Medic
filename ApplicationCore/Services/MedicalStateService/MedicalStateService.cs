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
        private readonly PatientService _patientService;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private readonly MedicineWithIngredientsSpecification _medicineSpecification;
        
        public MedicalStateService(
            IUnitOfWork<MedicalState> medicalUnitOfWork,
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IUnitOfWork<Patient> patientUnitOfWork,
              IMapper Mapper
            ):base(medicalUnitOfWork,Mapper)
        {
            _specification = new MedicalStateWithMedicinesSpecification();
            _medicineUnitOfWork = medicineUnitOfWork;
            _patientService = new PatientService(patientUnitOfWork,medicalUnitOfWork,Mapper);
            _medicineSpecification = new MedicineWithIngredientsSpecification();
        }
        public MedicalStateModel AddToPateint(int patientId , MedicalStateModel medicalStateModel)
        {
            medicalStateModel.PatientId = patientId;
            
            var im =medicalStateModel;
            
            var r = _unitOfWork.Entity.Insert(_mapper.Map<MedicalState>(im));
            _unitOfWork.Save();
            return _mapper.Map<MedicalStateModel>(r);
        }

        
        public IEnumerable<MedicalStateModel> GetAllPatientMedicalStates(int patientId)
        {
           return _mapper.Map<IEnumerable<MedicalStateModel>>( _patientService.GetPatientMedicalStates(patientId));
        }

        
    }
}
