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

		IUserSkillService _iuserSkillService;
		public UserSkillsController(IUserSkillService iuserSkillService)
		{
			_iuserSkillService = iuserSkillService;
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreateUserSkillRequest createUserSkillRequest)
		{
			var result = await _iuserSkillService.AddAsync(createUserSkillRequest);
			return Ok(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
		{
			var result = await _iuserSkillService.GetListAsync(pageRequest);
			return Ok(result);
		}
		[HttpGet("Get")]
		public async Task<IActionResult> Get([FromQuery] GetUserSkillRequest getUserSkillRequest)
		{
			var result = await _iuserSkillService.GetByIdAsync(getUserSkillRequest);
			return Ok(result);
		}
		[HttpDelete]
		public async Task<IActionResult> Delete([FromBody] DeleteUserSkillRequest deleteUserSkillRequest)
		{
			var result = await _iuserSkillService.DeleteAsync(deleteUserSkillRequest);
			return Ok(result);
		}		
	}
}
