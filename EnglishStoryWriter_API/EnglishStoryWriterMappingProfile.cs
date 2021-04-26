using AutoMapper;
using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API
{
    public class EnglishStoryWriterMappingProfile : Profile
    {
        public EnglishStoryWriterMappingProfile()
        {
            CreateMap<StoryStatus, StoryStatusDTO>();
            CreateMap<StoryStatusDTO, StoryStatus>();
            CreateMap<CreateStoryStatusDTO, StoryStatus>();
            CreateMap<StoryStatus, CreateStoryStatusDTO>();

            CreateMap<CategoryOfKeyword, CategoryOfKeywordDTO>();
            CreateMap<CategoryOfKeywordDTO, CategoryOfKeyword>();
            CreateMap<CreateCategoryOfKeywordDTO, CategoryOfKeyword>();
            CreateMap<CategoryOfKeyword,CreateCategoryOfKeywordDTO>();

        }
    }
}
