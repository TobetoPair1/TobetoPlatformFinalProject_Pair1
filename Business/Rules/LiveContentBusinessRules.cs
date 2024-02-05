using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class LiveContentBusinessRules : BaseBusinessRules<LiveContent>
    {
        ILiveContentDal _liveContentDal;
        public LiveContentBusinessRules(ILiveContentDal liveContentDal) : base(liveContentDal)
        {
            _liveContentDal = liveContentDal;
        }
    }
}
