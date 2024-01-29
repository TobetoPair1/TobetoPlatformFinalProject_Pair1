using Business.Abstracts;
using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Requests.Session;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        ISessionService _sessionService;

        public SessionsController(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSessionRequest createSessionRequest)
        {
            var result = await _sessionService.AddAsync(createSessionRequest);
            return Ok(result);
        }

        [HttpPost("AssignToInstructor")]
        public async Task<IActionResult> AssignSessionToSession([FromBody] CreateInstructorSessionRequest createInstructorSessionRequest)
        {
            var result = await _sessionService.AssignSessionAsync(createInstructorSessionRequest);
            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _sessionService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] GetSessionRequest getSessionRequest)
        {
            var result = await _sessionService.GetByIdAsync(getSessionRequest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateSessionRequest updateSessionRequest)
        {
            var result = await _sessionService.UpdateAsync(updateSessionRequest);
            return Ok(result);
        }

        [HttpGet("GetListByInstructorId")]
        public async Task<IActionResult> GetListByInstructorId([FromQuery] PageRequest pageRequest, Guid instructorId)
        {
            var result = await _sessionService.GetListByInstructorIdAsync(instructorId, pageRequest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSessionRequest deleteSessionRequest)
        {
            var result = await _sessionService.DeleteAsync(deleteSessionRequest);
            return Ok(result);
        }
    }
}

