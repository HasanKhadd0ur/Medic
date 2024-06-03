using Microsoft.AspNetCore.Identity;
using System;
namespace ApplicationDomain.Entities
{
    public class User :IdentityUser
    {
        public DateTime CreationTime { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Avatar { get; set; }

        public Patient Patient { get; set; }
    }
}
