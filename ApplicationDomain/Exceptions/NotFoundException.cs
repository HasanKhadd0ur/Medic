using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Exceptions
{
    public  class NotFoundException : DomainException
    {
        public NotFoundException() : this("Not found")
        {

        }

        public NotFoundException(string message) : base(message)
        {

        }

    }
}