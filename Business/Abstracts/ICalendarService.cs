using Business.Dtos.Requests.Calendar;
using Business.Dtos.Responses.Calender;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICalendarService
{
    Task<CreatedCalendarResponse> AddAsync(CreateCalendarRequest createCalendarRequest);
    Task<IPaginate<GetListCalendarResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedCalendarResponse> DeleteAsync(DeleteCalendarRequest deleteCalendarRequest);
    Task<UpdatedCalendarResponse> UpdateAsync(UpdateCalendarRequest updateCalendarRequest);
    Task<GetCalendarResponse> GetByIdAsync(GetCalendarRequest getCalendarRequest);
}
