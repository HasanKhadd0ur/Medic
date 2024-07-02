using ApplicationDomain.Entities;
using WebPresentation.ViewModel.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebPresentation.Filters.ImageLoad;
using AutoMapper;
using ApplicationCore.Interfaces.IAuthentication;
using ApplicationCore.DTOs;
using WebPresentation.ViewModels;

namespace WebPresentation.Controllers
{
    [AllowAnonymous]

    public class AccessController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IAuthenticationManager _authenticationManager;
        
        public AccessController(IAuthenticationManager authenticationManager,
            IMapper mapper,
            UserManager<User> userManager ):base(userManager)
        {
            _mapper = mapper;
            _authenticationManager = authenticationManager;
        }

        public IActionResult Login(string returnUrl )
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        public IActionResult Register(string returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginInuptModel Input)
        {
            Input.ReturnUrl ??= Url.Content("/Home/Index");

            ViewBag.ReturUrl = Input.ReturnUrl;

            if (ModelState.IsValid){
                LoginInputDTO loginInupt = _mapper.Map<LoginInputDTO>(Input);
                 
                var result = await _authenticationManager.Authenticate(loginInupt);
                if (result)
                {
                    return Redirect(Input.ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
            }

            return View();
        }

        [HttpPost]
        [ImageLoadFilter]
        public async Task<IActionResult> Register(RegisterationInputModel Input)
        {
            Input.ReturnUrl ??= Url.Content("/Home/Index");

            ViewBag.ReturUrl = Input.ReturnUrl;
            if (ModelState.IsValid)
            {
                RegisterInputDTO registerInput = _mapper.Map<RegisterInputDTO>(Input);
                
                var result = await _authenticationManager.Register(registerInput);
              
                if (result.Success)
                { 
                    return LocalRedirect(Input.ReturnUrl);
                    
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error);
                }
            }

            return View();
        }

        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _authenticationManager.SignOut();
            if (returnUrl != null)
            {
                return Redirect(returnUrl);
            }
            else
            {
                return Redirect("/Home/Index");
            }
        }

        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var dto = _mapper.Map<ChangePasswordRequest>(model);
            dto.Email = GetCurrentUser().Email;
            var result =await _authenticationManager.ChangePassword(dto);
            if (!result.Success)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error);
                }
                return View(model);
            }

         
            return RedirectToAction("index","home");
        }

    }

}
