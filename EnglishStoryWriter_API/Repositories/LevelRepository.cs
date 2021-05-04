using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private readonly EnglishDbContext _englishDbContext;
        public LevelRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }
        public Level Create(Level level)
        {
            _englishDbContext.Level.Add(level);
            _englishDbContext.SaveChanges();
            return level;
        }

        public void Delete(Level level)
        {
            _englishDbContext.Level.Remove(level);
        }

        public IList<Level> GetAll()
        {
            return _englishDbContext.Level.ToList();
        }

        public Level GetOne(int id)
        {
            return _englishDbContext.Level.FirstOrDefault();
        }

        public void Update(Level level, CreateLevelDTO createLevelDTO)
        {
            level.Name = createLevelDTO.Name;
            _englishDbContext.SaveChanges();
        }
    }
}
