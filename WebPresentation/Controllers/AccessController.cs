using ApplicationCore.Entities;
using ApplicationCore.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    [AllowAnonymous]

    public class AccessController : Controller
    {

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccessController(SignInManager<User> signInManager,
            UserManager<User> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string ErrorMessage { get; set; }

        public IActionResult Login(string returnUrl )
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
            public async Task<IActionResult> Login(LoginInuptModel Input)
            {
                Input.ReturnUrl ??= Url.Content("/Home/Index");

                ViewBag.ReturUrl = Input.ReturnUrl;

            if (ModelState.IsValid)
                {
                    // This doesn't count login failures towards account lockout
                    // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                    var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return Redirect(Input.ReturnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return View();
                    }
                }

                // If we got this far, something failed, redisplay form
                return View();
            }






        public IActionResult Register(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterationInputModel Input)
        {
            Input.ReturnUrl ??= Url.Content("/Home/Index");

            ViewBag.ReturUrl = Input.ReturnUrl;
            if (ModelState.IsValid)
            {
                var user = new User {
                    NormalizedEmail = Input.Email,
                    FirstName=Input.FirstName,
                    LastName=Input.LastName,
                    Avatar=Input.Avatar,
                    UserName = Input.Email,
                    Email = Input.Email,
                    Patient = Input.Patient,
                    CreationTime = DateTime.Now,
                    
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    result = await _userManager.AddToRoleAsync(user, "patient");
                }
                if (result.Succeeded)
                { 
                    
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(Input.ReturnUrl);
                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }

        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return LocalRedirect("/Home/Index");
            }
        }
    }
    }
