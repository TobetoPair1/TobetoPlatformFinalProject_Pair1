using Business.Abstracts;
using Business.Dtos.Requests.ForeignLanguage;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ForeignLanguagesController : ControllerBase
{

    IForeignLanguageService _foreignLanguageService;
    public ForeignLanguagesController(IForeignLanguageService foreignLanguageService)
    {
        _foreignLanguageService = foreignLanguageService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateForeignLanguageRequest createForeignLanguageRequest)
    {
        var result = await _foreignLanguageService.AddAsync(createForeignLanguageRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _foreignLanguageService.GetListAsync(pageRequest);
        return Ok(result);
    }
    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetForeignLanguageRequest getForeignLanguageRequest)
    {
        var result = await _foreignLanguageService.GetByIdAsync(getForeignLanguageRequest);
        return Ok(result);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteForeignLanguageRequest deleteForeignLanguageRequest)
    {
        var result = await _foreignLanguageService.DeleteAsync(deleteForeignLanguageRequest);
        return Ok(result);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateForeignLanguageRequest updateForeignLanguageRequest)
    {
        var result = await _foreignLanguageService.UpdateAsync(updateForeignLanguageRequest);
        return Ok(result);
    }
}
