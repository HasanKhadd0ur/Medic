using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using WebPresentation.Models;
using ApplicationCore.Interfaces.IServices;
using ApplicationCore.DTOs;
using AutoMapper;
using WebPresentation.ViewModels;
using System.Threading.Tasks;
using WebPresentation.Filters.ImageLoad;
using Microsoft.EntityFrameworkCore;

namespace WebPresentation.Controllers
{


    public class HomeController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IPatientService _patientService;
        
        public HomeController(
                UserManager<User> userManager,
                IPatientService patientService,
                IMapper mapper
            ):base(userManager)
        {
            _mapper = mapper;
            _patientService = patientService;
            
        }

        private async Task<PatientViewModel> getCurrentPatient() {

            var userId = GetUserId();
            var patient =await  _patientService.GetByUserId(userId);
            return _mapper.Map<PatientViewModel>(patient);

        }
        [Authorize(Roles = "patient")]
        public async Task<IActionResult> Index()
        {
            var t =await  getCurrentPatient();
            return View(t);
        }
        [Authorize(Roles = "patient")]

        public async Task<IActionResult> Edit()
        {
            var t = await getCurrentPatient();
            

            return View(t);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ImageLoadFilter]
        public async Task<IActionResult>  Edit(int id, [FromForm] PatientViewModel viewModel)
        {
            if (id != viewModel.Id)
            {

                return NotFound();
            }
            PatientDTO dto;
            if (ModelState.IsValid)
            {
                try
                {

                    dto = _mapper.Map<PatientDTO>(viewModel);
                    dto = _patientService.Update(dto);

                    var user = await _userManager.FindByIdAsync(dto.UserId);
                    if (user != null)
                    {
                        user.Avatar = viewModel.ImageName != "" ? viewModel.ImageName : dto.User.Avatar;
                        user.PhoneNumber = dto.User.PhoneNumber;
                        user.LastName = dto.User.LastName;
                        user.FirstName = dto.User.FirstName;
                        
                        var result = await _userManager.UpdateAsync(user);
                        if (!result.Succeeded)
                        {
                            return View(viewModel);
                        }
                    }
                    //dto.User.Avatar= viewModel.ImageName != "" ? viewModel.ImageName :dto.User.Avatar;
                    
                    //dto.User.Patient = _mapper.Map<Patient>(dto);

                }
                catch (DbUpdateConcurrencyException)
                {
                    return View("Error");

                }
                return RedirectToAction("Details", new { id = viewModel.Id });
            }

            return View(viewModel);
        }

        [Authorize(Roles = "patient")]
        public async Task<IActionResult> Details() {
            var t = await getCurrentPatient();
            return View(t);
        
        }
        [AllowAnonymous]
        public  IActionResult NotFoundPage() {
            return View("NotFound");
        }

        [Authorize(Roles = "patient")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
