using Business.Abstracts;
using Business.Dtos.Requests.CourseAsyncContent;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseAsyncContentsController : ControllerBase
{
    ICourseAsyncContentService _courseAsyncContentService;

    public CourseAsyncContentsController(ICourseAsyncContentService courseAsyncContentService)
    {
        _courseAsyncContentService = courseAsyncContentService;
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateCourseAsyncContentRequest createCourseAsyncContent)
    {
        return Ok(await _courseAsyncContentService.AddAsync(createCourseAsyncContent));
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll(PageRequest pageRequest)
    {
        return Ok(await _courseAsyncContentService.GetListAsync(pageRequest));
    }

    [HttpGet("get")]
    public async Task<IActionResult> Get(GetCourseAyncContentRequest getCourseAyncContentRequest)
    {
        return Ok(await _courseAsyncContentService.GetAsync(getCourseAyncContentRequest));
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCourseAsyncContentRequest updateCourseAsyncContent)
    {
        return Ok(await _courseAsyncContentService.UpdateAsync(updateCourseAsyncContent));
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(DeleteCourseAsyncContentRequest deleteCourseAsyncContentRequest)
    {
        return Ok(await _courseAsyncContentService.DeleteAsync(deleteCourseAsyncContentRequest));
    }
}

