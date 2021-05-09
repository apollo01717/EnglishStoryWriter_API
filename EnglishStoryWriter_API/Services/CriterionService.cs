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
    public class CriterionService 
        : BaseService<Criterion, CriterionDTO, CreateCriterionDTO>, ICriterionService
    {
        public CriterionService(ICriterionRepository criterionRepository, IMapper mapper)
            :base (criterionRepository, mapper)
        {

        }
       
    }
}
