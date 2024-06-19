using ApplicationDomain.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDomain.Entities
{
    public class EntityBase : IEntityBase<int> 
    {
        public int Id { get; set; }


    }
}
