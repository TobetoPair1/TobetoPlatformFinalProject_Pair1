using Business.Abstracts;
using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;

namespace Business.Rules;

public class AuthBusinessRules : BaseBusinessRules
{

    IUserService _userService;
    public AuthBusinessRules(IUserService userService)
    {
        _userService = userService;
    }

    public async Task UserExists(string email)
    {
        if (await _userService.GetByMailAsync(email) != null)
            throw new BusinessException(BusinessMessages.UserExists, BusinessTitles.RegisterError);
    }
}
