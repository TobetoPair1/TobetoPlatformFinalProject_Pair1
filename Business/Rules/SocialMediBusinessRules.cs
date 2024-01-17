using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules;

public class SocialMediaBusinessRules : BaseBusinessRules
{
    private readonly ISocialMediaDal _socialMediaDal;
    public SocialMediaBusinessRules(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public async Task MaxCountAsync(Guid userId)
    {
        var result = await _socialMediaDal.GetListAsync(sm => sm.UserId == userId);

        if (result.Count > 3)
        {
            throw new BusinessException(BusinessMessages.SocialMediLimit, BusinessTitles.SocialMediaError);
        }
    }

}
