using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAsyncContentService
{
    Task<CreatedAsyncContentResponse> AddAsync(CreateAsyncContentRequest createAsyncContentRequest);
    Task<IPaginate<GetListAsyncContentResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedAsyncContentResponse> DeleteAsync(DeleteAsyncContentRequest deleteAsyncContentRequest);
    Task<UpdatedAsyncContentResponse> UpdateAsync(UpdateAsyncContentRequest updateAsyncContentRequest);
    Task<GetAsyncContentResponse> GetByIdAsync(GetAsyncContentRequest getAsyncContentRequest);
    Task<IPaginate<GetListAsyncContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest);
    Task<CreatedCourseAsyncContentResponse> AssignAsyncContentAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest);
}