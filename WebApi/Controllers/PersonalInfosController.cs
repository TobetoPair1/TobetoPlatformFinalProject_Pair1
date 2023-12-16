using Business.Abstracts;
using Business.Dtos.Requests.PersonalInfo;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonalInfosController : ControllerBase
	{

		IPersonalInfoService _personalInfoService;
		public PersonalInfosController(IPersonalInfoService personalInfoService)
		{
			_personalInfoService = personalInfoService;
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] CreatePersonalInfoRequest createPersonalInfoRequest)
		{
			var result = await _personalInfoService.AddAsync(createPersonalInfoRequest);
			return Ok(result);
		}

		[HttpGet]
		public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
		{
			var result = await _personalInfoService.GetListAsync(pageRequest);
			return Ok(result);
		}
	}
}
