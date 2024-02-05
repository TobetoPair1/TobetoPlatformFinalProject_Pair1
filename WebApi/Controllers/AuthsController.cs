using Business.Abstracts;
using Business.Dtos.Requests.Auth;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthsController : ControllerBase
{
    private IAuthService _authService;

    public AuthsController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginRequest loginRequest)
    {
        var userToLogin = await _authService.Login(loginRequest);

        var result = _authService.CreateAccessToken(userToLogin);
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest registerRequest)
    {
        var registeredUser = await _authService.Register(registerRequest);
        if (registeredUser==null)
        {
			//kullanıcı aktifleştirilsin mi sor?
		    return Ok(null);
		}
		var result = _authService.CreateAccessToken(registeredUser);
		return Ok(result);
	}
}