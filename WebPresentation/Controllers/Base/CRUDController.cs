using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    public class CRUDController<T> : BaseController where T : DomainBase
    {
        protected readonly IService<T> _service;
        public CRUDController(UserManager<User> userManager, IService<T> service)
            :base(userManager)
        {

            _service = service;

        }

        public virtual IActionResult Details(int? id)
        {

            if (id is null)
            {
                return View("NotFound");
            }
            else
            {
                T TModel = _service.GetDetails((int)id).Result;
                if (TModel is null)
                    return View("NotFound");
                return View(TModel);
            }
        }


        public IActionResult Delete(int id)
        {

            var TModel = _service.GetDetails(id);

            if (TModel == null)
            {
                return View("NotFound");
            }

            return View(TModel);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: Projects/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            T tModel = _service.GetDetails((int)id).Result;
            if (tModel == null)
            {
                return View("NotFound");
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
                    tModel = _service.Update(tModel);

                }
                catch (DbUpdateConcurrencyException)
                {
                    return View("Error");

                }
                return RedirectToAction("Index");
            }
            return View(tModel);
        }
    }
}
