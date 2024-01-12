using Business.Dtos.Requests.Auth.Request;
using Business.Dtos.Responses.Auth;
using Core.Entities;
using Core.Utilities.Security.Jwt;
using Entities.Concretes;


namespace Business.Abstracts
{
    public interface IAuthService
    {
        Task<IUser> Register(RegisterRequest registerRequest);
        Task<IUser> Login(LoginRequest loginRequest);
        Task UserExists(string email);
        AccessToken CreateAccessToken(IUser user);
    }
}
