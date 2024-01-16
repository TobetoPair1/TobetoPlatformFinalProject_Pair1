using Business.Abstracts;
using Business.Dtos.Requests.UserSkill;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserSkillsController : ControllerBase
	{

		IUserSkillService _userSkillService;
		public UserSkillsController(IUserSkillService iuserSkillService)
		{
			_userSkillService = iuserSkillService;
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreateUserSkillRequest createUserSkillRequest)
		{
			var result = await _userSkillService.AddAsync(createUserSkillRequest);
			return Ok(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
		{
			var result = await _userSkillService.GetListAsync(pageRequest);
			return Ok(result);
		}
		[HttpGet("Get")]
		public async Task<IActionResult> Get([FromQuery] GetUserSkillRequest getUserSkillRequest)
		{
			var result = await _userSkillService.GetByIdAsync(getUserSkillRequest);
			return Ok(result);
		}
		[HttpDelete]
		public async Task<IActionResult> Delete([FromBody] DeleteUserSkillRequest deleteUserSkillRequest)
		{
			var result = await _userSkillService.DeleteAsync(deleteUserSkillRequest);
			return Ok(result);
		}		
	}
}
