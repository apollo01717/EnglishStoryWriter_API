using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface ICategoryOfKeywordService
    {
        public IEnumerable<CategoryOfKeywordDTO> GetAll();
        public CategoryOfKeywordDTO GetOne(int id);
        public CategoryOfKeyword Create(CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO);
        public void Update(CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO, int id);
        public void Delete(int id);
    }
}
