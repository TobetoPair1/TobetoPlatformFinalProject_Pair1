using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserSurveyBusinessRules : BaseBusinessRules<UserSurvey>
{
	IUserSurveyDal _userSurveyDal;
	public UserSurveyBusinessRules(IUserSurveyDal userSurveyDal) : base(userSurveyDal)
	{
		_userSurveyDal = userSurveyDal;
	}
	public async Task<UserSurvey> CheckIfExistsWithForeignKey(Guid userId, Guid surveyId)
	{
		UserSurvey entity = await _userSurveyDal.GetAsync(clbu => clbu.UserId == userId && clbu.SurveyId == surveyId);
		if (entity == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}
