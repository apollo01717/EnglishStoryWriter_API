using AutoMapper;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Exceptions;
using EnglishStoryWriter_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public abstract class BaseService<T, Dto, CreateDto> : IBaseService<T, Dto, CreateDto>
    {
        protected IBaseRepository<T, CreateDto> _baseRepository;
        protected IMapper _mapper;
        public BaseService(IBaseRepository<T, CreateDto> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public T Create(CreateDto createDto)
        {
            T element = _mapper.Map<T>(createDto);
            return _baseRepository.Create(element);
        }

        public void Delete(int id)
        {
            T element = _baseRepository.GetOne(id);
            _baseRepository.Delete(element);
        }

        public IEnumerable<Dto> GetAll()
        {
            IList<T> elements = _baseRepository.GetAll();
            return _mapper.Map<List<Dto>>(elements);
        }

        public Dto GetOne(int id)
        {
            T element = GetOneElement(id);
            return _mapper.Map<Dto>(element);
        }

        private T GetOneElement(int id)
        {
            T element = _baseRepository.GetOne(id);
            if(element is null)
            {
                throw new NotFoundException("Element not found");
            }
            return element;
        }

        public void Update(CreateDto createDto, int id)
        {
            throw new NotImplementedException();
        }
    }
}
