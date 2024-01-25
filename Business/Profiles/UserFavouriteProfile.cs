using AutoMapper;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.Favourite;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserFavouriteProfile : Profile
{
    public UserFavouriteProfile()
    {
        CreateMap<UserFavourite, CreateUserFavouriteRequest>().ReverseMap();
        CreateMap<UserFavourite, CreatedUserFavouriteResponse>().ReverseMap();

        CreateMap<UserFavourite, UpdateUserFavouriteRequest>().ReverseMap();
        CreateMap<UserFavourite, UpdatedUserFavouriteResponse>().ReverseMap();

        CreateMap<UserFavourite, DeleteUserFavouriteRequest>().ReverseMap();
        CreateMap<UserFavourite, DeletedUserFavouriteResponse>().ReverseMap();

        CreateMap<IPaginate<UserFavourite>, Paginate<GetListUserFavouriteResponse>>();
        CreateMap<UserFavourite, GetListUserFavouriteResponse>().ReverseMap();

        CreateMap<UserFavourite, GetUserFavouriteResponse>().ReverseMap();

		CreateMap<UserFavourite, GetListFavouriteResponse>()
            .IncludeMembers(uf=>uf.Favourite)
            .ForMember(destinationMember:glfr=>glfr.Id,memberOptions:opt=>opt.MapFrom(uf=>uf.FavouriteId))
            .ReverseMap();

		CreateMap<IPaginate<UserFavourite>, Paginate<GetListFavouriteResponse>>().ReverseMap();

	}
}
