using Business.Abstracts;
using Business.Dtos.Requests.Assignment;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AssignmentsController : ControllerBase
{
    private readonly IAssignmentService _assignmentService;
    public AssignmentsController(IAssignmentService assignmentService)
    {
        _assignmentService = assignmentService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAssigmentRequest createAssigmentRequest)
    {
        var result = await _assignmentService.AddAsync(createAssigmentRequest);
        return Ok(result);
    }
    [HttpGet("getbyid")]
    public async Task<IActionResult> Get([FromQuery] Guid id)
    {
        var result = await _assignmentService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _assignmentService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAssigmentRequest deleteAssigmentRequest)
    {
        var result = await _assignmentService.DeleteAsync(deleteAssigmentRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAssigmentRequest updateAssigmentRequest)
    {
        var result = await _assignmentService.UpdateAsync(updateAssigmentRequest);
        return Ok(result);
    }
}