using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserOperationClaim;
using Business.Dtos.Responses.UserOperationClaim;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;

public class UserOperationClaimManager : IUserOperationClaimService
{
    IMapper _mapper;
    IUserOperationClaimDal _userOperationClaimDal;
    UserOperationClaimBusinessRules _userOperationClaimBusinessRules;
	public UserOperationClaimManager(IMapper mapper, IUserOperationClaimDal userOperationClaimDal, UserOperationClaimBusinessRules userOperationClaimBusinessRules)
	{
		_mapper = mapper;
		_userOperationClaimDal = userOperationClaimDal;
		_userOperationClaimBusinessRules = userOperationClaimBusinessRules;
	}
	public async Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest)
    {
        await
            _userOperationClaimBusinessRules.CheckIfAlreadyExistsWithForeignKey(createUserOperationClaimRequest.UserId,
                createUserOperationClaimRequest.OperationClaimId);

        UserOperationClaim userOperationClaim = _mapper.Map<UserOperationClaim>(createUserOperationClaimRequest);
        var createdUserOperationClaim = await _userOperationClaimDal.AddAsync(userOperationClaim);
        CreatedUserOperationClaimResponse result = _mapper.Map<CreatedUserOperationClaimResponse>(createdUserOperationClaim);
        return result;
    }

    public async Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest)
    {
        UserOperationClaim userOperationClaim = await _userOperationClaimBusinessRules.CheckIfExistsWithForeignKey(deleteUserOperationClaimRequest.UserId, deleteUserOperationClaimRequest.OperationClaimId);
        var deletedUserOperationClaim = await _userOperationClaimDal.DeleteAsync(userOperationClaim, true);
        DeletedUserOperationClaimResponse deletedUserOperationClaimResponse = _mapper.Map<DeletedUserOperationClaimResponse>(deletedUserOperationClaim);
        return deletedUserOperationClaimResponse;
    }

    public async Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userOperationClaimDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListUserOperationClaimResponse>>(result);
    }

    public async Task<IPaginate<GetListUserOperationClaimResponse>> GetListByUserIdAsync(Guid userId)
    {
        var result = await _userOperationClaimDal.GetListAsync(uoc => uoc.UserId == userId);
        return _mapper.Map<Paginate<GetListUserOperationClaimResponse>>(result);
    }
}