using Business.Abstracts;
using Business.Dtos.Requests.CourseLiveContent;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseLiveContentsController : ControllerBase
{
    ICourseLiveContentService _courseLiveContentService;

    public CourseLiveContentsController(ICourseLiveContentService courseLiveContentService)
    {
        _courseLiveContentService = courseLiveContentService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCourseLiveContentRequest createCourseLiveContentRequest)
    {
        var result = await _courseLiveContentService.AddAsync(createCourseLiveContentRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _courseLiveContentService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery]GetCourseLiveContentRequest getCourseLiveContentRequest)
    {
        var result = await _courseLiveContentService.GetAsync(getCourseLiveContentRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCourseLiveContentRequest updateCourseLiveContentRequest)
    {
        var result = await _courseLiveContentService.UpdateAsync(updateCourseLiveContentRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCourseLiveContentRequest deleteCourseLiveContentRequest)
    {
        var result = await _courseLiveContentService.DeleteAsync(deleteCourseLiveContentRequest);
        return Ok(result);
    }
}