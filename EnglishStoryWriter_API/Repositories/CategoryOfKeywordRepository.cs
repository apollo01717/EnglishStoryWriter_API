using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class CategoryOfKeywordRepository : ICategoryOfKeywordRepository
    {
        private readonly EnglishDbContext _englishDbContext;
        public CategoryOfKeywordRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }
        public CategoryOfKeyword Create(CategoryOfKeyword categoryOfKeyword)
        {
            _englishDbContext.CategoryOfKeyword.Add(categoryOfKeyword);
            _englishDbContext.SaveChanges();
            return categoryOfKeyword;

        }

        public void Delete(CategoryOfKeyword categoryOfKeyword)
        {
            _englishDbContext.Remove(categoryOfKeyword);
            _englishDbContext.SaveChanges();
        }

        public IList<CategoryOfKeyword> GetAll()
        {
            return _englishDbContext.CategoryOfKeyword.ToList();
        }

        public CategoryOfKeyword GetOne(int id)
        {
            return _englishDbContext.CategoryOfKeyword.FirstOrDefault(c => c.Id == id);

        }

        public void Update(CategoryOfKeyword categoryOfKeyword, CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO)
        {
            categoryOfKeyword.Name = createCategoryOfKeywordDTO.Name;
            _englishDbContext.SaveChanges();
        }
    }
}
