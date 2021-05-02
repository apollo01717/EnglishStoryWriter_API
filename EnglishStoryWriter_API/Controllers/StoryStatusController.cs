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
    public class StoryStatusController : ControllerBase
    {
        private readonly IStoryStatusService _storyStatusServie;

        public StoryStatusController(IStoryStatusService storyStatusService)
        {
            _storyStatusServie = storyStatusService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StoryStatusDTO>> GetAll()
        {
            return Ok(_storyStatusServie.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<StoryStatusDTO> GetOne([FromRoute] int id)
        {
            StoryStatusDTO storyStatusDTO = _storyStatusServie.GetOne(id);
            return Ok(storyStatusDTO);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateStoryStatusDTO statusDTO)
        {
            StoryStatus storyStatus = _storyStatusServie.Create(statusDTO);
            return Created($"/api/storystatus/{storyStatus.Id}", null);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromRoute] int id, [FromBody] CreateStoryStatusDTO statusDTO)
        {
            _storyStatusServie.Update(statusDTO, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _storyStatusServie.Delete(id);
            return NoContent();
        }
    }
}
