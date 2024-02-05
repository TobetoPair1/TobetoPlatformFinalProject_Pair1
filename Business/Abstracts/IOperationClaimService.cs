using Business.Dtos.Requests.OperationClaim;
using Business.Dtos.Responses.OperationClaim;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IOperationClaimService
{
    Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest);
    Task<IPaginate<GetListOperationClaimResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedOperationClaimResponse> DeleteAsync(DeleteOperationClaimRequest deleteOperationClaimRequest);
    Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest);
    Task<GetOperationClaimResponse> GetByIdAsync(GetOperationClaimRequest getOperationClaimRequest);
}