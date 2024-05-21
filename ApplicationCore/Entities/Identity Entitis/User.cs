using Microsoft.AspNetCore.Identity;
using System;
namespace ApplicationCore.Entities
{
    public class User :IdentityUser
    {
        public DateTime CreationTime { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
