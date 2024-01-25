using Business.Dtos.Requests.Favourite;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.Favourite;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IFavouriteService
{
    Task<CreatedFavouritetResponse> AddAsync(CreateFavouriteRequest createFavouriteRequest);
    Task<IPaginate<GetListFavouriteResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedFavouriteResponse> DeleteAsync(DeleteFavouriteRequest deleteFavouriteRequest);
    Task<UpdatedFavouriteResponse> UpdateAsync(UpdateFavouriteRequest updateFvouriteRequest);
    Task<GetFavouriteResponse> GetByIdAsync(GetFavouriteRequest getFavouriteRequest);
    Task<IPaginate<GetListFavouriteResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);
    Task<CreatedUserFavouriteResponse> AssignFavoriteAsync(CreateUserFavouriteRequest createUserFavouriteRequest);
}

