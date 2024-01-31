using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.Like;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    ICourseDal _courseDal;
    IMapper _mapper;
    IUserCourseService _userCourseService;
    ILikeService _likeService;
	public CourseManager(ICourseDal courseDal, IMapper mapper, IUserCourseService userCourseService, ILikeService likeService)
	{
		_courseDal = courseDal;
		_mapper = mapper;
		_userCourseService = userCourseService;
		_likeService = likeService;
	}

	public async Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest)
    {
        Course course = _mapper.Map<Course>(createCourseRequest);
        course.LikeId = (await _likeService.AddAsync(new CreateLikeRequest())).Id;
        Course addedCourse = await _courseDal.AddAsync(course);
        return _mapper.Map<CreatedCourseResponse>(addedCourse);
    }

	public async Task<CreatedUserCourseResponse> AssignCourseAsync(CreateUserCourseRequest createUserCourseRequest)
	{
		return await _userCourseService.AddAsync(createUserCourseRequest);
	}	

	public async Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest)
    {
        Course course = _mapper.Map<Course>(deleteCourseRequest);
        Course deletedCourse = await _courseDal.DeleteAsync(course);
        return _mapper.Map<DeletedCourseResponse>(deletedCourse);
    }

    public async Task<GetCourseResponse> GetByIdAsync(GetCourseRequest getCourseRequest)
    {
        Course course = await _courseDal.GetAsync(c=>c.Id == getCourseRequest.Id, include: c=>c.Include(c=>c.Category).Include(c=>c.Like));
        return _mapper.Map<GetCourseResponse>(course);
    }

	public async Task<IPaginate<GetListCourseResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
	{
		return await _userCourseService.GetListByUserIdAsync(userId, pageRequest);
	}

	public async Task<IPaginate<GetListCourseResponse>> GetListAsync(PageRequest pageRequest)
    {
        var courses = await _courseDal.GetListAsync(
            index:pageRequest.PageIndex, 
            size: pageRequest.PageSize,
            include:c=>c.Include(c=>c.Category).Include(c=>c.Like)
            );
        return _mapper.Map<Paginate<GetListCourseResponse>>(courses);
    }

    public async Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest)
    {
        Course course = _mapper.Map<Course>(updateCourseRequest);
        Course updatedCourse = await _courseDal.UpdateAsync(course);
        return _mapper.Map<UpdatedCourseResponse>(updatedCourse);
    }
}
