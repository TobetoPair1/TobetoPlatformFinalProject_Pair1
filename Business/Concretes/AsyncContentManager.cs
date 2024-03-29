using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Requests.Like;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AsyncContentManager : IAsyncContentService
{
    IMapper _mapper;
    IAsyncContentDal _asyncContentDal;
    ICourseAsyncContentService _courseAsyncContentService;
	ILikeService _likeService;
    AsyncContentBusinessRules _asyncContentBusinessRules;
    public AsyncContentManager(IMapper mapper, IAsyncContentDal asyncContentDal, ICourseAsyncContentService courseAsyncContentService, ILikeService likeService, AsyncContentBusinessRules asyncContentBusinessRules)
    {
        _asyncContentDal = asyncContentDal;
        _mapper = mapper;
        _courseAsyncContentService = courseAsyncContentService;
        _likeService = likeService;
        _asyncContentBusinessRules = asyncContentBusinessRules;
    }
	[SecuredOperation("admin")]
	public async Task<CreatedAsyncContentResponse> AddAsync(CreateAsyncContentRequest createAsyncContentRequest)
    {
        AsyncContent asyncContent = _mapper.Map<AsyncContent>(createAsyncContentRequest);
		asyncContent.LikeId = (await _likeService.AddAsync(new CreateLikeRequest())).Id;
		var createdAsyncContent = await _asyncContentDal.AddAsync(asyncContent);
        CreatedAsyncContentResponse result = _mapper.Map<CreatedAsyncContentResponse>(createdAsyncContent);
        return result;
    }
	[SecuredOperation("admin")]
	public async Task<CreatedCourseAsyncContentResponse> AssignAsyncContentAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest)
	{
        return await _courseAsyncContentService.AddAsync(createCourseAsyncContentRequest);
	}
	[SecuredOperation("admin")]
	public async Task<DeletedAsyncContentResponse> DeleteAsync(DeleteAsyncContentRequest deleteAsyncContentRequest)
    {
        AsyncContent asyncContent = await _asyncContentBusinessRules.CheckIfExistsById(deleteAsyncContentRequest.Id);
        var deletedAsyncContent = await _asyncContentDal.DeleteAsync(asyncContent);
        DeletedAsyncContentResponse result = _mapper.Map<DeletedAsyncContentResponse>(deletedAsyncContent);
        return result;
    }

    public async Task<GetAsyncContentResponse> GetByIdAsync(GetAsyncContentRequest getAsyncContentRequest)
    {
        var result = await _asyncContentDal.GetAsync(a => a.Id == getAsyncContentRequest.Id);
        return _mapper.Map<GetAsyncContentResponse>(result);
    }
	[SecuredOperation("admin")]
	public async Task<IPaginate<GetListAsyncContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _asyncContentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListAsyncContentResponse>>(result);
    }

	public async Task<IPaginate<GetListAsyncContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest)
	{
        return await _courseAsyncContentService.GetListByCourseIdAsync(courseId,pageRequest);
	}
	[SecuredOperation("admin")]
	public async Task<UpdatedAsyncContentResponse> UpdateAsync(UpdateAsyncContentRequest updateAsyncContentRequest)
    {
        await _asyncContentBusinessRules.CheckCategoryIfExists(updateAsyncContentRequest.CategoryId);
        AsyncContent asyncContent = await _asyncContentBusinessRules.CheckIfExistsById(updateAsyncContentRequest.Id);
		_mapper.Map(updateAsyncContentRequest,asyncContent);
        var updatedAsyncContent = await _asyncContentDal.UpdateAsync(asyncContent);
        UpdatedAsyncContentResponse updatedAsyncContentResponse = _mapper.Map<UpdatedAsyncContentResponse>(updatedAsyncContent);
        return updatedAsyncContentResponse;
    }
}