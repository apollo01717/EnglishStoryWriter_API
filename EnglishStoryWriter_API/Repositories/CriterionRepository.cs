using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class CriterionRepository : ICriterionRepository
    {
        private readonly EnglishDbContext _englishDbContext;
        public CriterionRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }
        public Criterion Create(Criterion criterion)
        {
            _englishDbContext.Add(criterion);
            _englishDbContext.SaveChanges();
            return criterion;
        }

        public void Delete(Criterion criterion)
        {
            _englishDbContext.Remove(criterion);
            _englishDbContext.SaveChanges();
        }

        public IList<Criterion> GetAll()
        {
            return _englishDbContext.Criterion.ToList();
        }

        public Criterion GetOne(int id)
        {
            return _englishDbContext.Criterion.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Criterion criterion, CreateCriterionDTO createCriterionDTO)
        {
            criterion.Name = createCriterionDTO.Name;
            _englishDbContext.SaveChanges();
        }
    }
}
