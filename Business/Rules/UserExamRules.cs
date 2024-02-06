using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserExamRules : BaseBusinessRules<UserExam>
{
    IUserExamDal _userExamDal;
    public UserExamRules(IUserExamDal userExamDal) : base(userExamDal)
    {
        _userExamDal = userExamDal;
    }

    public async Task<UserExam> CheckIfExistsWithForeignKey(Guid userId, Guid examId)
    {
        UserExam userExam = await _userExamDal.GetAsync(uc => uc.UserId == userId && uc.ExamId == examId);
        if (userExam == null)
        {
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
        return userExam;
    }
}