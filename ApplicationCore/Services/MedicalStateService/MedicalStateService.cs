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
    public class MedicalStateService : IMedicalStateService
    {
        private readonly IUnitOfWork<MedicalState> _MedicalStateUnitOfWork;
        private readonly PatientService _patientService;
        private readonly IUnitOfWork<Medicine> _medicineUnitOfWork;
        private readonly MedicalStateSpecification _MedicalStateSpecification;
        private readonly MedicineIngredientSpecification _medicineSpecification;
        private readonly IMapper _mapper;

        public MedicalStateService(
            IUnitOfWork<MedicalState> medicalUnitOfWork,
            IUnitOfWork<Medicine> medicineUnitOfWork,
            IUnitOfWork<Patient> patientUnitOfWork,
              IMapper Mapper
            )
        {
            _MedicalStateUnitOfWork = medicalUnitOfWork;
            _MedicalStateSpecification = new MedicalStateSpecification();
            _medicineUnitOfWork = medicineUnitOfWork;
            _patientService = new PatientService(patientUnitOfWork,medicalUnitOfWork,Mapper);
            _medicineSpecification = new MedicineIngredientSpecification();
            _mapper = Mapper;
        }
        public MedicalStateModel Add(int patientId , MedicalStateModel medicalStateModel)
        {
            //var im = Create(medicalStateModel);
            //            _patientService.AddMedicalState(patientId ,_mapper.Map<MedicalState>( im));
            medicalStateModel.PatientId = patientId;
            var im =medicalStateModel;
            
            var r = _MedicalStateUnitOfWork.Entity.Insert(_mapper.Map<MedicalState>(im));
            _MedicalStateUnitOfWork.Save();
            return _mapper.Map<MedicalStateModel>(r);
        }
        public MedicalStateModel Create(MedicalStateModel medicalStateModel ) {

            var medicalState = _mapper.Map<MedicalState>(medicalStateModel);
           var e = _MedicalStateUnitOfWork.Entity.Insert(medicalState);
            _MedicalStateUnitOfWork.Save();
            return _mapper.Map<MedicalStateModel>(e);
           
        
        }

        public void AddMedicine(int MedicalStateId, int medicineId)
        {
           var m =  _MedicalStateUnitOfWork.Entity.GetById(MedicalStateId, _MedicalStateSpecification).Result;
            if (m.Medicines is null)
                m.Medicines = new List<Medicine>();
            var d = _medicineUnitOfWork.Entity.GetById(medicineId,_medicineSpecification ).Result;
            m.Medicines.Add(d );

            _MedicalStateUnitOfWork.Entity.Update(m);
            _MedicalStateUnitOfWork.Save();
        }
        public void RemoveMedicine(int MedicalStateId, int medicineId)
        {
            var m = _MedicalStateUnitOfWork.Entity.GetById(MedicalStateId, _MedicalStateSpecification).Result;
            if (m.Medicines is null)
                m.Medicines = new List<Medicine>();
            var d = _medicineUnitOfWork.Entity.GetById(medicineId, _medicineSpecification).Result;
            m.Medicines.Remove(d);

            _MedicalStateUnitOfWork.Entity.Update(m);
            _MedicalStateUnitOfWork.Save();
        }

        public void Delete(int id)
        {
            _MedicalStateUnitOfWork.Entity.Delete(id);
            _MedicalStateUnitOfWork.Save();
        }

        public async Task<IEnumerable<MedicalStateModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<MedicalStateModel>>(await _MedicalStateUnitOfWork.Entity.GetAll(_MedicalStateSpecification));
        }
        public IEnumerable<MedicalStateModel> GetAllPatientMedicalStates(int patientId)
        {
           return _mapper.Map<IEnumerable<MedicalStateModel>>( _patientService.GetPatientMedicalStates(patientId));
        }

        public async Task<MedicalStateModel> GetDetails(int MedicalStateId)
        {
            return _mapper.Map<MedicalStateModel>(await _patientService.GetMedicalStateDetails(MedicalStateId));
        }

        public MedicalStateModel Update(MedicalStateModel MedicalStateModel)
        {
            var MedicalState = _mapper.Map<MedicalState>(MedicalStateModel);
           var r = _MedicalStateUnitOfWork.Entity.Update(MedicalState);
           
           _MedicalStateUnitOfWork.Save();
            return _mapper.Map<MedicalStateModel>(r); 
        }
    }
}
