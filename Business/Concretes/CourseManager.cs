using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.Favourite;
using Business.Dtos.Requests.Like;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.UserCourse;
using Business.Rules;
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
    IFavouriteService _favouriteService;
    CourseBusinessRules _courseBusinessRules;
	public CourseManager(ICourseDal courseDal, IMapper mapper, IUserCourseService userCourseService, ILikeService likeService, IFavouriteService favouriteService, CourseBusinessRules courseBusinessRules)
	{
		_courseDal = courseDal;
		_mapper = mapper;
		_userCourseService = userCourseService;
		_likeService = likeService;
		_favouriteService = favouriteService;
		_courseBusinessRules = courseBusinessRules;
	}

	public async Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest)
    {
        Course course = _mapper.Map<Course>(createCourseRequest);
        course.LikeId = (await _likeService.AddAsync(new CreateLikeRequest())).Id;
        await _favouriteService.AddAsync(new CreateFavouriteRequest
        {
            CourseId = course.Id,
        });
        Course addedCourse = await _courseDal.AddAsync(course);
        return _mapper.Map<CreatedCourseResponse>(addedCourse);
    }

	public async Task<CreatedUserCourseResponse> AssignCourseAsync(CreateUserCourseRequest createUserCourseRequest)
	{
		return await _userCourseService.AddAsync(createUserCourseRequest);
	}	

	public async Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest)
    {
        Course course = await _courseBusinessRules.CheckIfExistsById(deleteCourseRequest.Id);
        Course deletedCourse = await _courseDal.DeleteAsync(course);
        return _mapper.Map<DeletedCourseResponse>(deletedCourse);
    }

    public async Task<GetCourseResponse> GetByIdAsync(Guid id)
    {
        Course course = await _courseDal.GetAsync(c=>c.Id == id, include: c=>c.Include(c=>c.Category).Include(c=>c.Like));
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
        await _courseBusinessRules.CheckCategoryIfExists(updateCourseRequest.CategoryId);
        Course course = await _courseBusinessRules.CheckIfExistsById(updateCourseRequest.Id);
		_mapper.Map(updateCourseRequest,course);
        Course updatedCourse = await _courseDal.UpdateAsync(course);
        return _mapper.Map<UpdatedCourseResponse>(updatedCourse);
    }
}