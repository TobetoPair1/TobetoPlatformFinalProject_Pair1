using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.UserApplication;
using Core.DataAccess.Paging;

namespace Business.Abstracts;
public interface IUserApplicationService
{
    Task<CreatedUserApplicationResponse> AddAsync(CreateUserApplicationRequest createUserApplicationRequest);
    Task<DeletedUserApplicationResponse> DeleteAsync(DeleteUserApplicationRequest deleteUserApplicationRequest);
    Task<GetUserApplicationResponse> GetByIdAsync(GetUserApplicationRequest getUserApplicationRequest);
    Task<IPaginate<GetListUserApplicationResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListApplicationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);

}
