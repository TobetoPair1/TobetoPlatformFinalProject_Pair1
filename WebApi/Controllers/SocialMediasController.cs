using Business.Abstracts;
using Business.Dtos.Requests.SocialMedia;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
    ISocialMediaService _socialMediaService;

    public SocialMediaController(ISocialMediaService socialMediaService)
    {
        _socialMediaService = socialMediaService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSocialMediaRequest createSocialMediaRequest)
    {
        var result = await _socialMediaService.AddAsync(createSocialMediaRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _socialMediaService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("getlistbyuserid")]
    public async Task<IActionResult> GetListByUserId([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _socialMediaService.GetListByUserIdAsync(pageRequest, userId);
        return Ok(result);
    }

    [HttpGet("get")]
    public async Task<IActionResult> Get([FromQuery] GetSocialMediaRequest getSocialMediaRequest)
    {
        var result = await _socialMediaService.GetByIdAsync(getSocialMediaRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteSocialMediaRequest deleteSocialMediaRequest)
    {
        var result = await _socialMediaService.DeleteAsync(deleteSocialMediaRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        var result = await _socialMediaService.UpdateAsync(updateSocialMediaRequest);
        return Ok(result);
    }
}