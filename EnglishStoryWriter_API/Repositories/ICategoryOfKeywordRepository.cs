using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public interface ICategoryOfKeywordRepository
    {
        public IList<CategoryOfKeyword> GetAll();
        public CategoryOfKeyword GetOne(int id);
        public CategoryOfKeyword Create(CategoryOfKeyword categoryOfKeyword);
        public void Update(CategoryOfKeyword categoryOfKeyword, CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO);
        public void Delete(CategoryOfKeyword categoryOfKeyword);
    }
}
