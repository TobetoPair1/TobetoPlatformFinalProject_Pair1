using Business.Abstracts;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Requests.PersonalInfo;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        IExperienceService _experienceService;

        public ExperiencesController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateExperienceRequest createExperienceRequest)
        {
            var result = await _experienceService.AddAsync(createExperienceRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _experienceService.GetListAsync(pageRequest);
            return Ok(result);
        }
    }
}
