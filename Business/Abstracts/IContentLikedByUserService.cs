using Business.Dtos.Requests.ContentLikedByUser;
using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.ContentLikedByUser;
using Business.Dtos.Responses.Education;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IContentLikedByUserService
    {
        Task<CreatedContentLikedByUserResponse> AddAsync(CreateContentLikedByUserRequest createContentLikedByUserRequest);
        Task<IPaginate<GetListContentLikedByUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedContentLikedByUserResponse> DeleteAsync(DeleteContentLikedByUserRequest deleteContentLikedByUserRequest);
        Task<GetContentLikedByUserReponse> GetByIdAsync(GetContentLikedByUserRequest getContentLikedByUserRequest);
    }
}