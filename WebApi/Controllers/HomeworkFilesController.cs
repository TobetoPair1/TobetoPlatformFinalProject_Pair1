using Business.Abstracts;
using Business.Dtos.Requests.HomeworkFile;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeworkFilesController : ControllerBase
{
    IHomeworFileService _homeworkFileService;
    public HomeworkFilesController(IHomeworFileService courseService)
    {
        _homeworkFileService = courseService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateHomeworkFileRequest createHomeworkFileRequest)
    {
        var result = await _homeworkFileService.AddAsync(createHomeworkFileRequest);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _homeworkFileService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteHomeworkFileRequest deleteHomeworkFileRequest)
    {
        var result = await _homeworkFileService.DeleteAsync(deleteHomeworkFileRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateHomeworkFileRequest updateHomeworkFileRequest)
    {
        var result = await _homeworkFileService.UpdateAsync(updateHomeworkFileRequest);
        return Ok(result);
    }
}