using Business.Dtos.Requests.HomeworkFile;
using Business.Dtos.Responses.HomeworkFile;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IHomeworFileService
{
    Task<CreatedHomeworkFileResponse> AddAsync(CreateHomeworkFileRequest createHomeworkFileRequest);
    Task<IPaginate<GetListHomeworkFileResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedHomeworkFileResponse> DeleteAsync(DeleteHomeworkFileRequest deleteHomeworkFileRequest);
    Task<UpdatedHomeworkFileResponse> UpdateAsync(UpdateHomeworkFileRequest updateHomeworkFileRequest);
}
