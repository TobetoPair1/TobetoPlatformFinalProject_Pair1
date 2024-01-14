using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.AsyncContent;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsyncContentController : ControllerBase
    {
        private readonly IAsyncContentService _asyncContentService;
        public AsyncContentController(IAsyncContentService asyncContentService)
        {
            _asyncContentService = asyncContentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAsyncContentRequest asyncContentRequest)
        {
            var result = await _asyncContentService.AddAsync(asyncContentRequest);
            return Ok(result);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetAsyncContentRequest getAsyncContentRequest)
        {
            var result = await _asyncContentService.GetByIdAsync(getAsyncContentRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _asyncContentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAsyncContentRequest deleteAsyncContentRequest)
        {
            var result = await _asyncContentService.DeleteAsync(deleteAsyncContentRequest);
            return Ok(result);
        }
    }
}
