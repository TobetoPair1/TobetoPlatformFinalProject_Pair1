using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.SocialMedia;
using Business.Dtos.Responses.SocialMedia;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

namespace Business.Concretes;

public class SocialMediaManager: ISocialMediaService
{
    IMapper _mapper;
    ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(IMapper mapper, ISocialMediaDal socialMediaDal)
    {
        _mapper = mapper;
        _socialMediaDal = socialMediaDal;
    }
    
    public Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest)
    {
        throw new NotImplementedException();
    }

    public Task<IPaginate<GetListSocialMediaResponse>> GetListAsync(PageRequest pageRequest)
    {
        throw new NotImplementedException();
    }

    public Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest)
    {
        throw new NotImplementedException();
    }

    public Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest)
    {
        throw new NotImplementedException();
    }

    public Task<GetSocialMediaResponse> GetByIdAsync(GetSocialMediaRequest getSocialMediaRequest)
    {
        throw new NotImplementedException();
    }
}