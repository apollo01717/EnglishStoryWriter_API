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
    public class StoryStatusService
        : BaseService<StoryStatus, StoryStatusDTO, CreateStoryStatusDTO>, IStoryStatusService
    {
        public StoryStatusService(IStoryStatusRepository storyStatusRepository, IMapper mapper)
            : base(storyStatusRepository, mapper)
        {

        }
    }
}
