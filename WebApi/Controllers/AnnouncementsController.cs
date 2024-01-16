using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnnouncementsController : ControllerBase
{
    private readonly IAnnouncementService _announcementService;
    public AnnouncementsController(IAnnouncementService announcementService)
    {
        _announcementService = announcementService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateAnnouncementRequest announcementRequest)
    {
        var result = await _announcementService.AddAsync(announcementRequest);
        return Ok(result);
    }
    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetAnnouncementRequest getAnnouncementRequest)
    {
        var result = await _announcementService.GetByIdAsync(getAnnouncementRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        var result = await _announcementService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAnnouncementRequest deleteAnnouncementRequest)
    {
        var result = await _announcementService.DeleteAsync(deleteAnnouncementRequest);
        return Ok(result);
    }
}
