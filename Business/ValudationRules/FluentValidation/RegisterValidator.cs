using Business.Dtos.Requests.Auth.Request;
using FluentValidation;

namespace Business.ValudationRules.FluentValidation;

public class RegisterValidator : AbstractValidator<RegisterRequest>
{
    public RegisterValidator()
    {
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Email).EmailAddress();
        RuleFor(p => p.Password).NotEmpty();
        RuleFor(p => p.Password).MinimumLength(8);
        RuleFor(p => p.Password).MaximumLength(32);
        RuleFor(p => p.Password).Matches("^[a-zA-Z0-9]+$");
        //^[a-zA-Z0-9]+$
        //RuleFor(p => p.Password).Matches(@" ^ (?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^a-zA-Z\d]).{8,}$");
    }
}
