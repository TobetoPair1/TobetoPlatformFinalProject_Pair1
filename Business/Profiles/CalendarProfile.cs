using AutoMapper;
using Business.Dtos.Requests.Calendar;
using Business.Dtos.Responses.Calender;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CalendarProfile : Profile
{
    public CalendarProfile()
    {
        CreateMap<Calendar, CreateCalendarRequest>().ReverseMap();
        CreateMap<Calendar, CreatedCalendarResponse>().ReverseMap();

        CreateMap<Calendar, UpdateCalendarRequest>()
            .ReverseMap()
            .ForMember(destinationMember:c=>c.CourseId,memberOptions:opt=>opt.Condition(ucr=>ucr.CourseId!=null))
            .ForMember(destinationMember:c=>c.InstructorId,memberOptions:opt=>opt.Condition(ucr=>ucr.InstructorId!=null))
            ;
        CreateMap<Calendar, UpdatedCalendarResponse>().ReverseMap();

        CreateMap<Calendar, DeleteCalendarRequest>().ReverseMap();
        CreateMap<Calendar, DeletedCalendarResponse>().ReverseMap();

        CreateMap<IPaginate<Calendar>, Paginate<GetListCalendarResponse>>().ReverseMap();
        CreateMap<Calendar, GetListCalendarResponse>().ReverseMap();

        CreateMap<Calendar, GetCalendarResponse>().ReverseMap();
    }
}
