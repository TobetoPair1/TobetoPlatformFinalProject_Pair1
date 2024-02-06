using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserSkillRules : BaseBusinessRules<UserSkill>
{
    IUserSkillDal _userSkillDal;
    public UserSkillRules(IUserSkillDal userSkillDal) : base(userSkillDal)
    {
        _userSkillDal = userSkillDal;
    }

    public async Task<UserSkill> CheckIfExistsWithForeignKey(Guid userId, Guid skillId)
    {
        UserSkill userSkill = await _userSkillDal.GetAsync(uc => uc.UserId == userId && uc.SkillId == skillId);
        if (userSkill == null)
        {
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
        return userSkill;
    }
}

