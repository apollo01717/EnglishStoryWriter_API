using AutoMapper;
using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Exceptions;
using EnglishStoryWriter_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public class StoryStatusService : IStoryStatusService
    {
        private readonly IStoryStatusRepository _storyStatusRepository;
        private readonly IMapper _mapper;
        public StoryStatusService(IStoryStatusRepository storyStatusRepository, IMapper mapper)
        {
            _storyStatusRepository = storyStatusRepository;
            _mapper = mapper;
        }


        public IEnumerable<StoryStatusDTO> GetAll()
        {
            var storyStatusDTOS = _storyStatusRepository.GetAll();
            return _mapper.Map<List<StoryStatusDTO>>(storyStatusDTOS);
        }
        
        public StoryStatusDTO GetOne(int id)
        {
            var storyStatus = _storyStatusRepository.GetOne(id);
            if(storyStatus is null)
            {
                throw new NotFoundException("StoryStatus not found");
            }
          return  _mapper.Map<StoryStatusDTO>(_storyStatusRepository.GetOne(id));
        }

        public StoryStatus Create(CreateStoryStatusDTO statusDTO)
        {
            var storyStatus = _mapper.Map<StoryStatus>(statusDTO);
            _storyStatusRepository.Create(storyStatus);
            return storyStatus;
        }
    }
}
