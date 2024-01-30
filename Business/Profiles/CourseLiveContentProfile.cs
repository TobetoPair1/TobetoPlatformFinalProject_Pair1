using AutoMapper;
using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.CourseLiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class CourseLiveContentProfile : Profile
{
    public CourseLiveContentProfile()
    {
        CreateMap<CourseLiveContent, CreateCourseLiveContentRequest>().ReverseMap();
        CreateMap<CourseLiveContent, CreatedCourseLiveContentResponse>().ReverseMap();

        CreateMap<CourseLiveContent, UpdateCourseLiveContentRequest>().ReverseMap();
        CreateMap<CourseLiveContent, UpdatedCourseLiveContentResponse>().ReverseMap();

        CreateMap<CourseLiveContent, DeleteCourseLiveContentRequest>().ReverseMap();
        CreateMap<CourseLiveContent, DeletedCourseLiveContentResponse>().ReverseMap();

        CreateMap<CourseLiveContent, GetCourseLiveContentResponse>().ReverseMap();

        CreateMap<CourseLiveContent, GetListCourseLiveContentResponse>().ReverseMap();
        CreateMap<Paginate<CourseLiveContent>, Paginate<GetListCourseLiveContentResponse>>().ReverseMap();



        CreateMap<Paginate<CourseLiveContent>, Paginate<GetListLiveContentResponse>>().ReverseMap();

        CreateMap<CourseLiveContent, GetListLiveContentResponse>()
            .IncludeMembers(clc=>clc.LiveContent)
            .ForMember(destinationMember: lcr=>lcr.Id, memberOptions: opt=>opt.MapFrom(clc=>clc.LiveContentId))
            .ReverseMap();

    }
}
