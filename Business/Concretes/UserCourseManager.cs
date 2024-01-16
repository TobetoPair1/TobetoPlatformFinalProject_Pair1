using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTable;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class UserCourseManager : IUserCourseService
{
    IUserCourseDal _userCourseDal;
    IMapper _mapper;

    public UserCourseManager(IUserCourseDal userCourseDal, IMapper mapper)
    {
        _userCourseDal = userCourseDal;
        _mapper = mapper;
    }

    public async Task<CreatedUserCourseResponse> AddAsync(CreateUserCourseRequest createUserCourseRequest)
    {
        UserCourse userCourse = _mapper.Map<UserCourse>(createUserCourseRequest);
        var createdUserCourse = await _userCourseDal.AddAsync(userCourse);
        CreatedUserCourseResponse createdUserCourseResponse = _mapper.Map<CreatedUserCourseResponse>(createdUserCourse);
        return createdUserCourseResponse;
    }

    public async Task<DeletedUserCourseResponse> DeleteAsync(DeleteUserCourseRequest deleteUserCourseRequest)
    {
        UserCourse userCourse = await _userCourseDal.GetAsync(
            uc =>
            uc.UserId == deleteUserCourseRequest.UserId
            &&
            uc.CourseId == deleteUserCourseRequest.CourseId);
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
}
