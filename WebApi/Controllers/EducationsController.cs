using Business.Abstracts;
using Business.Dtos.Requests.Education;
using Business.Dtos.Requests.Experience;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _educationService;
        public EducationsController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateEducationRequest createEducationRequest)
        {
            var result = await _educationService.AddAsync(createEducationRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _educationService.GetListAsync(pageRequest);
            return Ok(result);
        }
    }
}
