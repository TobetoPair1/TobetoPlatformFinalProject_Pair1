using Business.Abstracts;
using Business.Dtos.Requests.ForgotPassword;
using Core.DataAccess.Paging;
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
    
    [HttpGet("getlist")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        return Ok(await _forgotPasswordService.GetListAsync(pageRequest));
    }
    
    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] Guid id)
    {
        return Ok(await _forgotPasswordService.GetByIdAsync(id));
    }
    
}