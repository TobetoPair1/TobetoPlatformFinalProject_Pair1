using Business.Abstracts;
using Business.Dtos.Requests.UserCalendar;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserCalendarsController : ControllerBase
{
    IUserCalendarService _userCalendarService;

    public UserCalendarsController(IUserCalendarService userCalendarService)
    {
        _userCalendarService = userCalendarService;
    }


    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserCalendarRequest createUserCalendarRequest)
    {
        var result = await _userCalendarService.AddAsync(createUserCalendarRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _userCalendarService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetUserCalendarRequest getUserCalendarRequest)
    {
        var result = await _userCalendarService.GetByIdAsync(getUserCalendarRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserCalendarRequest deleteUserCalendarRequest)
    {
        var result = await _userCalendarService.DeleteAsync(deleteUserCalendarRequest);
        return Ok(result);
    }
}