using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.File;
using Business.Dtos.Responses.File;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using File = Entities.Concretes.File;

namespace Business.Concretes;

public class FileManager : IFileService
{
    private readonly IFileDal _fileDal;
    private readonly IMapper _mapper;

    public FileManager(IFileDal fileDal, IMapper mapper)
    {
        _fileDal = fileDal;
        _mapper = mapper;
    }

    public async Task<CreatedFileResponse> AddAsync(CreateFileRequest createFileRequest)
    {
        File file = _mapper.Map<File>(createFileRequest);
        var createdFile = await _fileDal.AddAsync(file);
        CreatedFileResponse createdFileResponse = _mapper.Map<CreatedFileResponse>(createdFile);
        return createdFileResponse;
    }

    public async Task<DeletedFileResponse> DeleteAsync(DeleteFileRequest deleteFileRequest)
    {
        File file = await _fileDal.GetAsync(f => f.Id == deleteFileRequest.FileId);
        var deletedFile = await _fileDal.DeleteAsync(file);
        DeletedFileResponse deletedFileResponse = _mapper.Map<DeletedFileResponse>(deletedFile);
        return deletedFileResponse;
    }

    public async Task<GetFileResponse> GetByIdAsync(GetFileRequest getFileRequest)
    {
        var result = await _fileDal.GetAsync(f => f.Id == getFileRequest.FileId);
        return _mapper.Map<GetFileResponse>(result);
    }

    public async Task<IPaginate<GetListFileResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _fileDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListFileResponse>>(result);
    }

    public async Task<UpdatedFileResponse> UpdateAsync(UpdateFileRequest updateFileRequest)
    {
        File file = _mapper.Map<File>(updateFileRequest);
        var updatedFile = await _fileDal.UpdateAsync(file);
        UpdatedFileResponse updatedFileResponse = _mapper.Map<UpdatedFileResponse>(updatedFile);
        return updatedFileResponse;
    }
}
