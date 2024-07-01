using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class LoginInputDTO : DTOBase
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
        public String ReturnUrl { get; set; }

    }
}
