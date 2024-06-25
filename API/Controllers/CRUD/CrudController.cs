using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController<TModel> : BaseController where TModel : DTOBase
    {
        protected readonly IService<TModel> _service;

        public CrudController(
            IService<TModel> service,
 
            UserManager<User> userManager)
            : base(userManager)
        {
            _service = service;
        }

        [HttpGet]
        public async  virtual  Task<IActionResult> GetAll()
        {
            IEnumerable<TModel> models = await _service.GetAll();
            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var model = await _service.GetDetails(id);
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost("update")]
        public IActionResult Update(int id, TModel model )
        {
            if (id != model.Id)
                return Unauthorized();
            var ModifiedModel =  _service.Update(model); 
            return Ok(ModifiedModel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            _service.Delete(id);

            return Ok(new { mesage ="deleted"});
        }

        [HttpPut]
        public IActionResult Create(TModel model)
        {

            _service.Create(model);

            return Ok(new { mesage = "deleted" });
        }



    }
}
