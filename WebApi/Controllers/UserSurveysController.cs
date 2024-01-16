using Business.Abstracts;
using Business.Dtos.Requests.UserSurvey;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSurveysController : ControllerBase
    {
        IUserSurveyService _userSurveyService;

        public UserSurveysController(IUserSurveyService userSurveyService)
        {
            _userSurveyService = userSurveyService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserSurveyRequest createUserSurveyRequest)
        {
            var result = await _userSurveyService.AddAsync(createUserSurveyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _userSurveyService.GetListAsync(pageRequest);
            return Ok(result);  
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetUserSurveyRequest getUserSurveyRequest)
        {
            var result = await _userSurveyService.GetByIdAsync(getUserSurveyRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserSurveyRequest deleteUserSurveyRequest)
        {
            var result = await _userSurveyService.DeleteAsync(deleteUserSurveyRequest);
            return Ok(result);  
        }
    }
}
