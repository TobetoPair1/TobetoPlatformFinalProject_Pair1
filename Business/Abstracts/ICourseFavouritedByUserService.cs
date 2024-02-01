using Business.Dtos.Requests.CourseFavouritedByUser;

namespace Business.Abstracts;

public interface ICourseFavouritedByUserService
{
    Task<CreatedFavouriteByUserResponse> AddAsync(CreateFavouriteByUserRequest createFavouriteByUserRequest);
    Task<GetFavouriteByUserResponse> GetByIdAsync(GetFavouriteByUserRequest getFavouriteByUserRequest);
    Task<DeletedFavouriteByUserResponse> DeleteAsync(DeleteFavouriteByUserRequest deleteFavouriteByUserRequest);
}



