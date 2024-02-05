using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class SocialMediaBusinessRules : BaseBusinessRules<SocialMedia>
{
    ISocialMediaDal _socialMediaDal;
    public SocialMediaBusinessRules(ISocialMediaDal socialMediaDal):base(socialMediaDal)
    {
        _socialMediaDal = socialMediaDal;
    }

    public async Task MaxCountAsync(Guid userId)
    {
        var result = await _socialMediaDal.GetListAsync(sm => sm.UserId == userId);

        if (result.Count >= 3)
        {
            throw new BusinessException(BusinessMessages.SocialMediaLimit, BusinessTitles.SocialMediaError);
        }
    }

}
