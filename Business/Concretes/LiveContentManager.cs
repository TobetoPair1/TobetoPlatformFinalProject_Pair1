using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.LiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class LiveContentManager : ILiveContentService
    {
        IMapper _mapper;
        ILiveContentDal _liveContentDal;

        public LiveContentManager(IMapper mapper, ILiveContentDal liveContentDal)
        {
            _mapper = mapper;
            _liveContentDal = liveContentDal;
        }

        public async Task<CreatedLiveContentResponse> AddAsync(CreateLiveContentRequest createLiveContentRequest)
        {
            LiveContent liveContent = _mapper.Map<LiveContent>(createLiveContentRequest);
            var createdLiveContent = await _liveContentDal.AddAsync(liveContent);
            CreatedLiveContentResponse result = _mapper.Map<CreatedLiveContentResponse>(liveContent);
            return result;
        }

        public async Task<DeletedLiveContentResponse> DeleteAsync(DeleteLiveContentRequest deleteLiveContentRequest)
        {
            LiveContent liveContent = await _liveContentDal.GetAsync(l => l.Id == deleteLiveContentRequest.Id);
            var deletedLiveContent = await _liveContentDal.DeleteAsync(liveContent);
            DeletedLiveContentResponse result = _mapper.Map<DeletedLiveContentResponse>(deletedLiveContent);
            return result;
        }

        public async Task<GetLiveContentResponse> GetByIdAsync(GetLiveContentRequest getLiveContentRequest)
        {
            var result = await _liveContentDal.GetAsync(l => l.Id == getLiveContentRequest.Id);
            return _mapper.Map<GetLiveContentResponse>(result);
        }

        public async Task<IPaginate<GetListLiveContentResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _liveContentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListLiveContentResponse>>(result);
        }

        public async Task<UpdatedLiveContentResponse> UpdateAsync(UpdateLiveContentRequest updateLiveContentRequest)
        {
            LiveContent liveContent = _mapper.Map<LiveContent>(updateLiveContentRequest);
            var updatedLiveContent = await _liveContentDal.UpdateAsync(liveContent);
            UpdatedLiveContentResponse updatedLiveContentResponse = _mapper.Map<UpdatedLiveContentResponse>(updatedLiveContent);
            return updatedLiveContentResponse;
        }
    }
}
