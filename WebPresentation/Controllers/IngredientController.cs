using ApplicationDomain.Entities;
using ApplicationCore.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ApplicationCore.DomainModel;

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



        
    }
}
