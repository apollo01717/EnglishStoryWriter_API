using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int StoryAmount { get; set; }
        public int TotalPoints { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int UserStatusId{ get; set; }
        public UserStatus UserStatus{ get; set; }
        public int LevelId { get; set; }
        public Level Level { get; set; }
    }
}
