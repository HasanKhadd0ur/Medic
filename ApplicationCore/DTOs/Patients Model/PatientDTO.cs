using ApplicationDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class PatientDTO : DTOBase
    {


        public String  UserId { get; set; }
        public User User { get; set; }
        public String BIO { get; set; }

        public ICollection<MedicalStateDTO> MedicalStates { get; set; }
    }
}
