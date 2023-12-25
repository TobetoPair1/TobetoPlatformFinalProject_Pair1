using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.User;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest);
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest);
        Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
        Task<GetUserResponse> GetByIdAsync(Guid? id);
        Task<GetUserResponse> GetByMailAsync(string mail);
        //Task<GetUserResponse> CheckUserAsync(GetUserRequest getUserRequest);
    }
}
