using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public interface ILevelRepository
    {
        public IList<Level> GetAll();
        public Level GetOne(int id);
        public Level Create(Level level);
        public void Update(Level level, CreateLevelDTO createLevelDTO);
        public void Delete(Level level);
    }
}
