using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class ChangePasswordRequest
    {
        public String Email { get; set; }
        public String NewPassword { get; set; }
        public String CurrentPassword { get; set; }

    }
}
