using Business.Abstracts;
using Business.Dtos.Requests.Certificate;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CertificatesController : ControllerBase
{
    private readonly ICertificateService _certificateService;
    public CertificatesController(ICertificateService certificateService)
    {
        _certificateService = certificateService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCertificateRequest certificateRequest)
    {
        var result = await _certificateService.AddAsync(certificateRequest);
        return Ok(result);
    }
    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] Guid id)
    {
        var result = await _certificateService.GetAsync(id);
        return Ok(result);
    }

    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _certificateService.GetListAsync(pageRequest);
        return Ok(result);
    }
	[HttpGet("getlistbyuserid")]
	public async Task<IActionResult> GetListByUserId([FromQuery] PageRequest pageRequest,Guid userId)
	{
		var result = await _certificateService.GetListByUserIdAsync(pageRequest,userId);
		return Ok(result);
	}

	[HttpDelete]
    public async Task<IActionResult> Delete([FromBody] Guid id)
    {
        var result = await _certificateService.DeleteAsync(id);
        return Ok(result);
    }
}