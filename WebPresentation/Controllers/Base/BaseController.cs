using ApplicationDomain.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebPresentation.Controllers
{
    [Authorize]
    public abstract class BaseController<T> : Controller where T : EntityBase
    {
        protected readonly UserManager<User> _userManager;
        protected readonly IService<T> _service;
        public BaseController(UserManager<User> userManager , IService<T> service) {
            _userManager = userManager;
            _service = service;
            
        }

        // Details 
        // 
        public virtual IActionResult Details(int?  id ) {

            if (id is null)
            {
                return NotFound();
            }
            else {
                T TModel = _service.GetDetails((int)id).Result;
                if (TModel is null)
                    return NotFound();
                return View(TModel);
            }
        }
        
        
        public IActionResult Delete(int id)
        {

            var TModel = _service.GetDetails(id);

            if (TModel == null)
            {
                return NotFound();
            }

            return View(TModel);
        }


        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index" );
        }

        // GET: Projects/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            T tModel = _service.GetDetails((int)id).Result;
            if (tModel == null)
            {
                return NotFound();
            }
            return View(tModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, T tModel)
        {
            if (id != tModel.Id)
            {

                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tModel=  _service.Update(tModel);

                }
                catch (DbUpdateConcurrencyException)
                {
                        return NotFound() ;
                   
                }
                return RedirectToAction("Index");
            }
            return View(tModel);
        }

        
        #region Current User Details  
        public User GetCurrentUser() {
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

        #endregion Current User Details
    }
}
