using Business.Dtos.Requests.Auth.Request;
using Core.Entities;
using Core.Utilities.Security.Jwt;


namespace Business.Abstracts;

public interface IAuthService
{
    Task<IUser> Register(RegisterRequest registerRequest);
    Task<IUser> Login(LoginRequest loginRequest);
    Task UserExists(string email);
    AccessToken CreateAccessToken(IUser user);
}
