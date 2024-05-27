using ApplicationCore.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        private readonly UserManager<User> _userManager;

        public BaseController(UserManager<User> userManager) {
            _userManager = userManager;
            
        }
        public  User GetCurrentUser() {
            User usr =  GetCurrentUserAsync().Result;
            return usr;
        }
        private Task<User> GetCurrentUserAsync()
        {
            return  _userManager.GetUserAsync(User);
        }
        public String GetUserName() {
            return GetCurrentUser().UserName;
        }

        public String GetUserId() {
            return GetCurrentUser().Id;
        }
        
    }
}
