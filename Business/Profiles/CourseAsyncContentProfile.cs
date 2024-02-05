using AutoMapper;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;
public class CourseAsyncContentProfile : Profile
{
    public CourseAsyncContentProfile()
    {
        CreateMap<CourseAsyncContent,CreateCourseAsyncContentRequest>().ReverseMap();
        CreateMap<CourseAsyncContent, CreatedCourseAsyncContentResponse>().ReverseMap();

        CreateMap<CourseAsyncContent,DeleteCourseAsyncContentRequest>().ReverseMap();
        CreateMap<CourseAsyncContent, DeletedCourseAsyncContentResponse>().ReverseMap();

        CreateMap<CourseAsyncContent, GetCourseAyncContentResponse>().ReverseMap();

		CreateMap<CourseAsyncContent, GetListCourseAsyncContentResponse>().ReverseMap();
		CreateMap<Paginate<CourseAsyncContent>, Paginate<GetListCourseAsyncContentResponse>>().ReverseMap();

        CreateMap<CourseAsyncContent,UpdateCourseAsyncContentRequest>().ReverseMap();
        CreateMap<CourseAsyncContent, UpdatedCourseAsyncContentResponse>().ReverseMap();

		CreateMap<CourseAsyncContent, GetListAsyncContentResponse>()
            .IncludeMembers(ca=>ca.AsyncContent)
            .ForMember(destinationMember:glacr=>glacr.Id,memberOptions:opt=>opt.MapFrom(ca => ca.AsyncContentId))
            .ReverseMap();
		CreateMap<Paginate<CourseAsyncContent>, Paginate<GetListAsyncContentResponse>>().ReverseMap();

	}
}