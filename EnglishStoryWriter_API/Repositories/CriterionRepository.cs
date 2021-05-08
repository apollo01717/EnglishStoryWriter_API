using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class CriterionRepository : BaseRepository<Criterion, CreateCriterionDTO>, ICriterionRepository
    {

        public CriterionRepository(EnglishDbContext englishDbContext) : base(englishDbContext)
        {

        }


        
    }
}
