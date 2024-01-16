using Business.Abstracts;
using Business.Dtos.Requests.File;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilesController : ControllerBase
{
    IFileService _fileService;

    public FilesController(IFileService fileService)
    {
        _fileService = fileService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateFileRequest createFileRequest)
    {
        var result = await _fileService.AddAsync(createFileRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _fileService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetFileRequest getFileRequest)
    {
        var result = await _fileService.GetByIdAsync(getFileRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteFileRequest deleteFileRequest)
    {
        var result = await _fileService.DeleteAsync(deleteFileRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateFileRequest updateFileRequest)
    {
        var result = await _fileService.UpdateAsync(updateFileRequest);
        return Ok(result);
    }
}

