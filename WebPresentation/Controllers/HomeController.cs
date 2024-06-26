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

namespace WebPresentation.Controllers
{

[Authorize(Roles ="patient")]
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
        public async Task<IActionResult> Index()
        {
            var t =await  getCurrentPatient();
            return View(t);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var t = await getCurrentPatient();
            if (id != t.Id) {
                return View("Error");
            }
            return View(t);
        }

        public async Task<IActionResult> Details(int? id ) {
            var t = await getCurrentPatient();
            return View(t);
        
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
