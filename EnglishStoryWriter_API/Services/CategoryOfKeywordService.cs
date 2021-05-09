using AutoMapper;
using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Exceptions;
using EnglishStoryWriter_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public class CategoryOfKeywordService
        : BaseService<CategoryOfKeyword, CategoryOfKeywordDTO, CreateCategoryOfKeywordDTO>, ICategoryOfKeywordService
    {

        public CategoryOfKeywordService(ICategoryOfKeywordRepository categoryOfKeywordRepository, 
            IMapper mapper) : base(categoryOfKeywordRepository, mapper)
        {
        }
    
    }
}
