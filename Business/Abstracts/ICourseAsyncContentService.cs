using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICourseAsyncContentService
{
    Task<CreatedCourseAsyncContentResponse> AddAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest);
    Task<IPaginate<GetListCourseAsyncContentResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetCourseAyncContentResponse> GetAsync(GetCourseAyncContentRequest getCourseAyncContentRequest);
    Task<UpdatedCourseAsyncContentResponse> UpdateAsync(UpdateCourseAsyncContentRequest updateCourseAsyncContentRequest);
    Task<DeletedCourseAsyncContentResponse> DeleteAsync(DeleteCourseAsyncContentRequest deleteCourseAsyncContentRequest);
}

