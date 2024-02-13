using Business.Abstracts;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class ForgotPasswordBusinessRules : BaseBusinessRules<ForgotPassword>
{
    IForgotPasswordDal _forgotPasswordDal;
    IUserService _userService;
    public ForgotPasswordBusinessRules(IForgotPasswordDal forgotPasswordDal, IUserService userService):base(forgotPasswordDal)
    {
        _forgotPasswordDal = forgotPasswordDal;
        _userService = userService;
    }
    public async Task CheckUserIfExists(Guid userId)
    {
        GetUserResponse user = await _userService.GetByIdAsync(userId);
        if (user == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
}