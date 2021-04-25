using EnglishStoryWriter_API.DTO;
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

        public StoryStatus GetOne(int id)
        {
            return _englishDbContext.StoryStatus.FirstOrDefault(s => s.Id == id);
        }

        public StoryStatus Create(StoryStatus storyStatus)
        {
            _englishDbContext.StoryStatus.Add(storyStatus);
            _englishDbContext.SaveChanges();
            return storyStatus;
        }

        public void Update(StoryStatus storyStatus,CreateStoryStatusDTO statusDTO)
        {
            storyStatus.Name = statusDTO.Name;
            _englishDbContext.SaveChanges();

        }
        public void Delete(StoryStatus storyStatus)
        {
            _englishDbContext.Remove(storyStatus);
            _englishDbContext.SaveChanges();
        }

    }
}
