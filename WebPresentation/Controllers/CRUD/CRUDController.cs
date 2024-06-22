using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces;
using ApplicationDomain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    public class CRUDController<T> : BaseController where T : DomainBase
    {
        protected readonly IService<T> _service;
        public CRUDController(
            UserManager<User> userManager,
            IService<T> service
            )
            :base(userManager)
        {

            _service = service;

        }
        public async virtual Task<IActionResult> Details(int? id)
        {

            if (id is null)
            {
                return View("NotFound");
            }
            else
            {
                T TModel = await _service.GetDetails((int)id);
                if (TModel is null)
                    return View("NotFound");
                return View(TModel);
            }
        }


        public async Task< IActionResult> Delete(int id)
        {

            var TModel = await _service.GetDetails(id);

            if (TModel == null)
            {
                return View("NotFound");
            }

            return View(TModel);
        }

        public async virtual Task<IActionResult> Index()
        {
            var s = await _service.GetAll();
            return View(s);
        }


        [HttpPost, ActionName("Delete")]
     //   [ValidateAntiForgeryToken]
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
                return RedirectToAction("Details",new { id=tModel.Id});
            }
            return View(tModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Create(T viewModel, int id)
        {
            if (ModelState.IsValid)
            {

                
                viewModel= _service.Create(viewModel);
                return RedirectToAction("Details", new { id = viewModel.Id });

            }
            return View(viewModel);
        }
    }
}
