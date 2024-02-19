using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserOperationClaimBusinessRules : BaseBusinessRules<UserOperationClaim>
{
	IUserOperationClaimDal _userOperationClaimDal;
	public UserOperationClaimBusinessRules(IUserOperationClaimDal userOperationClaimDal) : base(userOperationClaimDal)
	{
		_userOperationClaimDal = userOperationClaimDal;
	}
	public async Task<UserOperationClaim> CheckIfExistsWithForeignKey(Guid userId, Guid operationClaimId)
	{
		UserOperationClaim entity = await _userOperationClaimDal.GetAsync(eq => eq.UserId == userId && eq.OperationClaimId == operationClaimId);
		if (entity == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
	
	public async Task CheckIfAlreadyExistsWithForeignKey(Guid userId, Guid operationClaimId)
	{
		UserOperationClaim entity = await _userOperationClaimDal.GetAsync(eq => eq.UserId == userId && eq.OperationClaimId == operationClaimId);
		if (entity != null)
		{
			throw new BusinessException(BusinessMessages.RoleAlreadyExists, BusinessTitles.AlreadyExistsError);
		}
	}
}
