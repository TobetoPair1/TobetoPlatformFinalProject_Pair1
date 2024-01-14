using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.OperationClaim;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.OperationClaim;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest);
        Task<IPaginate<GetListOperationClaimResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedOperationClaimResponse> DeleteAsync(DeleteOperationClaimRequest deleteOperationClaimRequest);
        Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest);
        Task<GetOperationClaimResponse> GetByIdAsync(GetOperationClaimRequest getOperationClaimRequest);
    }
}
