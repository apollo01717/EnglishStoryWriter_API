using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public interface IStoryStatusRepository
    {
        public IList<StoryStatus> GetAll();
    }
}
