using Business.Abstracts;
using Business.Dtos.Requests.UserApplication;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApplicationsController : ControllerBase
    {
        IUserApplicationService _userApplicationService;

        public UserApplicationsController(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateUserApplicationRequest createUserApplicationRequest)
        {
            var result = await _userApplicationService.AddAsync(createUserApplicationRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _userApplicationService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetUserApplicationRequest getUserApplicationRequest)
        {
            var result = await _userApplicationService.GetByIdAsync(getUserApplicationRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserApplicationRequest deleteUserApplicationRequest)
        {
            var result = await _userApplicationService.DeleteAsync(deleteUserApplicationRequest);
            return Ok(result);
        }
    }

}
