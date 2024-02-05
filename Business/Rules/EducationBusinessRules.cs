using Business.Abstracts;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class EducationBusinessRules : BaseBusinessRules<Education>
{
	IEducationDal _educationDal;
    IUserService _userService;
	public EducationBusinessRules(IEducationDal educationDal, IUserService userService) : base(educationDal)
    {
        _educationDal = educationDal;
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