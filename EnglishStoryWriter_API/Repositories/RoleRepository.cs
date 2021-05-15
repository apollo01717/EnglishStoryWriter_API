using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class RoleRepository : BaseRepository<Role,CreateRoleDTO>, IRoleRepository
    {
        public RoleRepository(EnglishDbContext englishDbContext) : base(englishDbContext)
        {
        }
    }
}
