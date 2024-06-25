using API.Models;
using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccessController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IPatientService _patientSerivce;

        public AccessController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            IPatientService patientService):base(userManager)
        {

            _signInManager = signInManager;
            _patientSerivce = patientService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationInputModel Input)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var user = new User
            {
                NormalizedEmail = Input.Email,
                FirstName = Input.FirstName,
                LastName = Input.LastName,
                Avatar = Input.Avatar,
                UserName = Input.Email,
                Email = Input.Email,
                Patient = Input.Patient,
                CreationTime = DateTime.Now,

            };

            var result = await _userManager.CreateAsync(user, Input.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                PatientDTO p =await  _patientSerivce.GetByUserEmail(Input.Email);

                return Ok(new {patient =p});
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginInuptModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                PatientDTO p = await _patientSerivce.GetByUserEmail(model.Email);

                return Ok(new
                {
                    message = "Registration successful"
                  ,
                   patient = p
                });
            }

            if (result.IsLockedOut)
            {
                return Forbid("User is locked out.");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Unauthorized(ModelState);
            }
        }


        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new { message = "Logout successful" });
        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            return Ok(new { message = "log successful" });
        }
    }
}