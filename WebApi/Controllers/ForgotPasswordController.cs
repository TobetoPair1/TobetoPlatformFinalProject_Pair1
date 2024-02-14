using Business.Abstracts;
using Business.Dtos.Requests.ForgotPassword;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ForgotPasswordController : ControllerBase
{
    IForgotPasswordService _forgotPasswordService;
    public ForgotPasswordController(IForgotPasswordService forgotPasswordService)
    {
        _forgotPasswordService = forgotPasswordService;
    }

    [HttpGet("getbyuserid")]
    public async Task<IActionResult> GetByUserId([FromQuery] Guid userId,string code)
    {
        return Ok(await _forgotPasswordService.GetByUserIdAsync(userId,code));
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateForgotPasswordRequest createForgotPasswordRequest)
    {
        return Ok(await _forgotPasswordService.AddAsync(createForgotPasswordRequest));
    }
}