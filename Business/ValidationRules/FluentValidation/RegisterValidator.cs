using Business.Dtos.Requests.Auth;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class RegisterValidator : AbstractValidator<RegisterRequest>
{
    public RegisterValidator()
    {
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.FirstName).NotEmpty();
        RuleFor(p => p.LastName).NotEmpty();
        RuleFor(p => p.Email).EmailAddress();
        RuleFor(p => p.Password).NotEmpty();
        RuleFor(p => p.Password).MinimumLength(8);
        RuleFor(p => p.Password).MaximumLength(16);
        RuleFor(p => p.Password).Matches("^(?=.*\\d)(?=.*[a-zA-Z])(?=.*[A-Z])(?=.*[-\\#\\$\\.\\%\\&\\*])(?=.*[a-zA-Z]).{8,16}$");
    }    
}