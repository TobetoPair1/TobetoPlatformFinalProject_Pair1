using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.UserFavourite;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFavouriteController : ControllerBase
    {
        private readonly IUserFavouriteService _userFavouriteService;
        public UserFavouriteController(IUserFavouriteService userFavouriteService)
        {
            _userFavouriteService = userFavouriteService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserFavouriteRequest userFavouriteRequest)
        {
            var result = await _userFavouriteService.AddAsync(userFavouriteRequest);
            return Ok(result);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetUserFavouriteRequest getUserFavouriteRequest)
        {
            var result = await _userFavouriteService.GetByIdAsync(getUserFavouriteRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _userFavouriteService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserFavouriteRequest deleteUserFavouriteRequest)
        {
            var result = await _userFavouriteService.DeleteAsync(deleteUserFavouriteRequest);
            return Ok(result);
        }
    }
}
