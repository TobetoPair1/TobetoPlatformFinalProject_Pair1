using Business.Dtos.Requests.Auth;
using FluentValidation;

namespace Business.ValudationRules.FluentValidation;

public class LoginValidator : AbstractValidator<LoginRequest>
{
    public LoginValidator()
    {
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Email).EmailAddress();
        RuleFor(p => p.Password).NotEmpty();
        RuleFor(p => p.Password).MinimumLength(8);
    }
}