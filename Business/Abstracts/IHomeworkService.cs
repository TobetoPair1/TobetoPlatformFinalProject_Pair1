using Business.Dtos.Requests.Homework;
using Business.Dtos.Responses.Homework;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IHomeworkService
{
    Task<CreatedHomeworkResponse> AddAsync(CreateHomeworkRequest createHomeworkRequest);
    Task<IPaginate<GetListHomeworkResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedHomeworkResponse> DeleteAsync(DeleteHomeworkRequest deleteHomeworkRequest);
    Task<UpdatedHomeworkResponse> UpdateAsync(UpdateHomeworkRequest updateHomeworkRequest);
    Task<GetHomeworkResponse> GetByIdAsync(GetHomeworkRequest getHomeworkRequest);
}