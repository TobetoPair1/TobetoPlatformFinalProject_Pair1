using Business.Abstracts;
using Business.Dtos.Requests.LiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class SessionBusinessRules : BaseBusinessRules<Session>
{
    ISessionDal _sessionDal;
    ILiveContentService _liveContentService;
    public SessionBusinessRules(ISessionDal sessionDal, ILiveContentService liveContentService) : base(sessionDal)
    {
        _sessionDal = sessionDal;
        _liveContentService = liveContentService;
    }
    public async Task CheckLiveContentIfExists(Guid liveContentId)
    {
        GetLiveContentResponse liveContent = await _liveContentService.GetByIdAsync(liveContentId);
        if (liveContent == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
}
