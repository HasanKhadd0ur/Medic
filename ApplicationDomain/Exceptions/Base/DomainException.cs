using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Exceptions
{
    public class DomainException : Exception
    {
         public DomainException(string businessMessage)
            : base(businessMessage)
        {
        }

        public DomainException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
