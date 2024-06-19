using ApplicationCore.DomainModel;
using ApplicationCore.Interfaces;
using ApplicationDomain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudAPIController<TModel> : BaseController where TModel : DomainBase
    {
        protected readonly IService<TModel> _service;

        public CrudAPIController(
            IService<TModel> service,
 
            UserManager<User> userManager)
            : base(userManager)
        {
            _service = service;
        }

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

        [HttpPut("delete")]
        public IActionResult Delete(int id)
        {

            _service.Delete(id);

            return Ok(new { mesage ="deleted"});
        }

        [HttpPost("create")]
        public IActionResult Create(TModel model)
        {

            _service.Create(model);

            return Ok(new { mesage = "deleted" });
        }



    }
}
