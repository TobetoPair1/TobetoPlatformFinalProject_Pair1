using Business.Abstracts;
using Business.Dtos.Requests.UserLike;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserLikesController : ControllerBase
{
    IUserLikeService _userLikeService;

    public UserLikesController(IUserLikeService userLikeService)
    {
        _userLikeService = userLikeService;
    }


    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUserLikeRequest createUserLikeRequest)
    {
        var result = await _userLikeService.AddAsync(createUserLikeRequest);
        return Ok(result);
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _userLikeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("Get")]
    public async Task<IActionResult> Get([FromQuery] GetUserLikeRequest getUserLikeRequest)
    {
        var result = await _userLikeService.GetByIdAsync(getUserLikeRequest);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserLikeRequest deleteUserLikeRequest)
    {
        var result = await _userLikeService.DeleteAsync(deleteUserLikeRequest);
        return Ok(result);
    }
}

