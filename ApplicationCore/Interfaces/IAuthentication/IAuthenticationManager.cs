using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ApplicationDomain.Entities;

namespace ApplicationCore.Interfaces.IAuthentication
{
    public interface IAuthenticationManager
    {
        Task<Boolean> Authenticate(LoginInputDTO loginInputDTO);
        Task<IdentityResult> Register(RegisterInputDTO registerInputDTO);
        Task SignOut();
        Task SignIn(User user , bool isPersisted );
    }
}
