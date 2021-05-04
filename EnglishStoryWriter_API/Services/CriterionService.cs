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
    public class CriterionService : ICriterionService
    {
        private readonly ICriterionRepository _criterionRepository;
        private readonly IMapper _mapper;
        public CriterionService(ICriterionRepository criterionRepository, IMapper mapper)
        {
            _criterionRepository = criterionRepository;
            _mapper = mapper;
        }
        public Criterion Create(CreateCriterionDTO createCriterionDTO)
        {
            Criterion criterion = _mapper.Map<Criterion>(createCriterionDTO);
            return _criterionRepository.Create(criterion);
        }

        public void Delete(int id)
        {
            Criterion criterion = _criterionRepository.GetOne(id);
            _criterionRepository.Delete(criterion);
        }

        public IEnumerable<CriterionDTO> GetAll()
        {
            IList<Criterion> criteria = _criterionRepository.GetAll();
            return _mapper.Map<List<CriterionDTO>>(criteria);
        }

        public CriterionDTO GetOne(int id)
        {
            Criterion criterion = GetCriterionById(id);
            return _mapper.Map<CriterionDTO>(criterion);
        }

        public void Update(CreateCriterionDTO createCriterionDTO, int id)
        {
            Criterion criterion = GetCriterionById(id);
            _criterionRepository.Update(criterion, createCriterionDTO);
        }

        private Criterion GetCriterionById(int id)
        {
            Criterion criterion = _criterionRepository.GetOne(id);
            if (criterion is null)
            {
                throw new NotFoundException("Criterion not found");
            }
            return criterion;
        }
    }
}
