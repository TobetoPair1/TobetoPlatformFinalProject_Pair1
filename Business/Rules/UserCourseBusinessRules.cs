using Business.Constants.Messages;
using Business.Dtos.Requests.UserCourse;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserCourseBusinessRules:BaseBusinessRules
{
    IUserCourseDal _userCourseDal;

    public UserCourseBusinessRules(IUserCourseDal userCourseDal)
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
}
