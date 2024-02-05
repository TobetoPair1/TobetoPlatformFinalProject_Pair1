using Business.Abstracts;
using Business.Dtos.Requests.Experience;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExperiencesController : ControllerBase
{
    IExperienceService _experienceService;

    public ExperiencesController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
    {
        var result = await _experienceService.AddAsync(createExperienceRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _experienceService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("getlistbyuserid")]
    public async Task<IActionResult> GetListByUserIdAsync([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _experienceService.GetListByUserIdAsync(userId, pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetExperienceRequest getExperienceRequest)
    {
        var result = await _experienceService.GetByIdAsync(getExperienceRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteExperienceRequest deleteExperienceRequest)
    {
        var result = await _experienceService.DeleteAsync(deleteExperienceRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateExperienceRequest updateExperienceRequest)
    {
        var result = await _experienceService.UpdateAsync(updateExperienceRequest);
        return Ok(result);
    }
}