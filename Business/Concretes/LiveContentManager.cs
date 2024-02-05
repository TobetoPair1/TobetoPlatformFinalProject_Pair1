using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Requests.File;
using Business.Dtos.Requests.Like;
using Business.Dtos.Requests.LiveContent;
using Business.Dtos.Responses.CourseLiveContent;
using Business.Dtos.Responses.LiveContent;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LiveContentManager : ILiveContentService
{
    IMapper _mapper;
    ILiveContentDal _liveContentDal;
    ICourseLiveContentService _courseLiveContentService;
	ILikeService _likeService;
    LiveContentBusinessRules _liveContentBusinessRules;

    public LiveContentManager(IMapper mapper, ILiveContentDal liveContentDal, ICourseLiveContentService courseLiveContentService, ILikeService likeService, LiveContentBusinessRules liveContentBusinessRules)
    {
        _mapper = mapper;
        _liveContentDal = liveContentDal;
        _courseLiveContentService = courseLiveContentService;
        _likeService = likeService;
        _liveContentBusinessRules = liveContentBusinessRules;
    }

    public async Task<CreatedLiveContentResponse> AddAsync(CreateLiveContentRequest createLiveContentRequest)
    {
        LiveContent liveContent = _mapper.Map<LiveContent>(createLiveContentRequest);
		liveContent.LikeId = (await _likeService.AddAsync(new CreateLikeRequest())).Id;
		var createdLiveContent = await _liveContentDal.AddAsync(liveContent);
        CreatedLiveContentResponse result = _mapper.Map<CreatedLiveContentResponse>(createdLiveContent);
        return result;
    }

    public async Task<CreatedCourseLiveContentResponse> AssignContentAsync(CreateCourseLiveContentRequest createCourseLiveContentRequest)
    {
        return await _courseLiveContentService.AddAsync(createCourseLiveContentRequest);
    }

    public async Task<DeletedLiveContentResponse> DeleteAsync(DeleteLiveContentRequest deleteLiveContentRequest)
    {
        LiveContent liveContent = await _liveContentDal.GetAsync(l => l.Id == deleteLiveContentRequest.Id);
        var deletedLiveContent = await _liveContentDal.DeleteAsync(liveContent);
        DeletedLiveContentResponse result = _mapper.Map<DeletedLiveContentResponse>(deletedLiveContent);
        return result;
    }

    public async Task<GetLiveContentResponse> GetByIdAsync(Guid id)
    {
        var result = await _liveContentDal.GetAsync(l => l.Id == id);
        return _mapper.Map<GetLiveContentResponse>(result);
    }

    public async Task<IPaginate<GetListLiveContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _liveContentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListLiveContentResponse>>(result);
    }

    public async Task<IPaginate<GetListLiveContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest)
    {
        return await _courseLiveContentService.GetListByCourseIdAsync(courseId, pageRequest);
    }

    public async Task<UpdatedLiveContentResponse> UpdateAsync(UpdateLiveContentRequest updateLiveContentRequest)
    {
        LiveContent liveContent = await _liveContentBusinessRules.CheckIfExistsById(updateLiveContentRequest.Id);
        _mapper.Map(updateLiveContentRequest, liveContent);
        var updatedLiveContent = await _liveContentDal.UpdateAsync(liveContent);
        UpdatedLiveContentResponse updatedLiveContentResponse = _mapper.Map<UpdatedLiveContentResponse>(updatedLiveContent);
        return updatedLiveContentResponse;
    }
}
