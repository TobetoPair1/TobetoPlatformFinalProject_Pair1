using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AsyncContentBusinessRules:BaseBusinessRules<AsyncContent>
{
    IAsyncContentDal _asyncContentDal;
    public AsyncContentBusinessRules(IAsyncContentDal asyncContentDal):base(asyncContentDal)
    {
        _asyncContentDal = asyncContentDal;
    }
}
