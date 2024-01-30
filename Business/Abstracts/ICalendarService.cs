using Business.Dtos.Requests.Calendar;
using Business.Dtos.Requests.UserCalendar;
using Business.Dtos.Responses.Calender;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICalendarService
{
    Task<CreatedCalendarResponse> AddAsync(CreateCalendarRequest createCalendarRequest);
    Task<IPaginate<GetListCalendarResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedCalendarResponse> DeleteAsync(DeleteCalendarRequest deleteCalendarRequest);
    Task<UpdatedCalendarResponse> UpdateAsync(UpdateCalendarRequest updateCalendarRequest);
    Task<GetCalendarResponse> GetByIdAsync(GetCalendarRequest getCalendarRequest);
    Task<IPaginate<GetListCalendarResponse>> GetByUserId(Guid userId, PageRequest pageRequest);
    Task<CreatedUserCalendarResponse> AssignCalendarAsync(CreateUserCalendarRequest createUserCalendarRequest);

}
