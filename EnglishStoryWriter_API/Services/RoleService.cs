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
    public class RoleService : BaseService<Role, RoleDTO, CreateRoleDTO>, IRoleService
    {
        public RoleService(IRoleRepository roleRepository, IMapper mapper) : base(roleRepository, mapper)
        {
        }
    }
}
