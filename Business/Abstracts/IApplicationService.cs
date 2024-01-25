using Business.Dtos.Requests.Application;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.UserApplication;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IApplicationService
{
    Task<CreatedApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest);
    Task<DeletedApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest);
    Task<UpdatedApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest);
    Task<IPaginate<GetListApplicationResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetApplicationResponse> GetByIdAsync(GetApplicationRequest getApplicationRequest);
    Task<IPaginate<GetListApplicationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);
    Task<CreatedUserApplicationResponse> AssignApplicationAsync(CreateUserApplicationRequest createUserApplicationRequest);


}
