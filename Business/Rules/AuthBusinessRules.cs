using Business.Abstracts;
using Business.Dtos.Requests.Auth.Request;
using Core.Business.Rules;

namespace Business.Rules;

public class AuthBusinessRules : BaseBusinessRules
{

    IUserService _userService;
    public AuthBusinessRules(IUserService userService)
    {
        _userService = userService;
    }

    public async Task CheckUser(LoginRequest loginRequest)
    {

    }
}
