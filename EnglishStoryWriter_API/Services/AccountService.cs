using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Exceptions;
using EnglishStoryWriter_API.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.Services
{
    public class AccountService : IAccountService
    {
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IAccountRepository _accountRepository;
        private readonly AuthenticationSettings _authenticationSettings;

        public AccountService(IPasswordHasher<User> passwordHasher, IAccountRepository accountRepository, AuthenticationSettings authenticationSettings)
        {
            _passwordHasher = passwordHasher;
            _accountRepository = accountRepository;
            _authenticationSettings = authenticationSettings;
        }

        public string GenerateJwt(LoginDTO dto)
        {
            User user = _accountRepository.GetUserWithRoleByEmail(dto.Email);
            if (user is null)
            {
                throw new BadRequestException("Ivalid username or password");
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, dto.Password);
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authenticationSettings.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authenticationSettings.JwtExpireDays);

            var token = new JwtSecurityToken(_authenticationSettings.JwtIssuer,
                _authenticationSettings.JwtIssuer,
                claims, expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        public void RegisterUser(RegisterUserDTO dto)
        {
            User user = new User()
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                RoleId = dto.RoleId,
                LevelId = dto.LevelId,
                UserStatusId = dto.UserStatusId
            };
            var hashedPassword = _passwordHasher.HashPassword(user, dto.Password);
            user.Password = hashedPassword;
            _accountRepository.Register(user);
        }
    }
}
