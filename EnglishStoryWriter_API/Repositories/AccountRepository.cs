using EnglishStoryWriter_API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly EnglishDbContext _englishDbContext;
        public AccountRepository(EnglishDbContext englishDbContext)
        {
            _englishDbContext = englishDbContext;
        }
        public void Register(User user)
        {
            _englishDbContext.User.Add(user);
            _englishDbContext.SaveChanges();
        }

        public User GetUserWithRoleByEmail(string email)
        {
            return _englishDbContext.User.Include(u => u.Role)
                .FirstOrDefault(u => u.Email == email);
        }
    }
}
