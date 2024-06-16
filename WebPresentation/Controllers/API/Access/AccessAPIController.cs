using ApplicationCore.Interfaces.IServices;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebPresentation.ViewModel.Identity;

namespace WebPresentation.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccessAPIController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IPatientService _patientSerivce;

        public AccessAPIController(UserManager<User> userManager,
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
                return Ok(new { message = "Registration successful" });
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
                return Ok(new {message= "ok added " });
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


        [HttpGet("log")]
        public IActionResult i()
        {
            return Ok(new { message = "Logout successful" });
        }
        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new { message = "Logout successful" });
        }
    }

}