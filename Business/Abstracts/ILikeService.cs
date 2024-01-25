using Business.Dtos.Requests.Like;
using Business.Dtos.Requests.UserLike;
using Business.Dtos.Responses.Like;
using Business.Dtos.Responses.UserLike;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ILikeService
{
    Task<CreatedLikeResponse> AddAsync(CreateLikeRequest createLikeRequest);
    Task<IPaginate<GetListLikeResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedLikeResponse> DeleteAsync(DeleteLikeRequest deleteLikeRequest);
    Task<UpdatedLikeResponse> UpdateAsync(UpdateLikeRequest updateLikeRequest);
    Task<GetLikeResponse> GetByIdAsync(GetLikeRequest getLikeRequest);
    
    Task<IPaginate<GetListLikeResponse>> GetByUserId(Guid userId, PageRequest pageRequest);
    
    Task<CreatedUserLikeResponse> AssignLikeAsync(CreateUserLikeRequest createUserLikeRequest);


}


