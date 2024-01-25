using Business.Dtos.Requests.UserLike;
using Business.Dtos.Responses.Like;
using Business.Dtos.Responses.UserLike;
using Core.DataAccess.Paging;


namespace Business.Abstracts;
public interface IUserLikeService
{
    Task<CreatedUserLikeResponse> AddAsync(CreateUserLikeRequest createUserLikeRequest);
    Task<IPaginate<GetListUserLikeResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedUserLikeResponse> DeleteAsync(DeleteUserLikeRequest deleteUserLikeRequest);
    Task<GetUserLikeResponse> GetByIdAsync(GetUserLikeRequest getUserLikeRequest);
    Task<IPaginate<GetListLikeResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);

}