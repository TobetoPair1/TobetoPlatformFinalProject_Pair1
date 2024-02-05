using Business.Abstracts;
using Business.Constants.Messages;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class SocialMediaBusinessRules : BaseBusinessRules<SocialMedia>
{
    ISocialMediaDal _socialMediaDal;
    IUserService _userService;
    public SocialMediaBusinessRules(ISocialMediaDal socialMediaDal, IUserService userService) : base(socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
        _userService = userService;
    }

    public async Task MaxCountAsync(Guid userId)
    {
        var result = await _socialMediaDal.GetListAsync(sm => sm.UserId == userId);

        if (result.Count >= 3)
        {
            throw new BusinessException(BusinessMessages.SocialMediaLimit, BusinessTitles.SocialMediaError);
        }
    }

    public async Task CheckUserIfExists(Guid userId)
    {
        GetUserResponse user = await _userService.GetByIdAsync(new GetUserRequest { Id=userId});
        if (user == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }

}
