using AutoMapper;
using Business.Dtos.Requests.AsyncContent;
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
        CreateMap<CreateAsyncContentRequest, CourseAsyncContent>().ReverseMap();
        CreateMap<CourseAsyncContent, CreatedAsyncContentResponse>().ReverseMap();

        CreateMap<DeleteCourseAsyncContentRequest, CourseAsyncContent>().ReverseMap();
        CreateMap<CourseAsyncContent, DeletedCourseAsyncContentResponse>().ReverseMap();

        CreateMap<CourseAsyncContent, GetCourseAyncContentResponse>().ReverseMap();

        CreateMap<Paginate<CourseAsyncContent>, Paginate<GetListCourseAsyncContentResponse>>().ReverseMap();

        CreateMap<UpdateCourseAsyncContentRequest, CourseAsyncContent>().ReverseMap();
        CreateMap<CourseAsyncContent, UpdatedCourseAsyncContentResponse>().ReverseMap();
    }
}

