using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.AsyncContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AsyncContentManager : IAsyncContentService
{
    IMapper _mapper;
    IAsyncContentDal _asyncContentDal;
    public AsyncContentManager(IMapper mapper, IAsyncContentDal asyncContentDal)
    {
        _asyncContentDal = asyncContentDal;
        _mapper = mapper;
    }
    public async Task<CreatedAsyncContentResponse> AddAsync(CreateAsyncContentRequest createAsyncContentRequest)
    {
        AsyncContent asyncContent = _mapper.Map<AsyncContent>(createAsyncContentRequest);
        var createdAsyncContent = await _asyncContentDal.AddAsync(asyncContent);
        CreatedAsyncContentResponse result = _mapper.Map<CreatedAsyncContentResponse>(asyncContent);
        return result;
    }

    public async Task<DeletedAsyncContentResponse> DeleteAsync(DeleteAsyncContentRequest deleteAsyncContentRequest)
    {
        AsyncContent asyncContent = await _asyncContentDal.GetAsync(a => a.Id == deleteAsyncContentRequest.Id);
        var deletedAsyncContent = await _asyncContentDal.DeleteAsync(asyncContent);
        DeletedAsyncContentResponse result = _mapper.Map<DeletedAsyncContentResponse>(deletedAsyncContent);
        return result;
    }

    public async Task<GetAsyncContentResponse> GetByIdAsync(GetAsyncContentRequest getAsyncContentRequest)
    {
        var result = await _asyncContentDal.GetAsync(a => a.Id == getAsyncContentRequest.Id);
        return _mapper.Map<GetAsyncContentResponse>(result);
    }

    public async Task<IPaginate<GetListAsyncContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _asyncContentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListAsyncContentResponse>>(result);
    }

    public async Task<UpdatedAsyncContentResponse> UpdateAsync(UpdateAsyncContentRequest updateAsyncContentRequest)
    {
        AsyncContent asyncContent = _mapper.Map<AsyncContent>(updateAsyncContentRequest);
        var updatedAsyncContent = await _asyncContentDal.UpdateAsync(asyncContent);
        UpdatedAsyncContentResponse updatedAsyncContentResponse = _mapper.Map<UpdatedAsyncContentResponse>(updatedAsyncContent);
        return updatedAsyncContentResponse;
    }
}