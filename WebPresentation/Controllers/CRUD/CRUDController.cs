using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using ApplicationDomain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    public class CRUDController<TDto,TVModel> : BaseController where TDto : DTOBase where TVModel : ViewModels.BaseViewModel
    {
        protected readonly IMapper _mapper;
        protected readonly IService<TDto> _service;
        protected Func<TDto, bool> Criteria;
        public CRUDController(
            UserManager<User> userManager,
            IService<TDto> service,
            IMapper mapper
            )
            :base(userManager)
        {
            _mapper = mapper;
            _service = service;

        }

        public async virtual Task<IActionResult> Index()
        {
            var DetailDto = await _service.GetAll();
            IEnumerable<TVModel> model = _mapper.Map<IEnumerable<TVModel>>(DetailDto);

            return View(model);

        }

        public IActionResult DummyPartial(int id)
        {
            return PartialView(id);
        }

        [HttpPost]
        public IActionResult DummyPartial(int id, string s)
        {
                return RedirectToAction(nameof(Details),new { Id= id});
        }

        public async virtual Task<IActionResult> Details(int? id)
        {

            if (id is null)
            {
                return PartialView("_PartialNotFound");
            }
            else
            {
                TDto DetailDto = await _service.GetDetails((int)id);
                if (DetailDto is null)
                    return PartialView("_PartialNotFound");
                TVModel model = _mapper.Map<TVModel>(DetailDto);
                return View(model);
            }
        }

        public async Task< IActionResult> Delete(int id)
        {

            TDto DetailDto = await _service.GetDetails(id);

            if (DetailDto == null)
            {
                return View("NotFound");
            }
            TVModel model = _mapper.Map<TVModel>(DetailDto);
            return PartialView(model);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return PartialView("_PartialNotFound");
            }
            try
            {
                TDto tModel = await _service.GetDetails((int)id);
                if (tModel == null)
                {
                    return PartialView("_PartialNotFound");
                }
                TVModel model = _mapper.Map<TVModel>(tModel);

                return PartialView(model);

            }
            catch {
                return PartialView("PartialNotFound");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TVModel viewModel)
        {
            if (id != viewModel.Id)
            {

                return NotFound();
            }
            TDto dto = null;
            if (ModelState.IsValid)
            {
                try
                {
                    dto = _mapper.Map<TDto>(viewModel);
                    dto = _service.Update(dto);

                }
                catch (DbUpdateConcurrencyException)
                {
                    return View("Error");

                }
                return RedirectToAction("Details",new { id=dto.Id});
            }
            TVModel model = _mapper.Map<TVModel>(dto);

            return PartialView(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual IActionResult Create(TVModel viewModel, int id)
        {
            if (ModelState.IsValid)
            {

                TDto dto = _mapper.Map<TDto>(viewModel);
                dto= _service.Create(dto);
                viewModel = _mapper.Map<TVModel>(dto);

                return RedirectToAction("Details", new { id = viewModel.Id });

            }
            return View(viewModel);
        }
   
        #region json format 

        [HttpGet]
        public virtual async Task<IActionResult> GetDetails(int? id)
        {

            if (id is null)
            {
                return Ok(new { message= "No ID Provided" , result= "Faild" });
            }
            else
            {
                TDto model = await _service.GetDetails((int)id);
                if (model is null)
                    return Ok(new { message = "No Data Found ", result = "Faild" });

                return Ok(new { message = "Succed", result = model });
            }
        }


        [HttpGet]
        public virtual async Task<IActionResult> GetALL()
        {
            var all = await _service.GetAll();

            return  Ok(new { message = "Succed", result = all });

        }

        #endregion json format 
    }
}
