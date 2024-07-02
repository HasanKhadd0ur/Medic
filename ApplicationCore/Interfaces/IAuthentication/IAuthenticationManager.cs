using ApplicationCore.DTOs;
using System;
using System.Threading.Tasks;
using ApplicationDomain.Entities;

namespace ApplicationCore.Interfaces.IAuthentication
{
    public interface IAuthenticationManager
    {
        Task<Boolean> Authenticate(LoginInputDTO loginInputDTO);
        Task<AuthenticationResult> Register(RegisterInputDTO registerInputDTO);
        Task SignOut();
        Task SignIn(User user , bool isPersisted );
        Task<AuthenticationResult> ChangePassword(ChangePasswordRequest changePasswordRequest); 
    }
}
