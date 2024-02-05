using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class PersonalInfoBusinessRules : BaseBusinessRules<PersonalInfo>
    {
        IPersonalInfoDal _personalInfoDal;
        public PersonalInfoBusinessRules(IPersonalInfoDal personalInfoDal) : base(personalInfoDal)
        {
            _personalInfoDal = personalInfoDal;
        }
    }
}
