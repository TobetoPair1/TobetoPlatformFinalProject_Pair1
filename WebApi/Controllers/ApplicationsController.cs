using Business.Abstracts;
using Business.Dtos.Requests.Application;
using Business.Dtos.Requests.UserApplication;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ApplicationsController : ControllerBase
{
    IApplicationService _applicationService;
    public ApplicationsController(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateApplicationRequest createApplicationRequest)
    {
        var result = await _applicationService.AddAsync(createApplicationRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _applicationService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetApplicationRequest getApplicationRequest)
    {
        var result = await _applicationService.GetByIdAsync(getApplicationRequest);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteApplicationRequest deleteApplicationRequest)
    {
        var result = await _applicationService.DeleteAsync(deleteApplicationRequest);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateApplicationRequest updateApplicationRequest)
    {
        var result = await _applicationService.UpdateAsync(updateApplicationRequest);
        return Ok(result);
    }

    [HttpGet("getlistbyuserid")]
    public async Task<IActionResult> GetListByUserId ([FromQuery] PageRequest pageRequest, Guid userId )
    {
        var result = await _applicationService.GetListByUserIdAsync(userId, pageRequest);
        return Ok(result);
    }

    [HttpPost("assignapplication")]
    public async Task<IActionResult> AssignApplicationAsync([FromBody] CreateUserApplicationRequest createUserApplicationRequest)
    {
        var result = await _applicationService.AssignApplicationAsync(createUserApplicationRequest);
        return Ok(result);
    }
}