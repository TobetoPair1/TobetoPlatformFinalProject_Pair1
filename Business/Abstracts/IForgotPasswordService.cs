using Business.Dtos.Requests.ForgotPassword;
using Business.Dtos.Responses.ForgotPassword;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IForgotPasswordService
{
    Task<CreatedForgotPasswordResponse> AddAsync(CreateForgotPasswordRequest createForgotPasswordRequest);
    Task<IPaginate<GetListForgotPasswordResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetForgotPasswordResponse> GetByIdAsync(Guid id);
    Task<GetForgotPasswordResponse> GetByUserIdAsync(Guid userId, string code);
    Task<DeletedForgotPasswordResponse> DeleteAsync(DeleteForgotPasswordRequest deleteForgotPasswordRequest);
    Task<ICollection<DeletedForgotPasswordResponse>> DeleteByUserIdAsync(Guid userId);
}