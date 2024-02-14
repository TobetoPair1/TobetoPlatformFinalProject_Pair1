using Business.Dtos.Requests.SocialMedia;
using Business.Dtos.Responses.SocialMedia;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ISocialMediaService
{
    Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest);
    Task<IPaginate<GetListSocialMediaResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest);
    Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest);
    Task<GetSocialMediaResponse> GetByIdAsync(GetSocialMediaRequest getSocialMediaRequest);
    Task<IPaginate<GetListSocialMediaResponse>> GetListByUserIdAsync(PageRequest pageRequest, Guid userId);


}