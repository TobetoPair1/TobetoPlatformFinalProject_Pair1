using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.Survey;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyService _surveyService;
        public SurveyController(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSurveyRequest surveyRequest)
        {
            var result = await _surveyService.AddAsync(surveyRequest);
            return Ok(result);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetSurveyRequest getSurveyRequest)
        {
            var result = await _surveyService.GetByIdAsync(getSurveyRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _surveyService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSurveyRequest deleteSurveyRequest)
        {
            var result = await _surveyService.DeleteAsync(deleteSurveyRequest);
            return Ok(result);
        }
    }
}
