using Business.Dtos.Requests.Education;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserFavouriteService
    {
        Task<CreatedUserFavouriteResponse> AddAsync(CreateUserFavouriteRequest createUserFavouriteRequest);
        Task<IPaginate<GetListUserFavouriteResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedUserFavouriteResponse> DeleteAsync(DeleteUserFavouriteRequest deleteUserFavouriteRequest);
        Task<UpdatedUserFavouriteResponse> UpdateAsync(UpdateUserFavouriteRequest updateUserFavouriteRequest);
        Task<GetUserFavouriteResponse> GetByIdAsync(GetUserFavouriteRequest getUserFavouriteRequest);
    }
}
