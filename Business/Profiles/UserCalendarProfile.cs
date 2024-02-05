using AutoMapper;
using Business.Dtos.Requests.UserCalendar;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserCalendarProfile : Profile
{
    public UserCalendarProfile()
    {
        CreateMap<UserCalendar, CreateUserCalendarRequest>().ReverseMap();
        CreateMap<UserCalendar, CreatedUserCalendarResponse>().ReverseMap();

        CreateMap<UserCalendar, DeleteUserCalendarRequest>().ReverseMap();
        CreateMap<UserCalendar, DeletedUserCalendarResponse>().ReverseMap();

        CreateMap<UserCalendar, UpdateUserCalendarRequest>().ReverseMap();
        CreateMap<UserCalendar, UpdatedUserCalendarResponse>().ReverseMap();

        CreateMap<UserCalendar, GetUserCalendarRequest>().ReverseMap();
        CreateMap<UserCalendar, GetUserCalendarResponse>().ReverseMap();

        CreateMap<IPaginate<UserCalendar>, Paginate<GetListUserCalendarResponse>>();
        CreateMap<UserCalendar, GetListUserCalendarResponse>();
    }
}