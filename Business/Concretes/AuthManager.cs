using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Auth.Request;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Auth;
using Business.Dtos.Responses.User;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        IMapper _mapper;
        ITokenHelper _tokenHelper;

		public AuthManager(IUserService userService, IMapper mapper, ITokenHelper tokenHelper)
		{
			_userService = userService;
			_mapper = mapper;
			_tokenHelper = tokenHelper;
		}
		

        public async Task<IUser> Login(LoginRequest loginRequest)
        {
            var userToCheck = await _userService.GetByMailAsync(loginRequest.Email);
            if (userToCheck == null)
            {
                return null;
            }
            if (!HashingHelper.VerifyPasswordHash(loginRequest.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return null;
            }
            return userToCheck;
        }

        public async Task<IUser> Register(RegisterRequest registerRequest)
        {
            HashingHelper.CreatePasswordHash(registerRequest.Password, out registerRequest._passwordHash, out registerRequest._passwordSalt);
            User user = _mapper.Map<User>(registerRequest);
            CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);
            await _userService.AddAsync(createUserRequest);
            return user;


        }

        public async Task<bool> UserExists(string email)
        {
            if (await _userService.GetByMailAsync(email) == null)
            {
                return false;
            }
            return true;
        }
		public AccessToken CreateAccessToken(IUser user)
		{
			var claims = _userService.GetClaims(user);
			var accessToken = _tokenHelper.CreateToken(user, claims);
            return accessToken;
		}
	}
}
