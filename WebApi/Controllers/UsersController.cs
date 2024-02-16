using Business.Abstracts;
using Business.Dtos.Requests.User;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors]
public class UsersController : ControllerBase
{

    IUserService _userService;
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }


    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _userService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpGet("getbyid")]
    public async Task<IActionResult> Get([FromQuery] Guid id)
    {
        var result = await _userService.GetByIdAsync(id);
        return Ok(result);
    }
    [HttpGet("getbymail")]
    public async Task<IActionResult> GetByMail([FromQuery] string mail)
    {
        var result = await _userService.GetByMailUserAsync(mail);
        return Ok(result);
    }
    [HttpGet("activate")]
	public async Task<IActionResult> Activate([FromQuery] string email)
	{
		var result = await _userService.ActivateUserAsync(email);
		return Ok(result);
	}
	[HttpDelete("deletebyid")]
    public async Task<IActionResult> DeleteById([FromBody] Guid id)
    {
        var result = await _userService.DeleteByIdAsync(id);
        return Ok(result);
    }
	[HttpDelete("deletebymail")]
	public async Task<IActionResult> DeleteByMail([FromBody] string email)
	{
		var result = await _userService.DeleteByMailAsync(email);
		return Ok(result);
	}
	[HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserRequest UpdateUserRequest)
    {
        var result = await _userService.UpdateAsync(UpdateUserRequest);
        return Ok(result);
    }
}