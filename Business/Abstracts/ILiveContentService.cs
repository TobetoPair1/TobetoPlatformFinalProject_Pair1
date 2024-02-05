using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Requests.LiveContent;
using Business.Dtos.Responses.CourseLiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ILiveContentService
{
    Task<CreatedLiveContentResponse> AddAsync(CreateLiveContentRequest createLiveContentRequest);
    Task<DeletedLiveContentResponse> DeleteAsync(DeleteLiveContentRequest deleteLiveContentRequest);
    Task<UpdatedLiveContentResponse> UpdateAsync(UpdateLiveContentRequest updateAsyncContentRequest);
    Task<GetLiveContentResponse> GetByIdAsync(GetLiveContentRequest getLiveContentRequest);  
    Task<IPaginate<GetListLiveContentResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListLiveContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest);
    Task<CreatedCourseLiveContentResponse> AssignContentAsync(CreateCourseLiveContentRequest createCourseLiveContentRequest);
}