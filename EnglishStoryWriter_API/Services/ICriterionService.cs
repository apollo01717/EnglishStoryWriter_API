using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface ICriterionService
    {
        public IEnumerable<CriterionDTO> GetAll();
        public CriterionDTO GetOne(int id);
        public Criterion Create(CreateCriterionDTO createCriterionDTO);
        public void Update(CreateCriterionDTO createCriterionDTO, int id);
        public void Delete(int id);
    }
}
