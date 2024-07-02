using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class AuthenticationResult
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }

        public IEnumerable<string> Errors { get; set; }

        public AuthenticationResult(bool status)
        {
            Errors = new List<string>();
            Success = status;
        }

        public void AddError(string error)
        {
            ((List<string>)Errors).Add(error);
        }
    }
}
