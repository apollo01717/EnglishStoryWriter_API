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

            CreateMap<Criterion, CriterionDTO>();
            CreateMap<CriterionDTO, Criterion>();
            CreateMap<Criterion, CreateCriterionDTO>();
            CreateMap<CreateCriterionDTO, Criterion>();

            CreateMap<Level, LevelDTO>();
            CreateMap<LevelDTO, Level>();
            CreateMap<CreateLevelDTO, Level>();
            CreateMap<Level, CreateLevelDTO>();

            CreateMap<Role, RoleDTO>();
            CreateMap<RoleDTO, Role>();
            CreateMap<CreateRoleDTO, Role>();
            CreateMap<Role, CreateRoleDTO>();

            CreateMap<UserStatus, UserStatusDTO>();
            CreateMap<UserStatusDTO, UserStatus>();
            CreateMap<CreateUserStatusDTO, UserStatus>();
            CreateMap<UserStatus, CreateUserStatusDTO>();
        }
    }
}
