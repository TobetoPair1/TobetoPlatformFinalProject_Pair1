using AutoMapper;
using Business.Dtos.Requests.Favourite;
using Business.Dtos.Responses.Favourite;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class FavouriteProfile : Profile
{
    public FavouriteProfile()
    {
        CreateMap<Favourite, CreateFavouriteRequest>().ReverseMap();
        CreateMap<Favourite, CreatedFavouritetResponse>().ReverseMap();

        CreateMap<Favourite, DeleteFavouriteRequest>().ReverseMap();
        CreateMap<Favourite, DeletedFavouriteResponse>().ReverseMap();

        CreateMap<Favourite, GetFavouriteResponse>()
            .ForMember(destinationMember: gf => gf.CourseName, memberOptions: opt => opt.MapFrom(f => f.Course.Name))
            .ReverseMap();

        CreateMap<Paginate<Favourite>, Paginate<GetListFavouriteResponse>>().ReverseMap();
        CreateMap<Favourite, GetListFavouriteResponse>()
            .ForMember(destinationMember: gf => gf.CourseName, memberOptions: opt => opt.MapFrom(f => f.Course.Name))
            .ReverseMap();

        CreateMap<Favourite, UpdateFavouriteRequest>().ReverseMap()
            .ForMember(destinationMember: f => f.CourseId, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<Favourite, UpdatedFavouriteResponse>().ReverseMap();
    }
}