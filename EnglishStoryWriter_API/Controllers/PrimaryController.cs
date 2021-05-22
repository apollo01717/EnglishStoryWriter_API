using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public abstract class PrimaryController<T, Dto, CreateDto> : ControllerBase where T : BaseEntity
    {
        protected readonly IBaseService<T, Dto, CreateDto> _service;

        public PrimaryController(IBaseService<T, Dto, CreateDto> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Dto>> GetAll()
        {
            IEnumerable<Dto> dtos = _service.GetAll();
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public ActionResult<Dto> GetOne([FromRoute] int id)
        {
            Dto dto = _service.GetOne(id);
            return Ok(dto);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([FromBody] CreateDto createDto)
        {
            T element = _service.Create(createDto);
            return Created($"/api/criterion/{element.Id}", null);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Update([FromBody] CreateDto createDto, [FromRoute] int id)
        {
            _service.Update(createDto, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete([FromRoute] int id)
        {
            _service.Delete(id);
            return NoContent();
        }

    }
}
