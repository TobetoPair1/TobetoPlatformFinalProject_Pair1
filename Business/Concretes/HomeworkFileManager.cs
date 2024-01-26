using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.HomeworkFile;
using Business.Dtos.Responses.File;
using Business.Dtos.Responses.HomeworkFile;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class HomeworkFileManager : IHomeworFileService
{
    IHomeworkFileDal _homeworkFileDal;
    IMapper _mapper;

    public HomeworkFileManager(IHomeworkFileDal homeworkFileDal, IMapper mapper)
    {
        _homeworkFileDal = homeworkFileDal;
        _mapper = mapper;
    }

    public async Task<CreatedHomeworkFileResponse> AddAsync(CreateHomeworkFileRequest createHomeworkFileRequest)
    {
        HomeworkFile homeworkFile = _mapper.Map<HomeworkFile>(createHomeworkFileRequest);
        HomeworkFile addedHomeworkFile = await _homeworkFileDal.AddAsync(homeworkFile);
        return _mapper.Map<CreatedHomeworkFileResponse>(addedHomeworkFile);
    }

    public async Task<DeletedHomeworkFileResponse> DeleteAsync(DeleteHomeworkFileRequest deleteHomeworkFileRequest)
    {
        HomeworkFile homeworkFile = _mapper.Map<HomeworkFile>(deleteHomeworkFileRequest);
        HomeworkFile deletedHomeworkFile = await _homeworkFileDal.DeleteAsync(homeworkFile);
        return _mapper.Map<DeletedHomeworkFileResponse>(deletedHomeworkFile);
    }

    public async Task<IPaginate<GetListHomeworkFileResponse>> GetListAsync(PageRequest pageRequest)
    {
        var homeworkFiles = await _homeworkFileDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListHomeworkFileResponse>>(homeworkFiles);
    }

	public async Task<IPaginate<GetListFileResponse>> GetListByHomeworkIdAsync(Guid homeworkId, PageRequest pageRequest)
	{
		var homeworkFile = await _homeworkFileDal.GetListAsync(hm => hm.HomeworkId == homeworkId, include: hm => hm.Include(hm => hm.File), index: pageRequest.PageIndex, size: pageRequest.PageSize);
		var files = _mapper.Map<Paginate<GetListFileResponse>>(homeworkFile);
		return files;
	}

	public async Task<UpdatedHomeworkFileResponse> UpdateAsync(UpdateHomeworkFileRequest updateHomeworkFileRequest)
    {
        HomeworkFile homeworkFile = _mapper.Map<HomeworkFile>(updateHomeworkFileRequest);
        HomeworkFile updatedHomeworkFile = await _homeworkFileDal.UpdateAsync(homeworkFile);
        return _mapper.Map<UpdatedHomeworkFileResponse>(updatedHomeworkFile);
    }
}
