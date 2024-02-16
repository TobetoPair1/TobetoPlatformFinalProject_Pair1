using Business.Dtos.Requests.UserOperationClaim;
using Business.Dtos.Responses.UserOperationClaim;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserOperationClaimService
{
    Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest);
    Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListUserOperationClaimResponse>> GetListByUserIdAsync(Guid userId);
    Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest);
}