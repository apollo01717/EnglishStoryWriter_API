using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.DTO
{
    public class RegisterUserDTO
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int LevelId { get; set; }
        public int UserStatusId { get; set; }

    }
}
