using ApplicationCore.DomainModel;
using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IServices
{
    public interface IMedicalStateService : IService<MedicalStateModel>
    {
        public IEnumerable<MedicalStateModel> GetAllPatientMedicalStates(int patientId);
        public MedicalStateModel AddToPateint(int patientId , MedicalStateModel medicalState);
        
      
    }
}
