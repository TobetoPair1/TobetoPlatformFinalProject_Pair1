using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Responses.CourseLiveContent;
using Core.DataAccess.Paging;

namespace Business.Abstracts;
public interface ICourseLiveContentService
{
     Task<CreatedCourseLiveContentResponse> AddAsync(CreateCourseLiveContentRequest createCourseLiveContentRequest);
     Task<IPaginate<GetListCourseLiveContentResponse>> GetListAsync(PageRequest pageRequest);
     Task<DeletedCourseLiveContentResponse> DeleteAsync(DeleteCourseLiveContentRequest deleteCourseLiveContentRequest);
     Task<UpdatedCourseLiveContentResponse> UpdateAsync(UpdateCourseLiveContentRequest updateCourseLiveContentRequest);
     Task<GetCourseLiveContentResponse> GetAsync(Guid Id);
}

