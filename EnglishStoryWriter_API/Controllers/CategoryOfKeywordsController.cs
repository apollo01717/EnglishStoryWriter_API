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
    public class CategoryOfKeywordsController : ControllerBase
    {
        private readonly ICategoryOfKeywordService _categoryOfKeywordService;
        public CategoryOfKeywordsController(ICategoryOfKeywordService categoryOfKeywordService)
        {
            _categoryOfKeywordService = categoryOfKeywordService;
        }
        [HttpGet]
        public ActionResult<CategoryOfKeywordDTO> GetAll()
        {
            var categoryOfKeywords = _categoryOfKeywordService.GetAll();
            return Ok(categoryOfKeywords);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoryOfKeywordDTO> Get(int id)
        {
            var categoryOfKeyword = _categoryOfKeywordService.GetOne(id);
            return Ok(categoryOfKeyword);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO)
        {
            var categoryOfKeyword = _categoryOfKeywordService.Create(createCategoryOfKeywordDTO);
            return Created($"/api/categoryofkeyword/{categoryOfKeyword.Id}", null);
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO, int id)
        {
            _categoryOfKeywordService.Update(createCategoryOfKeywordDTO, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            _categoryOfKeywordService.Delete(id);
            return NoContent();
        }
    }
}
