using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class SessionBusinessRules : BaseBusinessRules<Session>
{
    ISessionDal _sessionDal;
    public SessionBusinessRules(ISessionDal sessionDal) : base(sessionDal)
    {
        _sessionDal = sessionDal;
    }
}
