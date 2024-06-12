using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.DomainModel;

namespace WebPresentation.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller 
    {
        protected readonly UserManager<User> _userManager;
        public BaseController(UserManager<User> userManager ) {
            _userManager = userManager;
            
        }

        #region Current User Details  
        protected User GetCurrentUser() {
            User usr =  GetCurrentUserAsync().Result;
            return usr;
        }
        private Task<User> GetCurrentUserAsync()
        {
            return  _userManager.GetUserAsync(User);
        }
        protected String GetUserName() {
            return GetCurrentUser().UserName;
        }
        

        protected String GetUserId() {
            return GetCurrentUser().Id;
        }

        #endregion Current User Details
    }
}
