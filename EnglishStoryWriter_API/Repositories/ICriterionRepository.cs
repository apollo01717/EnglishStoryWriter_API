using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public interface ICriterionRepository
    {
        public IList<Criterion> GetAll();
        public Criterion GetOne(int id);
        public Criterion Create(Criterion criterion);
        public void Update(Criterion criterion, CreateCriterionDTO createCriterionDTO);
        public void Delete(Criterion criterion);
    }
}
