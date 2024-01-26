using Business.Dtos.Requests.HomeworkFile;
using Business.Dtos.Responses.File;
using Business.Dtos.Responses.HomeworkFile;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IHomeworFileService
{
    Task<CreatedHomeworkFileResponse> AddAsync(CreateHomeworkFileRequest createHomeworkFileRequest);
    Task<IPaginate<GetListHomeworkFileResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListFileResponse>> GetListByHomeworkIdAsync(Guid homeworkId, PageRequest pageRequest);
    Task<DeletedHomeworkFileResponse> DeleteAsync(DeleteHomeworkFileRequest deleteHomeworkFileRequest);
    Task<UpdatedHomeworkFileResponse> UpdateAsync(UpdateHomeworkFileRequest updateHomeworkFileRequest);
}
