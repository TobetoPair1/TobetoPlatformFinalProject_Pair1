using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class ExperienceBusinessRules : BaseBusinessRules<Experience>
{
    IExperienceDal _experienceDal;
    public ExperienceBusinessRules(IExperienceDal experienceDal) : base(experienceDal)
    {
        _experienceDal = experienceDal;
    }
}
