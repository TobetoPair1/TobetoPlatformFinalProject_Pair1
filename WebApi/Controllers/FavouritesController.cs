using Business.Abstracts;
using Business.Dtos.Requests.Favourite;

using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        IFavouriteService _favouriteService;
        public FavouritesController(IFavouriteService favouriteService)
        {
            _favouriteService = favouriteService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateFavouriteRequest createFavouriteRequest)
        {
            var result = await _favouriteService.AddAsync(createFavouriteRequest);
            return Ok(result);
        }
		
		[HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetFavouriteRequest getFavouriteRequest)
        {
            var result = await _favouriteService.GetByIdAsync(getFavouriteRequest);
            return Ok(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _favouriteService.GetListAsync(pageRequest);
            return Ok(result);
        }
		[HttpGet("getlistbyuserid")]
		/*public async Task<IActionResult> GetListByUserId([FromQuery] PageRequest pageRequest,Guid userId)
		{
			var result = await _favouriteService.GetListByUserIdAsync(userId,pageRequest);
			return Ok(result);
		}*/

		[HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteFavouriteRequest deleteFavouriteRequest)
        {
            var result = await _favouriteService.DeleteAsync(deleteFavouriteRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFavouriteRequest updateFavouriteRequest)
        {
            var result = await _favouriteService.UpdateAsync(updateFavouriteRequest);
            return Ok(result);
        }
    }
}
