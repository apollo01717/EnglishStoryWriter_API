using EnglishStoryWriter_API.DTO;
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


    }
}
