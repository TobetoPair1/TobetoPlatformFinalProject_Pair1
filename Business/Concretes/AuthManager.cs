using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Auth;
using Business.Dtos.Requests.ChangePassword;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Business.ValudationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;

namespace Business.Concretes;
public class AuthManager : IAuthService
{
	IForgotPasswordService _forgotPasswordService;
	IUserService _userService;
	IMapper _mapper;
	ITokenHelper _tokenHelper;
	AuthBusinessRules _authbusinessRules;	
	public AuthManager(IUserService userService, IMapper mapper, ITokenHelper tokenHelper, AuthBusinessRules authBusinessRules,IForgotPasswordService forgotPasswordService)
	{
		_userService = userService;
		_mapper = mapper;
		_tokenHelper = tokenHelper;
		_authbusinessRules = authBusinessRules;
		_forgotPasswordService = forgotPasswordService;
    }
	[ValidationAspect(typeof(LoginValidator))]
	public async Task<IUser> Login(LoginRequest loginRequest)
	{		
		return await _authbusinessRules.UserToCheck(loginRequest);
	}
	[ValidationAspect(typeof(RegisterValidator))]
	public async Task<IUser> Register(RegisterRequest registerRequest)
	{
		bool isRegister= await _authbusinessRules.CheckIfUserExists(registerRequest.Email);
		if (isRegister)
		{
			HashingHelper.CreatePasswordHash(registerRequest.Password, out registerRequest._passwordHash, out registerRequest._passwordSalt);
			User user = _mapper.Map<User>(registerRequest);
			CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);
			CreatedUserResponse createdUserResponse = await _userService.AddAsync(createUserRequest);
			return _mapper.Map<User>(createdUserResponse);
		}
		else
		{
			return null;
		}
	}
	public AccessToken CreateAccessToken(IUser user)
	{
		var claims = _userService.GetClaims(user);
		var accessToken = _tokenHelper.CreateToken(user, claims);
		return accessToken;
	}
	[ValidationAspect(typeof(ChangePasswordValidator))]
    public async Task ChangePassword(CreateChangePasswordRequest createChangePasswordRequest)
    {
		byte[] passwordHash,passwordSalt;
		User user = await _userService.GetByMailAsync(createChangePasswordRequest.Mail, false);
        HashingHelper.CreatePasswordHash(createChangePasswordRequest.Password, out passwordHash, out passwordSalt);
		user.PasswordHash = passwordHash;
		user.PasswordSalt = passwordSalt;
		await _userService.UpdateAsync(_mapper.Map<UpdateUserRequest>(user));
		await _forgotPasswordService.DeleteByUserIdAsync(user.Id);
    }
}