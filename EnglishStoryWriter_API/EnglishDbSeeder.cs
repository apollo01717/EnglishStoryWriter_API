using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API
{
    public class EnglishDbSeeder
    {
        private readonly EnglishDbContext _dbContext;
        public EnglishDbSeeder(EnglishDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if (!_dbContext.StoryStatus.Any())
                {
                    var storyStatuses = GetStoryStatuses();
                    _dbContext.AddRange(storyStatuses);
                    _dbContext.SaveChanges();
                }
                
                if (!_dbContext.CategoryOfKeyword.Any())
                {
                    var categoryOfKeyword = GetCategoryOfKeyword();
                    _dbContext.AddRange(categoryOfKeyword);
                    _dbContext.SaveChanges();
                }
                
            }
        }

        private IEnumerable<StoryStatus> GetStoryStatuses()
        {
            var statuses = new List<StoryStatus>()
            {
              new StoryStatus()
              {
                Name = "Not started"

              },
              new StoryStatus()
              {
                  Name = "Draft"
              },
              new StoryStatus()
              {
                  Name = "Confirmed"
              },
                new StoryStatus()
              {
                  Name = "Rated"
              }
            };
            return statuses;
        }

        private IEnumerable<CategoryOfKeyword> GetCategoryOfKeyword()
        {
            var categoryOfKeywords = new List<CategoryOfKeyword>()
            {
              new CategoryOfKeyword()
              {
                Name = "Character"

              },
              new CategoryOfKeyword()
              {
                  Name = "Place"
              },
              new CategoryOfKeyword()
              {
                  Name = "Circumstance"
              }
            };
            return categoryOfKeywords;
        }
    } 
}
