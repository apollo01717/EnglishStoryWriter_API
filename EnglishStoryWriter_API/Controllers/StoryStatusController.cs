using EnglishStoryWriter_API.DTO;
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
        public ActionResult<StoryStatusDTO> GetAll()
        {
            return Ok(_storyStatusServie.GetAll());
        }

        [HttpGet("/{id}")]
        public ActionResult<StoryStatusDTO> GetOne([FromRoute] int id)
        {
            var storyStatusDTO = _storyStatusServie.GetOne(id);
            if(storyStatusDTO is null)
            {
                return NotFound();
            }
            return Ok(storyStatusDTO);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateStoryStatusDTO statusDTO)
        {
            var storyStatus = _storyStatusServie.Create(statusDTO);
            return Created($"/api/storystatus/{storyStatus.Id}", null);
        }
    }
}
