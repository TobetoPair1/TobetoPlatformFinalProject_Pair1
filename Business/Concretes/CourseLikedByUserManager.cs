
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.CourseLikedByUser;
using Business.Dtos.Responses.CourseLikedByUser;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;


namespace Business.Concretes;

public class CourseLikedByUserManager : ICourseLikedByUserService
{
    IMapper _mapper;
    ICourseLikedByUserDal _courseLikedByUserDal;
    public async Task<CreatedCourseLikedByUserResponse> AddAsync(CreateCourseLikedByUserRequest createCourseLikedByUserRequest)
    {
        CourseLikedByUser courseLikedByUser = _mapper.Map<CourseLikedByUser>(createCourseLikedByUserRequest);
        var createdCourseLikedByUser = await _courseLikedByUserDal.AddAsync(courseLikedByUser);
        CreatedCourseLikedByUserResponse createdCourseLikedByUserResponse = _mapper.Map<CreatedCourseLikedByUserResponse>(createdCourseLikedByUser);
        return createdCourseLikedByUserResponse;

    }
    
    public async Task<DeletedCourseLikedByUserResponse> DeleteAsync(DeleteCourseLikedByUserRequest deleteLikedByUserRequest)
    {
        CourseLikedByUser courseLikedByUser = await _courseLikedByUserDal.GetAsync(c => c.UserId == deleteLikedByUserRequest.UserId && c.CourseId == deleteLikedByUserRequest.CourseId);
        var deletedCourseLikedByUser = await _courseLikedByUserDal.DeleteAsync(courseLikedByUser);
        DeletedCourseLikedByUserResponse deletedCourseLikedByUserResponse = _mapper.Map<DeletedCourseLikedByUserResponse>(deletedCourseLikedByUser);
        return deletedCourseLikedByUserResponse;

    }

    public async Task<GetCourseLikedByUserResponse> GetByIdAsync(GetCourseLikedByUserRequest getCourseLikedByUserRequest)
    {
        var result = await _courseLikedByUserDal.GetAsync(c => c.UserId == getCourseLikedByUserRequest.UserId && c.CourseId == getCourseLikedByUserRequest.CourseId);
        return _mapper.Map<GetCourseLikedByUserResponse>(result);

    }
}