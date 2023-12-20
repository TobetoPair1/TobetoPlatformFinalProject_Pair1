using AutoMapper;
using Business.Dtos.Requests.SocialMedia;
using Business.Dtos.Responses.SocialMedia;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SocialMediaProfile : Profile
{
    public SocialMediaProfile()
    {
        CreateMap<SocialMedia, CreateSocialMediaRequest>().ReverseMap();
        CreateMap<SocialMedia, CreatedSocialMediaResponse>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaRequest>().ReverseMap();
        CreateMap<SocialMedia, UpdatedSocialMediaResponse>().ReverseMap();

        CreateMap<SocialMedia, DeleteSocialMediaRequest>().ReverseMap();
        CreateMap<SocialMedia, DeletedSocialMediaResponse>().ReverseMap();
        CreateMap<IPaginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>();
        CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaResponse>().ReverseMap();
    }
}
