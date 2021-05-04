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
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository _levelRepository;
        private readonly IMapper _mapper ;
        public LevelService(ILevelRepository levelRepository, IMapper mapper)
        {
            _levelRepository = levelRepository;
            _mapper = mapper;
        }

        public Level Create(CreateLevelDTO createLevelDTO)
        {
            Level level = _mapper.Map<Level>(createLevelDTO);
            return _levelRepository.Create(level);

        }

        public void Delete(int id)
        {
            Level level = GetLevelById(id);
            _levelRepository.Delete(level);
        }

        public IEnumerable<LevelDTO> GetAll()
        {
            return _mapper.Map<IList<LevelDTO>>(_levelRepository.GetAll());
        }

        public LevelDTO GetOne(int id)
        {
            Level level = GetLevelById(id);
            return _mapper.Map<LevelDTO>(level);
        }

        public void Update(CreateLevelDTO createLevelDTO, int id)
        {
            Level level = GetLevelById(id);
            _levelRepository.Update(level, createLevelDTO);
        }

        private Level GetLevelById(int id)
        {
            Level level = _levelRepository.GetOne(id);
            if (level is null)
            {
                throw new NotFoundException("Level not found");
            }
            return level;
        }
    }
}
