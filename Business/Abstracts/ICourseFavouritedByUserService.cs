using Business.Dtos.Requests.CourseFavouritedByUser;
using Business.Dtos.Responses.CourseFavouriteByUser;

namespace Business.Abstracts;

public interface ICourseFavouritedByUserService
{
    Task<CreatedCourseFavouriteByUserResponse> AddAsync(CreateFavouriteByUserRequest createFavouriteByUserRequest);
    Task<GetCourseFavouriteByUserResponse> GetByIdAsync(GetFavouriteByUserRequest getFavouriteByUserRequest);
    Task<DeletedCourseFavouriteByUserResponse> DeleteAsync(DeleteFavouriteByUserRequest deleteFavouriteByUserRequest);
}



