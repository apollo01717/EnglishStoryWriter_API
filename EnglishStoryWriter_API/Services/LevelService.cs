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
    public class LevelService : BaseService<Level, LevelDTO, CreateLevelDTO>, ILevelService
    {

        public LevelService(ILevelRepository levelRepository, IMapper mapper) : base (levelRepository, mapper)
        {

        }
    }
}
