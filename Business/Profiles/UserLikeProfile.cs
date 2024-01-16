using AutoMapper;
using Business.Dtos.Requests.UserLike;
using Business.Dtos.Responses.UserLike;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserLikeProfile : Profile
{
    public UserLikeProfile()
    {
        CreateMap<UserLike, CreateUserLikeRequest>().ReverseMap();
        CreateMap<UserLike, CreatedUserLikeResponse>().ReverseMap();

        CreateMap<UserLike, DeleteUserLikeRequest>().ReverseMap();
        CreateMap<UserLike, DeletedUserLikeResponse>().ReverseMap();

        CreateMap<UserLike, GetUserLikeRequest>().ReverseMap();
        CreateMap<UserLike, GetUserLikeResponse>().ReverseMap();

        CreateMap<IPaginate<UserLike>, Paginate<GetListUserLikeResponse>>();
        CreateMap<UserLike, GetListUserLikeResponse>()
            .ForMember(dest =>
                dest.LikeId, opt =>
                opt.MapFrom(src => src.Like.Id))
            .ReverseMap();
    }
}


