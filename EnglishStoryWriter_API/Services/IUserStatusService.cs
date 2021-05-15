using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface IUserStatusService : IBaseService<UserStatus, UserStatusDTO, CreateUserStatusDTO>
    {
   
    }
}
