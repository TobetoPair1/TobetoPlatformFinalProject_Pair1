using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Answer;
using Business.Dtos.Requests.File;
using Business.Dtos.Requests.HomeworkFile;
using Business.Dtos.Responses.File;
using Business.Dtos.Responses.HomeworkFile;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using File = Entities.Concretes.File;

namespace Business.Concretes;

public class FileManager : IFileService
{
    IFileDal _fileDal;
    IHomeworkFileService _homeworkFileService;
    IMapper _mapper;
    FileBusinessRules _fileBusinessRules;

    public FileManager(IFileDal fileDal, IMapper mapper, IHomeworkFileService homeworFileService, FileBusinessRules fileBusinessRules)
    {
        _fileDal = fileDal;
        _mapper = mapper;
        _homeworkFileService = homeworFileService;
        _fileBusinessRules = fileBusinessRules;
    }

    public async Task<CreatedFileResponse> AddAsync(CreateFileRequest createFileRequest)
    {
        File file = _mapper.Map<File>(createFileRequest);
        var createdFile = await _fileDal.AddAsync(file);
        CreatedFileResponse createdFileResponse = _mapper.Map<CreatedFileResponse>(createdFile);
        return createdFileResponse;
    }

	public async Task<CreatedHomeworkFileResponse> AssignHomework(CreateHomeworkFileRequest createHomeworkFileRequest)
	{
        return await _homeworkFileService.AddAsync(createHomeworkFileRequest);
	}

	public async Task<DeletedFileResponse> DeleteAsync(DeleteFileRequest deleteFileRequest)
	{
		File file = await _fileBusinessRules.CheckIfExistsById(deleteFileRequest.Id);
		var deletedFile = await _fileDal.DeleteAsync(file);
		DeletedFileResponse deletedFileResponse = _mapper.Map<DeletedFileResponse>(deletedFile);
		return deletedFileResponse; 
	}

    public async Task<GetFileResponse> GetByIdAsync(GetFileRequest getFileRequest)
    {
        var result = await _fileDal.GetAsync(f => f.Id == getFileRequest.Id);
        return _mapper.Map<GetFileResponse>(result);
    }

    public async Task<IPaginate<GetListFileResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _fileDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListFileResponse>>(result);
    }

	public async Task<IPaginate<GetListFileResponse>> GetListByHomeworkIdAsync(Guid homeworkId, PageRequest pageRequest)
	{
        return await _homeworkFileService.GetListByHomeworkIdAsync(homeworkId,pageRequest);
	}

	public async Task<UpdatedFileResponse> UpdateAsync(UpdateFileRequest updateFileRequest)
	{
        await _fileBusinessRules.CheckUserIfExists(updateFileRequest._UserId);
        await _fileBusinessRules.CheckAssignmentIfExists(updateFileRequest.AssignmentId);
        File file = await _fileBusinessRules.CheckIfExistsById(updateFileRequest.Id);
		var updatedFile = await _fileDal.UpdateAsync(file);
		UpdatedFileResponse updatedFileResponse = _mapper.Map<UpdatedFileResponse>(updatedFile);
		return updatedFileResponse; 
	}
}