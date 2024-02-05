using Business.Abstracts;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;
public class ExperienceBusinessRules : BaseBusinessRules<Experience>
{
    IExperienceDal _experienceDal;
    IUserService _userService;
    public ExperienceBusinessRules(IExperienceDal experienceDal, IUserService userService) : base(experienceDal)
    {
        _experienceDal = experienceDal;
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