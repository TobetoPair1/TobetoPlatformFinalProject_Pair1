using AutoMapper;
using Business.Dtos.Requests.CourseFavouritedByUser;
using Business.Dtos.Responses.CourseFavouriteByUser;
using Core.DataAccess.Paging;

namespace Business.Profiles;

public class CourseFavouriteByUserProfile : Profile
{
    public CourseFavouriteByUserProfile()
    {
        CreateMap<CourseFavouriteByUserProfile, CreateFavouriteByUserRequest>().ReverseMap();
        CreateMap<CourseFavouriteByUserProfile, CreatedCourseFavouriteByUserResponse>().ReverseMap();

        CreateMap<CourseFavouriteByUserProfile, DeleteFavouriteByUserRequest>().ReverseMap();
        CreateMap<CourseFavouriteByUserProfile, DeletedCourseFavouriteByUserResponse>().ReverseMap();

        CreateMap<CourseFavouriteByUserProfile, GetFavouriteByUserRequest>().ReverseMap();
        CreateMap<CourseFavouriteByUserProfile, GetCourseFavouriteByUserResponse>().ReverseMap();

        CreateMap<CourseFavouriteByUserProfile, GetListCourseFavouriteByUserResponse>().ReverseMap();
        CreateMap<Paginate<CourseFavouriteByUserProfile>, Paginate<GetListCourseFavouriteByUserResponse>>().ReverseMap();
    }
}