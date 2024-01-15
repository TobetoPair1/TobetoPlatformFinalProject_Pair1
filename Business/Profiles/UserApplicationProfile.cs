using AutoMapper;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.UserApplication;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTable;

namespace Business.Profiles
{
    public class UserApplicationProfile:Profile
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
        }
    }
}
