using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICourseService
{
    Task<CreatedCourseResponse> AddAsync(CreateCourseRequest createCourseRequest);
    Task<IPaginate<GetListCourseResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedCourseResponse> DeleteAsync(DeleteCourseRequest deleteCourseRequest);
    Task<UpdatedCourseResponse> UpdateAsync(UpdateCourseRequest updateCourseRequest);
    Task<GetCourseResponse> GetByIdAsync(GetCourseRequest getCourseRequest);
	Task<IPaginate<GetListCourseResponse>> GetByUserId(Guid userId, PageRequest pageRequest);
	Task<CreatedUserCourseResponse> AssignCourseAsync(CreateUserCourseRequest createUserCourseRequest);
}


