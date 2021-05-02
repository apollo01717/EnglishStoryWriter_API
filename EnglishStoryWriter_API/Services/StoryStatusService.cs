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
            IList<StoryStatus> storyStatuses = _storyStatusRepository.GetAll();
            return _mapper.Map<List<StoryStatusDTO>>(storyStatuses);
        }
        
        public StoryStatusDTO GetOne(int id)
        {
            StoryStatus storyStatus = _storyStatusRepository.GetOne(id);
            if(storyStatus is null)
            {
                throw new NotFoundException("StoryStatus not found");
            }
          return  _mapper.Map<StoryStatusDTO>(storyStatus);
        }

        public StoryStatus Create(CreateStoryStatusDTO statusDTO)
        {
            StoryStatus storyStatus = _mapper.Map<StoryStatus>(statusDTO);
            _storyStatusRepository.Create(storyStatus);
            return storyStatus;
        }

        public void Update(CreateStoryStatusDTO statusDTO, int id)
        {
            StoryStatus storyStatus = _storyStatusRepository.GetOne(id);
            if(storyStatus is null)
            {
                throw new NotFoundException("Story status not found");
            }
            _storyStatusRepository.Update(storyStatus, statusDTO);
        }

        public void Delete(int id)
        {
            StoryStatus storyStatus = _storyStatusRepository.GetOne(id);
            if(storyStatus is null)
            {
                throw new NotFoundException("Story status not found");
            }
            _storyStatusRepository.Delete(storyStatus);
        }
    }
}
