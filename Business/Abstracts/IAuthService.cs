using Business.Dtos.Requests.Auth;
using Core.Entities;
using Core.Utilities.Security.Jwt;


namespace Business.Abstracts;

public interface IAuthService
{
    Task<IUser> Register(RegisterRequest registerRequest);
    Task<IUser> Login(LoginRequest loginRequest);
    AccessToken CreateAccessToken(IUser user);
}
