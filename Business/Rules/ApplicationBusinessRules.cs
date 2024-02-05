using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class ApplicationBusinessRules:BaseBusinessRules<Application>
{
    IApplicationDal _applicationDal;
    public ApplicationBusinessRules(IApplicationDal applicationDal):base(applicationDal)
    {
        _applicationDal = applicationDal;
    }
}
