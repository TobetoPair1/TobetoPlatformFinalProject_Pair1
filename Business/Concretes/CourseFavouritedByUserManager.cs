using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseFavouritedByUser;
using Business.Dtos.Responses.CourseFavouriteByUser;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;

public class CourseFavouritedByUserManager : ICourseFavouritedByUserService
{
    IMapper _mapper;
    ICourseFavouritedByUserDal _courseFavouritedByUserDal;
    public async Task<CreatedCourseFavouriteByUserResponse> AddAsync(CreateFavouriteByUserRequest createFavouriteByUserRequest)
    {
        CourseFavouritedByUser courseFavouritedByUser = _mapper.Map<CourseFavouritedByUser>(createFavouriteByUserRequest);
        var createdCourseFavouritedByUser = await _courseFavouritedByUserDal.AddAsync(courseFavouritedByUser);
		CreatedCourseFavouriteByUserResponse createdCourseFavouriteByUserResponse = _mapper.Map<CreatedCourseFavouriteByUserResponse>(createdCourseFavouritedByUser);
        return createdCourseFavouriteByUserResponse;
    }

    public async Task<DeletedCourseFavouriteByUserResponse> DeleteAsync(DeleteFavouriteByUserRequest deleteFavouriteByUserRequest)
    {
        CourseFavouritedByUser courseFavouritedByUser = await _courseFavouritedByUserDal.GetAsync(c => c.UserId == deleteFavouriteByUserRequest.UserId && c.CourseId == deleteFavouriteByUserRequest.CourseId);
        var deletedCourseFavouritedByUser = await _courseFavouritedByUserDal.DeleteAsync(courseFavouritedByUser);
		DeletedCourseFavouriteByUserResponse deletedCourseFavouriteByUserResponse = _mapper.Map<DeletedCourseFavouriteByUserResponse>(deletedCourseFavouritedByUser);
        return deletedCourseFavouriteByUserResponse;
    }

    public async Task<GetCourseFavouriteByUserResponse> GetByIdAsync(GetFavouriteByUserRequest getFavouriteByUserRequest)
    {
        var result = await _courseFavouritedByUserDal.GetAsync(c => c.UserId == getFavouriteByUserRequest.UserId && c.CourseId == getFavouriteByUserRequest.CourseId);
        return _mapper.Map<GetCourseFavouriteByUserResponse>(result);
    }
}
