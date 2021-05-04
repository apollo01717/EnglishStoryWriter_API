using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;
        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<LevelDTO>> GetAll()
        {
            return Ok(_levelService.GetAll());
        }

        [HttpGet("id")]
        public ActionResult<LevelDTO> GetOne(int id)
        {
            return Ok(_levelService.GetOne(id));
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateLevelDTO createLevelDTO)
        {
            Level level = _levelService.Create(createLevelDTO);
            return Created($"/api/level/{level.Id}", null);
        }

        [HttpPut]
        public ActionResult Update([FromRoute] int id, [FromBody] CreateLevelDTO createLevelDTO)
        {
            _levelService.Update(createLevelDTO, id);
            return Ok();
        }

        [HttpDelete("id")]
        public ActionResult Delete([FromRoute] int id)
        {
            _levelService.Delete(id);
            return NoContent();
        }
    }
}
