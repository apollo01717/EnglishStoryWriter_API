using EnglishStoryWriter_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public interface IAccountService
    {
        public void RegisterUser(RegisterUserDTO dto);
        public string GenerateJwt(LoginDTO dto);

    }
}
