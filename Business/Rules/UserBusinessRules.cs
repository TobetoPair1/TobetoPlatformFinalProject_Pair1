using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class UserBusinessRules : BaseBusinessRules<User>
{
    private readonly IUserDal _userDal;
    public UserBusinessRules(IUserDal userDal):base(userDal)
	{
		_userDal = userDal;
	}

	public async Task<User> CheckIfExistsByMail(string email)
	{

		var entity = await _userDal.GetAsync(t => t.Email == email);
		if (entity == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}


}
