using AutoMapper;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserCourseProfile : Profile
{
    public UserCourseProfile()
    {
        CreateMap<UserCourse, CreateUserCourseRequest>().ReverseMap();
        CreateMap<UserCourse, CreatedUserCourseResponse>().ReverseMap();

        CreateMap<UserCourse, DeleteUserCourseRequest>().ReverseMap();
        CreateMap<UserCourse, DeletedUserCourseResponse>().ReverseMap();

        CreateMap<Paginate<UserCourse>, Paginate<GetListUserCourseResponse>>().ReverseMap();

        CreateMap<UserCourse, GetListUserCourseResponse>()
            .ForMember(
            destinationMember: gluc => gluc.CourseName,
            memberOptions: opt => opt.MapFrom(uc => uc.Course.Name)
            )
            .ReverseMap();

        CreateMap<UserCourse, GetUserCourseRequest>().ReverseMap();
        CreateMap<UserCourse, GetUserCourseResponse>()
            .ForMember(
            destinationMember: guc => guc.CourseName,
            memberOptions: opt => opt.MapFrom(uc => uc.Course.Name)
            )
            .ReverseMap();

		CreateMap<UserCourse, GetListCourseResponse>()
			.IncludeMembers(uc=>uc.Course)
			.ForMember(destinationMember: lcr => lcr.Id, memberOptions: opt => opt.MapFrom(c => c.CourseId))
			.ReverseMap();

		CreateMap<Paginate<UserCourse>, Paginate<GetListCourseResponse>>().ReverseMap();
	}
}