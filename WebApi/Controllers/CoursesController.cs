using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    ICourseService _courseService;
    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCourseRequest createCourseRequest)
    {
        var result = await _courseService.AddAsync(createCourseRequest);
        return Ok(result);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] Guid id)
    {
        var result = await _courseService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _courseService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCourseRequest deleteCourseRequest)
    {
        var result = await _courseService.DeleteAsync(deleteCourseRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCourseRequest updateCourseRequest)
    {
        var result = await _courseService.UpdateAsync(updateCourseRequest);
        return Ok(result);
    }
}




