using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Exceptions
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage)
            : base(businessMessage)
        {
        }

        internal DomainException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
