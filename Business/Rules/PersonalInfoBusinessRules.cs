using Business.Abstracts;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;
public class PersonalInfoBusinessRules : BaseBusinessRules<PersonalInfo>
{
    IPersonalInfoDal _personalInfoDal;
    public PersonalInfoBusinessRules(IPersonalInfoDal personalInfoDal) : base(personalInfoDal)
    {
        _personalInfoDal = personalInfoDal;
    }
    
}