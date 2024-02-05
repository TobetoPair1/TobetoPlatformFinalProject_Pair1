using Business.Abstracts;
using Business.Dtos.Requests.PersonalInfo;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonalInfosController : ControllerBase
{

    IPersonalInfoService _personalInfoService;
    public PersonalInfosController(IPersonalInfoService personalInfoService)
    {
        _personalInfoService = personalInfoService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePersonalInfoRequest createPersonalInfoRequest)
    {
        var result = await _personalInfoService.AddAsync(createPersonalInfoRequest);
        return Ok(result);
    }

    [HttpGet("getlist")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _personalInfoService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetById([FromQuery] GetPersonalInfoRequest getPersonalInfoRequest)
    {
        var result = await _personalInfoService.GetByIdAsync(getPersonalInfoRequest);
        return Ok(result);
    }
	[HttpGet("getbyuserid")]
	public async Task<IActionResult> GetUserId([FromQuery] GetPersonalInfoRequest getPersonalInfoRequest)
	{
		var result = await _personalInfoService.GetByUserIdAsync(getPersonalInfoRequest);
		return Ok(result);
	}

	[HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeletePersonalInfoRequest deletePersonalInfoRequest)
    {
        var result = await _personalInfoService.DeleteAsync(deletePersonalInfoRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePersonalInfoRequest updatePersonalInfoRequest)
    {
        var result = await _personalInfoService.UpdateAsync(updatePersonalInfoRequest);
        return Ok(result);
    }
}