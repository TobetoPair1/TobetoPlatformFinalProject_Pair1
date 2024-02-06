using Business.Constants.Messages;
using Business.Dtos.Requests.UserCourse;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserCourseBusinessRules:BaseBusinessRules<UserCourse>
{
    IUserCourseDal _userCourseDal;

    public UserCourseBusinessRules(IUserCourseDal userCourseDal):base(userCourseDal)
    {
        _userCourseDal = userCourseDal;
    }
    public async Task AlreadyExists(CreateUserCourseRequest createUserCourseRequest)
    {
       UserCourse userCourse = await _userCourseDal.GetAsync(uc => uc.UserId == createUserCourseRequest.UserId && uc.CourseId == createUserCourseRequest.CourseId);
       if (userCourse != null)
        {
            throw new BusinessException(BusinessMessages.CourseAlreadyExists, BusinessTitles.AlreadyExistsError);
        }
        
    }
	public async Task<UserCourse> CheckIfExistsWithForeignKey(Guid userId, Guid courseId)
	{
		UserCourse userCourse = await _userCourseDal.GetAsync(uc => uc.UserId == userId && uc.CourseId == courseId);
		if (userCourse == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return userCourse;
	}
}
