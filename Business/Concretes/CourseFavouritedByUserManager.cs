using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseFavouritedByUser;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;

public class CourseFavouritedByUserManager : ICourseFavouritedByUserService
{
    IMapper _mapper;
    ICourseFavouritedByUserDal _courseFavouritedByUserDal;
    public async Task<CreatedFavouriteByUserResponse> AddAsync(CreateFavouriteByUserRequest createFavouriteByUserRequest)
    {
        CourseFavouritedByUser courseFavouritedByUser = _mapper.Map<CourseFavouritedByUser>(createFavouriteByUserRequest);
        var createdCourseFavouritedByUser = await _courseFavouritedByUserDal.AddAsync(courseFavouritedByUser);
        CreatedFavouriteByUserResponse createFavouriteByUserResponse = _mapper.Map<CreatedFavouriteByUserResponse>(createdCourseFavouritedByUser);
        return createFavouriteByUserResponse;
    }

    public async Task<DeletedFavouriteByUserResponse> DeleteAsync(DeleteFavouriteByUserRequest deleteFavouriteByUserRequest)
    {
        CourseFavouritedByUser courseFavouritedByUser = await _courseFavouritedByUserDal.GetAsync(c => c.UserId == deleteFavouriteByUserRequest.UserId && c.CourseId == deleteFavouriteByUserRequest.CourseId);
        var deletedCourseFavouritedByUser = await _courseFavouritedByUserDal.DeleteAsync(courseFavouritedByUser);
        DeletedFavouriteByUserResponse deletedFavouriteByUserResponse = _mapper.Map<DeletedFavouriteByUserResponse>(deletedCourseFavouritedByUser);
        return deletedFavouriteByUserResponse;
    }

    public async Task<GetFavouriteByUserResponse> GetByIdAsync(GetFavouriteByUserRequest getFavouriteByUserRequest)
    {
        var result = await _courseFavouritedByUserDal.GetAsync(c => c.UserId == getFavouriteByUserRequest.UserId && c.CourseId == getFavouriteByUserRequest.CourseId);
        return result;
    }
}
