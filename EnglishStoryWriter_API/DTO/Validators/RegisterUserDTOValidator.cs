using EnglishStoryWriter_API.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API.DTO.Validators
{
    public class RegisterUserDTOValidator : AbstractValidator<RegisterUserDTO>
    {
        public RegisterUserDTOValidator(EnglishDbContext dbContext)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(50)
                .MinimumLength(2);
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(x => x.Password).MinimumLength(6);

            RuleFor(x => x.ConfirmPassword).Equal(e => e.Password);

            RuleFor(x => x.Email)
                .Custom((value, context) =>
                {
                    var emailInUse = dbContext.User.Any(u => u.Email == value);
                    if (emailInUse)
                    {
                        context.AddFailure("Email", "That email is taken");
                    }
                });
        }
    }
}
