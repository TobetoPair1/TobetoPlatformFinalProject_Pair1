using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Auth.Request;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Auth;
using Business.Dtos.Responses.User;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;
        IMapper _mapper;

        public AuthManager(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public Task<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
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
            return _mapper.Map<LoginResponse>(userToCheck);
        }

        public async Task<RegisterResponse> Register(RegisterRequest registerRequest)
        {
            HashingHelper.CreatePasswordHash(registerRequest.Password, out registerRequest._passwordHash, out registerRequest._passwordSalt);
            User user = _mapper.Map<User>(registerRequest);
            CreateUserRequest createUserRequest = _mapper.Map<CreateUserRequest>(user);

            var result = await _userService.AddAsync(createUserRequest);
            return _mapper.Map<RegisterResponse>(result);


        }

        public async Task<bool> UserExists(string email)
        {
            if (await _userService.GetByMailAsync(email) == null)
            {
                return false;
            }
            return true;
        }
    }
}
