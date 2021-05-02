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
    public class CriterionController : ControllerBase
    {

        private readonly ICriterionService _criterionService;
        public CriterionController(ICriterionService criterionService)
        {
            _criterionService = criterionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CriterionDTO>> GetAll()
        {
            IEnumerable<CriterionDTO> criterionDTOs = _criterionService.GetAll();
            return Ok(criterionDTOs);
        }
        
        [HttpGet("id")]
        public ActionResult<CriterionDTO> GetOne([FromRoute] int id)
        {
            CriterionDTO criterionDTO = _criterionService.GetOne(id);
            return Ok(criterionDTO);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateCriterionDTO createCriterionDTO)
        {
            Criterion criteron = _criterionService.Create(createCriterionDTO);
            return Created($"/api/criterion/{criteron.Id}", null);
        }

        [HttpPut("id")]
        public ActionResult Update([FromBody] CreateCriterionDTO createCriterionDTO, [FromRoute] int id) 
        {
            _criterionService.Update(createCriterionDTO, id);
            return Ok();
        }

        [HttpDelete("id")]
        public ActionResult Delete([FromRoute] int id)
        {
            _criterionService.Delete(id);
            return NoContent();
        }
    }
}
