using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.UserCalendar;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IUserCalendarService
{
	Task<CreatedUserCalenderResponse> AddAsync(CreateUserCourseRequest createUserCourseRequest);
	Task<IPaginate<GetListUserCourseResponse>> GetListAsync(PageRequest pageRequest);
	Task<GetUserCourseResponse> GetByIdAsync(GetUserCourseRequest getUserCourseRequest);
	Task<DeletedUserCourseResponse> DeleteAsync(DeleteUserCourseRequest deleteUserCourseRequest);
}
