using Business.Abstracts;
using Business.Dtos.Requests.Auth.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginRequest loginRequest)
        {
            var result = await _authService.Login(loginRequest);
            if (result == null)
            {
                return BadRequest("giriş başarısız");
            }

            //var result = _authService.CreateAccessToken(userToLogin.Data);
            //if (result.Success)
            //{
            //    return Ok(result.Data);
            //}

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            var userExists = await _authService.UserExists(registerRequest.Email);
            if (userExists)
            {
                return BadRequest("kullanıcı mevcut");
            }

            var result =await _authService.Register(registerRequest);

            return Ok(result);
        }
    }
}

