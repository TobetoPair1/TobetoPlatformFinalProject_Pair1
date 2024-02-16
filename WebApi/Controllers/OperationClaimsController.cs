using Business.Abstracts;
using Business.Dtos.Requests.OperationClaim;
using Business.Dtos.Requests.UserOperationClaim;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OperationClaimsController : ControllerBase
{
    private readonly IOperationClaimService _operationClaimService;
    public OperationClaimsController(IOperationClaimService operationClaimService)
    {
        _operationClaimService = operationClaimService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateOperationClaimRequest operationClaimRequest)
    {
        var result = await _operationClaimService.AddAsync(operationClaimRequest);
        return Ok(result);
    }
	[HttpPost("assigntouser")]
	public async Task<IActionResult> AssigntToUser([FromBody] CreateUserOperationClaimRequest createUserOperationClaimRequest)
	{
		var result = await _operationClaimService.AssignOperationClaimAsync(createUserOperationClaimRequest);
		return Ok(result);
	}
	[HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetOperationClaimRequest getOperationClaimRequest)
    {
        var result = await _operationClaimService.GetByIdAsync(getOperationClaimRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _operationClaimService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOperationClaimRequest deleteOperationClaimRequest)
    {
        var result = await _operationClaimService.DeleteAsync(deleteOperationClaimRequest);
        return Ok(result);
    }
}