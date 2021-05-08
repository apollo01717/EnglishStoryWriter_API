using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class StoryStatusRepository : BaseRepository<StoryStatus, CreateStoryStatusDTO>, IStoryStatusRepository
    {
        public StoryStatusRepository(EnglishDbContext englishDbContext) : base(englishDbContext)
        {
        }


    }
}
