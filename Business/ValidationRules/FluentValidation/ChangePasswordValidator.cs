using Business.Dtos.Requests.ChangePassword;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class ChangePasswordValidator : AbstractValidator<CreateChangePasswordRequest>
{
    public ChangePasswordValidator()
    {
        RuleFor(cp => cp.Mail).NotEmpty();
        RuleFor(cp => cp.Mail).EmailAddress();
        RuleFor(cp => cp.Password).NotEmpty();
        RuleFor(cp => cp.Password).MinimumLength(8);
        RuleFor(cp => cp.Password).MaximumLength(16);
        RuleFor(cp => cp.Password).Matches("^(?=.*\\d)(?=.*[a-zA-Z])(?=.*[A-Z])(?=.*[-\\#\\$\\.\\%\\&\\*])(?=.*[a-zA-Z]).{8,16}$");
    }
}