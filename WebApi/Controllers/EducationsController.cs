using Business.Abstracts;
using Business.Dtos.Requests.Education;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationsController : ControllerBase
{
    IEducationService _educationService;
    public EducationsController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateEducationRequest createEducationRequest)
    {
        var result = await _educationService.AddAsync(createEducationRequest);
        return Ok(result);
    }

    [HttpGet("getlistbyuserid")]
    public async Task<IActionResult> GetListByUserIdAsync([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _educationService.GetListByUserIdAsync(userId, pageRequest);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteEducationRequest deleteEducationRequest)
    {
        var result = await _educationService.DeleteAsync(deleteEducationRequest);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _educationService.GetListAsync(pageRequest);
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateEducationRequest updateEducationRequest)
    {
        var result = await _educationService.UpdateAsync(updateEducationRequest);
        return Ok(result);
    }
    
    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetEducationRequest getEducationRequest)
    {
        var result = await _educationService.GetByIdAsync(getEducationRequest);
        return Ok(result);
    }
}