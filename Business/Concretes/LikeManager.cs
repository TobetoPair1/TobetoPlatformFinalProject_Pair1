using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Like;
using Business.Dtos.Responses.Like;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LikeManager : ILikeService
{
    ILikeDal _likeDal;
    IMapper _mapper;
   

    public LikeManager(ILikeDal likeDal, IMapper mapper)
    {
        _likeDal = likeDal;
        _mapper = mapper;
    }


    public async Task<CreatedLikeResponse> AddAsync(CreateLikeRequest createLikeRequest)
    {
        Like like = _mapper.Map<Like>(createLikeRequest);
        var createdLike = await _likeDal.AddAsync(like);
        CreatedLikeResponse createdLikeResponse = _mapper.Map<CreatedLikeResponse>(createdLike);
        return createdLikeResponse;
    }

    public async Task<DeletedLikeResponse> DeleteAsync(DeleteLikeRequest deleteLikeRequest)
    {
        Like like = await _likeDal.GetAsync(l => l.Id == deleteLikeRequest.Id);
        var deletedLike = await _likeDal.DeleteAsync(like);
        DeletedLikeResponse deletedLikeResponse = _mapper.Map<DeletedLikeResponse>(deletedLike);
        return deletedLikeResponse;
    }

    public async Task<GetLikeResponse> GetByIdAsync(GetLikeRequest getLikeRequest)
    {
        var result = await _likeDal.GetAsync(l => l.Id == getLikeRequest.Id);
        return _mapper.Map<GetLikeResponse>(result);
    }

    public async Task<IPaginate<GetListLikeResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _likeDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListLikeResponse>>(result);
    }

    public async Task<UpdatedLikeResponse> UpdateAsync(UpdateLikeRequest updateLikeRequest)
    {
        Like like = await _likeDal.GetAsync(l => l.Id == updateLikeRequest.Id);
        _mapper.Map(updateLikeRequest, like);
        var updatedLike = await _likeDal.UpdateAsync(like);
        UpdatedLikeResponse updatedLikeResponse = _mapper.Map<UpdatedLikeResponse>(updatedLike);
        return updatedLikeResponse;
    }
}

