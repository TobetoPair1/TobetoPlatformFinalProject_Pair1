using Business.Dtos.Requests.ContentLikedByUser;
using Business.Dtos.Responses.ContentLikedByUser;
using Core.DataAccess.Paging;

namespace Business.Abstracts;
public interface IContentLikedByUserService
{
    Task<CreatedContentLikedByUserResponse> AddAsync(CreateContentLikedByUserRequest createContentLikedByUserRequest);
    Task<IPaginate<GetListContentLikedByUserResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedContentLikedByUserResponse> DeleteAsync(DeleteContentLikedByUserRequest deleteContentLikedByUserRequest);
    Task<GetContentLikedByUserReponse> GetByIdAsync(GetContentLikedByUserRequest getContentLikedByUserRequest);
}