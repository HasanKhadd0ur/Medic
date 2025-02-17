﻿using ApplicationCore.DTOs;
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
using WebPresentation.Filters.ImageLoad;
using WebPresentation.Filters.ModelStateValidation;
using WebPresentation.Services;
using WebPresentation.ViewModels;

namespace WebPresentation.Controllers
{
    public class CRUDController<TDto,TVModel> : BaseController where TDto : DTOBase where TVModel : ViewModels.BaseViewModel
    {
        protected readonly IMapper _mapper;
        protected readonly IService<TDto> _service;
        private Func<TDto, bool> _criteriaProtected;
        protected Func<TDto, bool> criteria {
            get {
                if (_criteriaProtected == null) {
                    _criteriaProtected = GetCriteria(); 
                }
                return _criteriaProtected;        
            } set { _criteriaProtected = value; } }
   
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
        protected virtual Func<TDto,bool> GetCriteria() {
            return dto => true ; 
        }

        public async virtual Task<IActionResult> Index()
        {
            var DetailDto = await _service.GetByCriteria(GetCriteria());
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
                return View("NotFound");
            }
            else
            {
                TDto DetailDto = await _service.GetDetails((int)id);
                if (DetailDto is null)
                    return View("NotFound");
                if (criteria(DetailDto))
                {
                    TVModel model = _mapper.Map<TVModel>(DetailDto);
                    return View(model);
                }
                return View("NotFound");

            }
        }

        public async Task< IActionResult> Delete(int id)
        {

            TDto DetailDto = await _service.GetDetails(id);

            if (DetailDto == null || !criteria(DetailDto))
            {
                return PartialView("PartialNotFound");
            }
            TVModel model = _mapper.Map<TVModel>(DetailDto);
            return PartialView(model);
        }

        [HttpPost, ActionName("Delete")]
        public virtual  async Task<IActionResult> DeleteConfirmed(int id)
        {
            TDto DetailDto = await _service.GetDetails(id);

            if (DetailDto == null || !criteria(DetailDto))
            {
                return PartialView("PartialNotFound");
            }

            _service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return PartialView("PartialNotFound");
            }
            try
            {
                
                TDto tModel = await _service.GetDetails((int)id);
                if (tModel == null || !criteria(tModel))
                {
                    return PartialView("PartialNotFound");
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
        [ImageLoadFilter]
        public IActionResult Edit(int id, [FromForm]  TVModel viewModel)
        {
            if (id != viewModel.Id)
            {

                return PartialView("PartialNotFound");
            }
            
            TDto dto ;
            if (ModelState.IsValid)
            {
                
                try
                {

                    dto = _mapper.Map<TDto>(viewModel);
                    if (dto == null || !criteria(dto))
                    {
                        return PartialView("PartialNotFound");
                    }

                    dto = _service.Update(dto);

                }
                catch (DbUpdateConcurrencyException)
                {
                    return View("Error");

                }
                return Json(new { success = true, redirectUrl = Url.Action("Details", new { id = viewModel.Id }) });

            }

            return PartialView(viewModel);
        }

        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [StateValidationFilter]
        [ImageLoadFilter]
        public virtual IActionResult Create(TVModel viewModel, int id)
        {
            TDto dto = _mapper.Map<TDto>(viewModel);
            
            if (viewModel == null || !criteria(dto))
            {
                return PartialView(viewModel);
            }
            
            dto = _service.Create(dto);

            viewModel = _mapper.Map<TVModel>(dto);

            return Json(new { success = true, redirectUrl = Url.Action("Details", new { id = viewModel.Id }) });


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
                if (model is null || !criteria(model))
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
