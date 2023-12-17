using Business.Abstracts;
using Business.Dtos.Requests.Skill;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SkillsController : ControllerBase
	{

		ISkillService _skillService;
		public SkillsController(ISkillService skillService)
		{
			_skillService = skillService;
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreateSkillRequest createSkillRequest)
		{
			var result = await _skillService.AddAsync(createSkillRequest);
			return Ok(result);
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
		{
			var result = await _skillService.GetListAsync(pageRequest);
			return Ok(result);
		}
		[HttpGet("Get")]
		public async Task<IActionResult> Get([FromQuery] GetSkillRequest getSkillRequest)
		{
			var result = await _skillService.GetByIdAsync(getSkillRequest);
			return Ok(result);
		}
		[HttpDelete]
		public async Task<IActionResult> Delete([FromBody] DeleteSkillRequest deleteSkillRequest)
		{
			var result = await _skillService.DeleteAsync(deleteSkillRequest);
			return Ok(result);
		}
		[HttpPut]
		public async Task<IActionResult> Update([FromBody] UpdateSkillRequest updateSkillRequest)
		{
			var result = await _skillService.UpdateAsync(updateSkillRequest);
			return Ok(result);
		}
	}
}
