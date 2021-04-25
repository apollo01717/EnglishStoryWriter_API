using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface IStoryStatusService
    {
        public IEnumerable<StoryStatusDTO> GetAll();
        public StoryStatusDTO GetOne(int id);
        public StoryStatus Create(CreateStoryStatusDTO statusDTO);
        public void Update(CreateStoryStatusDTO statusDTO, int id);
        public void Delete(int id);

    }
}
