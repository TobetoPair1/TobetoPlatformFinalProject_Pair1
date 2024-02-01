using AutoMapper;
using Business.Dtos.Requests.Like;
using Business.Dtos.Responses.Like;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class LikeProfile : Profile
{
    public LikeProfile()
    {
        CreateMap<Like, CreateLikeRequest>().ReverseMap();
        CreateMap<Like, CreatedLikeResponse>().ReverseMap();

        CreateMap<Like, UpdateLikeRequest>().ReverseMap()
            .ForMember(destinationMember: l => l.Id, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<Like, UpdatedLikeResponse>().ReverseMap();

        CreateMap<Like, DeleteLikeRequest>().ReverseMap();
        CreateMap<Like, DeletedLikeResponse>().ReverseMap();

        CreateMap<IPaginate<Like>, Paginate<GetListLikeResponse>>();
        CreateMap<Like, GetListLikeResponse>().ReverseMap();

        CreateMap<Like, GetLikeRequest>().ReverseMap();
        CreateMap<Like, GetLikeResponse>().ReverseMap();
    }
}



