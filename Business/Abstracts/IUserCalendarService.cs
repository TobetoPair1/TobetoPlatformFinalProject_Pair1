using Business.Dtos.Requests.UserCalendar;
using Business.Dtos.Responses.Calender;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserCalendarService
{
	Task<CreatedUserCalendarResponse> AddAsync(CreateUserCalendarRequest createUserCalendarRequest);
	Task<IPaginate<GetListUserCalendarResponse>> GetListAsync(PageRequest pageRequest);
	Task<GetUserCalendarResponse> GetByIdAsync(GetUserCalendarRequest getUserCalendarRequest);
	Task<DeletedUserCalendarResponse> DeleteAsync(DeleteUserCalendarRequest deleteUserCalendarRequest);
	Task<IPaginate<GetListCalendarResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);

}