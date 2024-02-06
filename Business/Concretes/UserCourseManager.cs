using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.UserCourse;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class UserCourseManager : IUserCourseService
{
    IUserCourseDal _userCourseDal;
    IMapper _mapper;
    UserCourseBusinessRules _userCourseBusinessRules;

    public UserCourseManager(IUserCourseDal userCourseDal, IMapper mapper, UserCourseBusinessRules userCourseBusinessRules)
    {
        _userCourseDal = userCourseDal;
        _mapper = mapper;
        _userCourseBusinessRules = userCourseBusinessRules;
    }

    public async Task<CreatedUserCourseResponse> AddAsync(CreateUserCourseRequest createUserCourseRequest)
    {
        await _userCourseBusinessRules.AlreadyExists(createUserCourseRequest);
        UserCourse userCourse = _mapper.Map<UserCourse>(createUserCourseRequest);
        var createdUserCourse = await _userCourseDal.AddAsync(userCourse);
        CreatedUserCourseResponse createdUserCourseResponse = _mapper.Map<CreatedUserCourseResponse>(createdUserCourse);
        return createdUserCourseResponse;
    }

    public async Task<DeletedUserCourseResponse> DeleteAsync(DeleteUserCourseRequest deleteUserCourseRequest)
    {
        UserCourse userCourse = await _userCourseBusinessRules.CheckIfExistsWithForeignKey(deleteUserCourseRequest.UserId,deleteUserCourseRequest.CourseId);
        var deletedUserCourse = await _userCourseDal.DeleteAsync(userCourse, true);
        DeletedUserCourseResponse deletedUserCourseResponse = _mapper.Map<DeletedUserCourseResponse>(deletedUserCourse);
        return deletedUserCourseResponse;
    }

    public async Task<GetUserCourseResponse> GetByIdAsync(GetUserCourseRequest getUserCourseRequest)
    {
        UserCourse userCourse = await _userCourseDal.GetAsync(
            uc =>
            uc.UserId == getUserCourseRequest.UserId
            &&
            uc.CourseId == getUserCourseRequest.CourseId);
        return _mapper.Map<GetUserCourseResponse>(userCourse);
    }

    public async Task<IPaginate<GetListUserCourseResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userCourseDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: uc => uc.Include(uc => uc.Course));
        return _mapper.Map<Paginate<GetListUserCourseResponse>>(result);
    }

	public async Task<IPaginate<GetListCourseResponse>> GetListByUserIdAsync(Guid userId,PageRequest pageRequest)
	{
        var userCourses =  await _userCourseDal.GetListAsync(uc=>uc.UserId==userId,include:uc=>uc.Include(uc=>uc.Course).Include(uc => uc.Course.Category).Include(uc => uc.Course.Like), index:pageRequest.PageIndex,size:pageRequest.PageSize);

        var courses = _mapper.Map<Paginate<GetListCourseResponse>>(userCourses);
		return courses;
	}
}
