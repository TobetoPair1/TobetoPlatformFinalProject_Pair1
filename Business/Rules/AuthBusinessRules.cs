using Business.Abstracts;
using Business.Constants.Messages;
using Business.Dtos.Requests.Auth;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AuthBusinessRules : BaseBusinessRules<User>
{

	IUserService _userService;
	public AuthBusinessRules(IUserService userService,IUserDal userDal):base(userDal)
	{
		_userService = userService;
	}

	public async Task<bool> CheckIfUserExists(string email)
	{
		User user = await _userService.GetByMailAsync(email, true);
		//withdeleted true ise register yapıyoruz
		//result null değilse
		if (user != null)
		{
			if (user.DeletedDate != null)// veri silinmişse
			{
				//kullanıcı kayıtlı ama hesap aktif değil aktifleştirelim mi?
				return false;
			}
			else//hiç kayıt yoksa
			{
				//hata ver kullanıcı zaten kayıtlı
				throw new BusinessException(BusinessMessages.UserExists, BusinessTitles.RegisterError);				
			}
		}
		else
		{
			//yeni kayıt
			return true;
		}
	}
	public async Task<User> UserToCheck(LoginRequest loginRequest)
	{
		var userToCheck = await _userService.GetByMailAsync(loginRequest.Email, false);

		if (userToCheck == null || !HashingHelper.VerifyPasswordHash(loginRequest.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
			throw new BusinessException(BusinessMessages.LoginError, BusinessTitles.LoginError);

		return userToCheck;
	}
}
