using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.OperationClaim;
using Business.Dtos.Requests.UserOperationClaim;
using Business.Dtos.Responses.OperationClaim;
using Business.Dtos.Responses.UserOperationClaim;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class OperationClaimManager : IOperationClaimService
{
    IMapper _mapper;
    IOperationClaimDal _operationClaimDal;
    OperationClaimBusinessRules _operationClaimBusinessRules;
    IUserOperationClaimService _userOperationClaimService;

    public OperationClaimManager(IMapper mapper, IOperationClaimDal operationClaimDal, OperationClaimBusinessRules operationClaimBusinessRules, IUserOperationClaimService userOperationClaimService)
    {
        _mapper = mapper;
        _operationClaimDal = operationClaimDal;
        _operationClaimBusinessRules = operationClaimBusinessRules;
        _userOperationClaimService = userOperationClaimService;
    }

    [SecuredOperation("admin")]
    public async Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest)
    {
        OperationClaim operationClaim = _mapper.Map<OperationClaim>(createOperationClaimRequest);
        var createdAnnouncement = await _operationClaimDal.AddAsync(operationClaim);
        CreatedOperationClaimResponse result = _mapper.Map<CreatedOperationClaimResponse>(operationClaim);
        return result;
    }
	[SecuredOperation("admin")]
	public async Task<CreatedUserOperationClaimResponse> AssignOperationClaimAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest)
    {
        return await _userOperationClaimService.AddAsync(createUserOperationClaimRequest);
    }

    [SecuredOperation("admin")]
    public async Task<DeletedOperationClaimResponse> DeleteAsync(DeleteOperationClaimRequest deleteOperationClaimRequest)
    {
        OperationClaim operationClaim = await _operationClaimBusinessRules.CheckIfExistsById(deleteOperationClaimRequest.Id);
        var deletedOperationClaim = await _operationClaimDal.DeleteAsync(operationClaim, true);
        DeletedOperationClaimResponse result = _mapper.Map<DeletedOperationClaimResponse>(deletedOperationClaim);
        return result;
    }

    public async Task<GetOperationClaimResponse> GetByIdAsync(GetOperationClaimRequest getOperationClaimRequest)
    {
        var result = await _operationClaimDal.GetAsync(o => o.Id == getOperationClaimRequest.Id);
        return _mapper.Map<GetOperationClaimResponse>(result);
    }

    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListOperationClaimResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _operationClaimDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListOperationClaimResponse>>(result);
    }

    [SecuredOperation("admin")]
    public async Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest)
    {
        OperationClaim operationClaim = await _operationClaimBusinessRules.CheckIfExistsById(updateOperationClaimRequest.Id);
        _mapper.Map(updateOperationClaimRequest, operationClaim);
        var updatedOperationClaim = await _operationClaimDal.UpdateAsync(operationClaim);
        UpdatedOperationClaimResponse updatedOperationClaimResponse = _mapper.Map<UpdatedOperationClaimResponse>(updatedOperationClaim);
        return updatedOperationClaimResponse;
    }
}
