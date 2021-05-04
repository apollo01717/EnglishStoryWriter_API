using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface ILevelService
    {
        public IEnumerable<LevelDTO> GetAll();
        public LevelDTO GetOne(int id);
        public Level Create(CreateLevelDTO levelDTO);
        public void Update(CreateLevelDTO createLevelDTO, int id);
        public void Delete(int id);
    }
}
