using AutoMapper;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.UserCourse;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTable;

namespace Business.Profiles
{
	public class UserCourseProfile:Profile
    {
        public UserCourseProfile()
        {
			CreateMap<UserCourse, CreateUserCourseRequest>().ReverseMap();
			CreateMap<UserCourse, CreatedUserCourseResponse>().ReverseMap();

			CreateMap<UserCourse, DeleteUserCourseRequest>().ReverseMap();
			CreateMap<UserCourse, DeletedUserCourseResponse>().ReverseMap();

			CreateMap<IPaginate<UserCourse>, Paginate<GetListUserCourseResponse>>().ReverseMap();
			CreateMap<UserCourse, GetListUserCourseResponse>()
				.ForMember(
				destinationMember: gluc => gluc.CourseName,
				memberOptions: opt => opt.MapFrom(uc => uc.Course.Name)
				)
				.ReverseMap();

			CreateMap<UserCourse, GetUserCourseRequest>().ReverseMap();
			CreateMap<UserCourse, GetUserCourseResponse>().ForMember(
				destinationMember: guc => guc.CourseName,
				memberOptions: opt => opt.MapFrom(uc => uc.Course.Name)
				)
				.ReverseMap();
		}
    }
}
