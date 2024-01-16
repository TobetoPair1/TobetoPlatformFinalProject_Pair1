using Business.Abstracts;
using Business.Dtos.Requests.UserExam;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserExamsController : ControllerBase
{
    IUserExamService _userExamService;

    public UserExamsController(IUserExamService userExamService)
    {
        _userExamService = userExamService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserExamRequest createUserExamRequest)
    {
        var result = await _userExamService.AddAsync(createUserExamRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _userExamService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetUserExamRequest getUserExamRequest)
    {
        var result = await _userExamService.GetByIdAsync(getUserExamRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserExamRequest deleteUserExamRequest)
    {
        var result = await _userExamService.DeleteAsync(deleteUserExamRequest);
        return Ok(result);
    }
}
