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
    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<Patient> _patientUnitOfWork;
        private readonly IUnitOfWork<MedicalState> _medicalStateUnitOfWork;
        private PatientMedicinesSpecification _patientMedicinesSpecification;
        private MedicalStateSpecification _medicalStateSpecification;

        public PatientService(
            IUnitOfWork<Patient> patientUnitOfWork,
            IUnitOfWork<MedicalState> medicalStateUnitOfWork,
            IMapper mapper )
        {
            _mapper = mapper;
            _patientUnitOfWork = patientUnitOfWork;
            _medicalStateUnitOfWork = medicalStateUnitOfWork;
            _patientMedicinesSpecification = new PatientMedicinesSpecification();
            _medicalStateSpecification = new MedicalStateSpecification();
        }
        
        public IEnumerable<MedicalStateModel> GetPatientMedicalStates(int patientId) {

            return _mapper.Map<IEnumerable<MedicalStateModel>>( _patientUnitOfWork.Entity
                .GetById(
                patientId,_patientMedicinesSpecification
                ).Result.MedicalStates.AsEnumerable());

        }
        public async Task< MedicalStateModel> GetMedicalStateDetails(int id)
        {
           
            return _mapper.Map<MedicalStateModel>(await  _medicalStateUnitOfWork.Entity.GetById(id,_medicalStateSpecification));

        }
        public async Task<IEnumerable<PatientModel>> GetAll() {
            return _mapper.Map < IEnumerable < PatientModel >> (await _patientUnitOfWork.Entity.GetAll(_patientMedicinesSpecification));
        }
        public void AddMedicalState (int patientId, MedicalStateModel medicalState) {
            var ptient = _patientUnitOfWork.Entity.GetById(patientId,_patientMedicinesSpecification).Result;
            
            
            ptient.MedicalStates.Add(_mapper.Map<MedicalState>(medicalState));
            
            _patientUnitOfWork.Entity.Update(ptient);
            _patientUnitOfWork.Save();
        }
        public async  Task<PatientModel> GetDetails(int id)
        {
            return _mapper.Map < PatientModel>(await _patientUnitOfWork.Entity.GetById(id, _patientMedicinesSpecification));

        }
        public void Insert(PatientModel patient)
        {

            _patientUnitOfWork.Entity.Insert(_mapper.Map<Patient>(patient));

            _patientUnitOfWork.Save();
        }

        public PatientModel Create(PatientModel patient) {

            var p =_patientUnitOfWork.Entity.Insert(_mapper.Map<Patient>(patient));
            return _mapper.Map<PatientModel>(p);
        }
        public PatientModel Update(PatientModel patient)
        {


            var p =_patientUnitOfWork.Entity.Update(_mapper.Map<Patient>(patient));
            _patientUnitOfWork.Save();
            return _mapper.Map < PatientModel > (p);
        }
        public void Delete(int id)
        {

            _patientUnitOfWork.Entity.Delete(id);
            _patientUnitOfWork.Save();
        }

        public bool PatientExists(int id)
        {
            return _patientUnitOfWork.Entity.GetById(id) is null ? false : true;
        }


    }
}
