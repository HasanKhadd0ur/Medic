using ApplicationCore.DTOs;
using ApplicationCore.Interfaces.IAuthentication;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Authentication
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthenticationManager(
            SignInManager<User> signInManager,
            UserManager<User> userManager
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<bool> Authenticate(LoginInputDTO loginInputDTO)
        {
            

                var result = await _signInManager.PasswordSignInAsync(loginInputDTO.Email, loginInputDTO.Password, loginInputDTO.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            

        }

        public async Task<IdentityResult> Register(RegisterInputDTO registerInputDTO)
        {
            var patient = new Patient {
                BIO =registerInputDTO.Patient.BIO              
            };
            var user = new User
            {
                NormalizedEmail = registerInputDTO.Email,
                FirstName = registerInputDTO.FirstName,
                LastName = registerInputDTO.LastName,
                Avatar = registerInputDTO.ImageName,
                UserName = registerInputDTO.Email,
                Email = registerInputDTO.Email,
                Patient =patient,
                CreationTime = DateTime.Now,

            };

            var result = await _userManager.CreateAsync(user, registerInputDTO.Password);
            if (result.Succeeded)
            {
                result = await _userManager.AddToRoleAsync(user, "patient");
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return IdentityResult.Success;
                }
                else {

                    return result;
                }
            }
        

            return result;
        }

        public async Task SignIn(User user, bool isPersisted)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);

        }

        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
