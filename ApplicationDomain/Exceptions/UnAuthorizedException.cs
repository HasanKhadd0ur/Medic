using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Exceptions
{
    public sealed class UnAuthorizedException : DomainException
    {
        public UnAuthorizedException() : this("Not found")
        {

        }

        public UnAuthorizedException(string message) : base(message)
        {

        }

    }
}