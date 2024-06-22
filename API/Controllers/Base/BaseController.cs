using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    public abstract class BaseController : ControllerBase
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

        protected String GetUserEmail()
        {
            return GetCurrentUser().Email;
        }

        protected String GetUserId() {
            return GetCurrentUser().Id;
        }

        #endregion Current User Details
    }
}
