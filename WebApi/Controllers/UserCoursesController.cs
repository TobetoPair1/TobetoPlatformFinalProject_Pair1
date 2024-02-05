using Business.Abstracts;
using Business.Dtos.Requests.UserCourse;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserCoursesController : ControllerBase
{

    IUserCourseService _userCourseService;
    public UserCoursesController(IUserCourseService userSkillService)
    {
        _userCourseService = userSkillService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserCourseRequest createUserCourseRequest)
    {
        var result = await _userCourseService.AddAsync(createUserCourseRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _userCourseService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetUserCourseRequest cetUserCourseRequest)
    {
        var result = await _userCourseService.GetByIdAsync(cetUserCourseRequest);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserCourseRequest deleteUserCourseRequest)
    {
        var result = await _userCourseService.DeleteAsync(deleteUserCourseRequest);
        return Ok(result);
    }
}