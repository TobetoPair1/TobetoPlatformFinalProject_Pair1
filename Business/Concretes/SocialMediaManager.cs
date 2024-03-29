using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SocialMedia;
using Business.Dtos.Responses.SocialMedia;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SocialMediaManager: ISocialMediaService
{
    IMapper _mapper;
    ISocialMediaDal _socialMediaDal;
    SocialMediaBusinessRules _socialMediaBusinessRules;

    public SocialMediaManager(IMapper mapper, ISocialMediaDal socialMediaDal, SocialMediaBusinessRules socialMediaBusinessRules) 
    {
        _mapper = mapper;
        _socialMediaDal = socialMediaDal;
        _socialMediaBusinessRules = socialMediaBusinessRules;
    }

    [SecuredOperation("admin")]
    public async Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest)
    {
        await _socialMediaBusinessRules.MaxCountAsync(createSocialMediaRequest.UserId);
        SocialMedia socialMedia = _mapper.Map<SocialMedia>(createSocialMediaRequest);
        var createdSocialMedia = await _socialMediaDal.AddAsync(socialMedia);
        CreatedSocialMediaResponse createdSocialMediaResponse = _mapper.Map<CreatedSocialMediaResponse>(createdSocialMedia);
        return createdSocialMediaResponse;
    }

    [SecuredOperation("admin")]

    public async Task<IPaginate<GetListSocialMediaResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _socialMediaDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSocialMediaResponse>>(result);
    }

    [SecuredOperation("admin")]
    public async Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest)
    {
        SocialMedia socialMedia = await _socialMediaBusinessRules.CheckIfExistsById(deleteSocialMediaRequest.Id);
        var deletedSocialMedia = await _socialMediaDal.DeleteAsync(socialMedia);
        DeletedSocialMediaResponse deletedSocialMediaResponse = _mapper.Map<DeletedSocialMediaResponse>(deletedSocialMedia);
        return deletedSocialMediaResponse;
    }

    public async Task<IPaginate<GetListSocialMediaResponse>> GetListByUserIdAsync(PageRequest pageRequest, Guid userId)
    {
        var result = await _socialMediaDal.GetListAsync(fl => fl.UserId == userId, index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSocialMediaResponse>>(result);
    }

    [SecuredOperation("admin")]
    public async Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        await _socialMediaBusinessRules.CheckUserIfExists(updateSocialMediaRequest.UserId);
        SocialMedia socialMedia = await _socialMediaBusinessRules.CheckIfExistsById(id: updateSocialMediaRequest.Id);
        _mapper.Map(updateSocialMediaRequest, socialMedia);
        var updatedSocialMedia = await _socialMediaDal.UpdateAsync(socialMedia);
        UpdatedSocialMediaResponse updatedSocialMediaResponse = _mapper.Map<UpdatedSocialMediaResponse>(updatedSocialMedia);
        return updatedSocialMediaResponse;
    }


    public async Task<GetSocialMediaResponse> GetByIdAsync(GetSocialMediaRequest getSocialMediaRequest)
    {
        var result = await _socialMediaDal.GetAsync(sm => sm.Id == getSocialMediaRequest.Id);
        return _mapper.Map<GetSocialMediaResponse>(result);
    }

}