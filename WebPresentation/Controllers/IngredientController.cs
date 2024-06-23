using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using ApplicationCore.DomainModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebPresentation.Controllers
{
    [Authorize(Roles = "Admin")]
    public class IngredientController : CRUDController<IngredientModel>
    {

        public IngredientController(UserManager<User> userManager,
            IIngredientService ingredientSercie
            ) : base(userManager,ingredientSercie)
        
        {

            
        }
        public async Task<IActionResult> GetIngredients()
        {
            var s = await _service.GetAll();
            return Ok(s);

        }


    }
}
