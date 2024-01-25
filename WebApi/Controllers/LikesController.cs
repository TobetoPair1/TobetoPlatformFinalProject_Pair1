using Business.Abstracts;
using Business.Dtos.Requests.Like;
using Business.Dtos.Requests.UserLike;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LikesController : ControllerBase
{
    ILikeService _likeService;

    public LikesController(ILikeService likeService)
    {
        _likeService = likeService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateLikeRequest createLikeRequest)
    {
        var result = await _likeService.AddAsync(createLikeRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _likeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetLikeRequest getLikeRequest)
    {
        var result = await _likeService.GetByIdAsync(getLikeRequest);
        return Ok(result);
    }
    
    [HttpGet("getbyuserid")]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest, Guid userId)
    {
        var result = await _likeService.GetByUserId(userId, pageRequest);
        return Ok(result);
    }
    
    [HttpPost("assignlike")]
    public async Task<IActionResult> AssignLike([FromBody] CreateUserLikeRequest createUserLikeRequest)
    {
        var result = await _likeService.AssignLikeAsync(createUserLikeRequest);
        return Ok(result);
    }



    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteLikeRequest deleteLikeRequest)
    {
        var result = await _likeService.DeleteAsync(deleteLikeRequest);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLikeRequest updateLikeRequest)
    {
        var result = await _likeService.UpdateAsync(updateLikeRequest);
        return Ok(result);
    }
}



