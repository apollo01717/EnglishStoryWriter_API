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
                if (!_dbContext.Criterion.Any())
                {
                    var criterion = GetCriterion();
                    _dbContext.AddRange(criterion);
                    _dbContext.SaveChanges();
                }
                if (!_dbContext.Level.Any())
                {
                    var levels = GetLevels();
                    _dbContext.AddRange(levels);
                    _dbContext.SaveChanges();
                } 
                if (!_dbContext.Role.Any())
                {
                    var roles = GetRoles();
                    _dbContext.AddRange(roles);
                    _dbContext.SaveChanges();
                }  
                if (!_dbContext.UserStatus.Any())
                {
                    var statuses = GetUserStatus();
                    _dbContext.AddRange(statuses);
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
        private IEnumerable<Criterion> GetCriterion()
        {
            var criterion = new List<Criterion>()
            {
              new Criterion()
              {
                Name = "Vocabulary"

              },
              new Criterion()
              {
                  Name = "Use of keywords"
              },
              new Criterion()
              {
                  Name = "Grammar"
              },
              new Criterion()
              {
                  Name = "Interesting of story"
              }
            };
            return criterion;
        }
        private IEnumerable<Level> GetLevels()
        {
            var levels = new List<Level>()
            {
              new Level()
              {
                Name = "A1"

              },
              new Level()
              {
                  Name = "A2"
              },
              new Level()
              {
                  Name = "B1"
              },
              new Level()
              {
                  Name = "B2"
              },
              new Level()
              {
                  Name = "C1"
              },
              new Level()
              {
                  Name = "C2"
              }
            };
            return levels;
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
              new Role()
              {
                Name = "Admin"

              },
              new Role()
              {
                  Name = "User"
              }
            };
            return roles;
        }
        private IEnumerable<UserStatus> GetUserStatus()
        {
            var statuses = new List<UserStatus>()
            {
              new UserStatus()
              {
                Name = "Active"

              },
              new UserStatus()
              {
                  Name = "Inactive"
              }
            };
            return statuses;
        }
    } 
}
