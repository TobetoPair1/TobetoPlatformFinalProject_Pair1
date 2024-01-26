using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AsyncContentManager : IAsyncContentService
{
    IMapper _mapper;
    IAsyncContentDal _asyncContentDal;
    ICourseAsyncContentService _courseAsyncContentService;
	public AsyncContentManager(IMapper mapper, IAsyncContentDal asyncContentDal, ICourseAsyncContentService courseAsyncContentService)
	{
		_asyncContentDal = asyncContentDal;
		_mapper = mapper;
		_courseAsyncContentService = courseAsyncContentService;
	}
	public async Task<CreatedAsyncContentResponse> AddAsync(CreateAsyncContentRequest createAsyncContentRequest)
    {
        AsyncContent asyncContent = _mapper.Map<AsyncContent>(createAsyncContentRequest);
        var createdAsyncContent = await _asyncContentDal.AddAsync(asyncContent);
        CreatedAsyncContentResponse result = _mapper.Map<CreatedAsyncContentResponse>(createdAsyncContent);
        return result;
    }

	public async Task<CreatedCourseAsyncContentResponse> AssignAsyncContentAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest)
	{
        return await _courseAsyncContentService.AddAsync(createCourseAsyncContentRequest);
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

	public async Task<IPaginate<GetListAsyncContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest)
	{
        return await _courseAsyncContentService.GetListByCourseIdAsync(courseId,pageRequest);
	}

	public async Task<UpdatedAsyncContentResponse> UpdateAsync(UpdateAsyncContentRequest updateAsyncContentRequest)
    {
        AsyncContent asyncContent = _mapper.Map<AsyncContent>(updateAsyncContentRequest);
        var updatedAsyncContent = await _asyncContentDal.UpdateAsync(asyncContent);
        UpdatedAsyncContentResponse updatedAsyncContentResponse = _mapper.Map<UpdatedAsyncContentResponse>(updatedAsyncContent);
        return updatedAsyncContentResponse;
    }
}