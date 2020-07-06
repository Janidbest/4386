using FluentValidation;
using Host.Services;
using IdentityServer4.Models.AccountViewModels;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Models.Validator
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {       
        public LoginViewModelValidator(ILabelService labelService)
        {
            RuleFor(e => e.Email)
               .NotEmpty()
               .WithMessage($"The {labelService.Username} field is required.");

            RuleFor(e => e.Password)
                .NotEmpty()
                .WithMessage($"The {labelService.Password} field is required.");
        }
    }
}
