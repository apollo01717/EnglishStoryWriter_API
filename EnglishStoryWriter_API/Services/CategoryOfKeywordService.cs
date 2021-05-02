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
    public class CategoryOfKeywordService : ICategoryOfKeywordService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryOfKeywordRepository _categoryOfKeywordRepository;

        public CategoryOfKeywordService(IMapper mapper, ICategoryOfKeywordRepository categoryOfKeywordRepository)
        {
            _mapper = mapper;
            _categoryOfKeywordRepository = categoryOfKeywordRepository;
        }
        public CategoryOfKeyword Create(CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO)
        {
            CategoryOfKeyword categoryOfKeyword = _mapper.Map<CategoryOfKeyword>(createCategoryOfKeywordDTO);
            return _categoryOfKeywordRepository.Create(categoryOfKeyword);
        }

        public void Delete(int id)
        {
            CategoryOfKeyword categoryOfKeyword = _categoryOfKeywordRepository.GetOne(id);
             
            if (categoryOfKeyword is null)
            {
                throw new NotFoundException("Story status not found");
            }
            _categoryOfKeywordRepository.Delete(categoryOfKeyword);
        }

        public IEnumerable<CategoryOfKeywordDTO> GetAll()
        {
            IList<CategoryOfKeyword> categoryOfKeywords = _categoryOfKeywordRepository.GetAll();
            return _mapper.Map<List<CategoryOfKeywordDTO>>(categoryOfKeywords);

        }

        public CategoryOfKeywordDTO GetOne(int id)
        {
            CategoryOfKeyword categoryOfKeyword = _categoryOfKeywordRepository.GetOne(id);
            if (categoryOfKeyword is null)
            {
                throw new NotFoundException("CategoryOfKeyword not found");
            }
            return _mapper.Map<CategoryOfKeywordDTO>(categoryOfKeyword);
        }

        public void Update(CreateCategoryOfKeywordDTO createCategoryOfKeywordDTO, int id)
        {
            CategoryOfKeyword categoryOfKeyword = _categoryOfKeywordRepository.GetOne(id);
            if (categoryOfKeyword is null)
            {
                throw new NotFoundException("CategoryOfKeyword status not found");
            }
            _categoryOfKeywordRepository.Update(categoryOfKeyword, createCategoryOfKeywordDTO);
        }
    }
}
