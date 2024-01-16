using Business.Dtos.Requests.File;
using Business.Dtos.Responses.File;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IFileService
{
    Task<CreatedFileResponse> AddAsync(CreateFileRequest createFileRequest);
    Task<IPaginate<GetListFileResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedFileResponse> DeleteAsync(DeleteFileRequest deleteFileRequest);
    Task<UpdatedFileResponse> UpdateAsync(UpdateFileRequest updateFileRequest);
    Task<GetFileResponse> GetByIdAsync(GetFileRequest getFileRequest);
}


