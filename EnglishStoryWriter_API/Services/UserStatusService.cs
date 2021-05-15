using AutoMapper;
using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public class UserStatusService : BaseService<UserStatus,UserStatusDTO, CreateUserStatusDTO>,IUserStatusService
    {
        public UserStatusService(IUserStatusRepository userStatusRepository, IMapper mapper)
            : base (userStatusRepository, mapper) 
        {

        }
    }
}
