using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserFavouriteService
{
    Task<CreatedUserFavouriteResponse> AddAsync(CreateUserFavouriteRequest createUserFavouriteRequest);
    Task<IPaginate<GetListUserFavouriteResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedUserFavouriteResponse> DeleteAsync(DeleteUserFavouriteRequest deleteUserFavouriteRequest);
    Task<UpdatedUserFavouriteResponse> UpdateAsync(UpdateUserFavouriteRequest updateUserFavouriteRequest);
    Task<GetUserFavouriteResponse> GetByIdAsync(GetUserFavouriteRequest getUserFavouriteRequest);
}
