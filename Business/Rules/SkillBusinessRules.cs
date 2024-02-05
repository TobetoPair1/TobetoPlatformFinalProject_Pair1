using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;


public class SkillBusinessRules : BaseBusinessRules<Skill>
{
    ISkillDal _skillDal;
    public SkillBusinessRules(ISkillDal skillDal) : base(skillDal)
    {
        _skillDal = skillDal;
    }
}

