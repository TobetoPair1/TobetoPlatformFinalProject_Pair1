using Business.Dtos.Requests.Auth.Request;
using Business.Dtos.Responses.Auth;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;


namespace Business.Abstracts
{
    public interface IAuthService
    {
        Task<RegisterResponse> Register(RegisterRequest registerRequest);
        Task<LoginResponse> Login(LoginRequest loginRequest);
        Task<bool> UserExists(string email);
        Task<AccessToken> CreateAccessToken(User user);
    }
}
