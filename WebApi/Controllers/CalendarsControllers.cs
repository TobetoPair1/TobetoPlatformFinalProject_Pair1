using Business.Abstracts;
using Business.Dtos.Requests.Calendar;
using Business.Dtos.Requests.UserCalendar;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarsControllers : ControllerBase
    {
        ICalendarService _calendarService;
        public CalendarsControllers(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCalendarRequest createCalendarRequest)
        {
            var result = await _calendarService.AddAsync(createCalendarRequest);
            return Ok(result);
        }
        
        [HttpGet("get")]
        public async Task<IActionResult> Get([FromQuery] GetCalendarRequest getCalendarRequest)
        {
            var result = await _calendarService.GetByIdAsync(getCalendarRequest);
            return Ok(result);
        }
        
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            var result = await _calendarService.GetListAsync(pageRequest);
            return Ok(result);
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCalendarRequest deleteCalendarRequest)
        {
            var result = await _calendarService.DeleteAsync(deleteCalendarRequest);
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCalendarRequest updateCalendarRequest)
        {
            var result = await _calendarService.UpdateAsync(updateCalendarRequest);
            return Ok(result);
        }
        
        [HttpGet("getbyuserid")]
        public async Task<IActionResult> GetByUserId([FromQuery] Guid userId, [FromQuery] PageRequest pageRequest)
        {
            var result = await _calendarService.GetByUserId(userId, pageRequest);
            return Ok(result);
        }
        
        [HttpPost("assign")]
        public async Task<IActionResult> Assign([FromBody] CreateUserCalendarRequest createUserCalendarRequest)
        {
            var result = await _calendarService.AssignCalendarAsync(createUserCalendarRequest);
            return Ok(result);
        }
    }
}
