using Business.Dtos.Requests.Favourite;
using Business.Dtos.Responses.Favourite;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IFavouriteService
{
    Task<CreatedFavouritetResponse> AddAsync(CreateFavouriteRequest createFavouriteRequest);
    Task<IPaginate<GetListFavoriteResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedFavouriteResponse> DeleteAsync(DeleteFavouriteRequest deleteFavouriteRequest);
    Task<UpdatedFavouriteResponse> UpdateAsync(UpdateFavouriteRequest updateFvouriteRequest);
    Task<GetFavouriteResponse> GetByIdAsync(Guid id);
}

