using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using ApplicationCore.DTOs;
using WebPresentation.ViewModels;
using AutoMapper;

namespace WebPresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IngredientController : CRUDController<IngredientDTO,IngredientViewModel>
    {

        public IngredientController(
            UserManager<User> userManager,
            IIngredientService ingredientSercie,
            IMapper mapper
            ) : base(userManager,ingredientSercie,mapper)
        
        {

            
        }
        
    }
}
