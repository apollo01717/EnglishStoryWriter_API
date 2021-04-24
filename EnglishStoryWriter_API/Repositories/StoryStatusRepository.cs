using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class StoryStatusRepository : IStoryStatusRepository
    {
        private readonly EnglishDbContext _englishDbContext;
        public StoryStatusRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }
        public IList<StoryStatus> GetAll()
        {
            return _englishDbContext.StoryStatus.ToList();
        }
    }
}
