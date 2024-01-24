using Business.Dtos.Requests.UserCalendarr;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserCalendarService
{
	Task<CreatedUserCalendarResponse> AddAsync(CreateUserCalendarRequest createUserCalendarRequest);
	Task<IPaginate<GetListUserCalendarResponse>> GetListAsync(PageRequest pageRequest);
	Task<GetUserCalendarResponse> GetByIdAsync(GetUserCalendarRequest getUserCalendarRequest);
	Task<DeletedUserCalendarResponse> DeleteAsync(DeleteUserCalendarRequest deleteUserCalendarRequest);
}