using AutoMapper;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.UserApplication;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserApplicationProfile : Profile
{
    public UserApplicationProfile()
    {
        CreateMap<UserApplication, CreateUserApplicationRequest>().ReverseMap();
        CreateMap<UserApplication, CreatedUserApplicationResponse>().ReverseMap();

        CreateMap<UserApplication, DeleteUserApplicationRequest>().ReverseMap();
        CreateMap<UserApplication, DeletedUserApplicationResponse>().ReverseMap();

        CreateMap<UserApplication, GetUserApplicationRequest>().ReverseMap();
        CreateMap<UserApplication, GetUserApplicationResponse>().ReverseMap();

        CreateMap<IPaginate<UserApplication>, Paginate<GetListUserApplicationResponse>>();
        CreateMap<UserApplication, GetListUserApplicationResponse>().ForMember(destinationMember: ap => ap.ApplicationTitle, memberOptions: opt => opt.MapFrom(ap => ap.Application.Title)).ReverseMap();

        CreateMap<UserApplication, GetListApplicationResponse>().IncludeMembers(ua=>ua.Application).ForMember(destinationMember: lua => lua.Id, memberOptions: opt => opt.MapFrom(ua => ua.ApplicationId)).ReverseMap();
        CreateMap<Paginate<UserApplication>, Paginate<GetListApplicationResponse>>().ReverseMap();

    }
}
