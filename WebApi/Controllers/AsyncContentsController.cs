using Business.Abstracts;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Requests.CourseAsyncContent;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AsyncContentsController : ControllerBase
{
    private readonly IAsyncContentService _asyncContentService;
    public AsyncContentsController(IAsyncContentService asyncContentService)
    {
        _asyncContentService = asyncContentService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAsyncContentRequest asyncContentRequest)
    {
        var result = await _asyncContentService.AddAsync(asyncContentRequest);
        return Ok(result);
    }
	[HttpPost("assigntocourse")]
	public async Task<IActionResult> AssignToCourse([FromBody] CreateCourseAsyncContentRequest createCourseAsyncContentRequest)
	{
		var result = await _asyncContentService.AssignAsyncContentAsync(createCourseAsyncContentRequest);
		return Ok(result);
	}
	[HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetAsyncContentRequest getAsyncContentRequest)
    {
        var result = await _asyncContentService.GetByIdAsync(getAsyncContentRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _asyncContentService.GetListAsync(pageRequest);
        return Ok(result);
    }
	[HttpGet("getlistbycourseid")]
	public async Task<IActionResult> GetListByCourseId([FromQuery] PageRequest pageRequest,Guid courseId)
	{
		var result = await _asyncContentService.GetListByCourseIdAsync(courseId,pageRequest);
		return Ok(result);
	}

	[HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAsyncContentRequest deleteAsyncContentRequest)
    {
        var result = await _asyncContentService.DeleteAsync(deleteAsyncContentRequest);
        return Ok(result);
    }
}