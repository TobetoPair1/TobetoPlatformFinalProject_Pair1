using AutoMapper;
using Business.Dtos.Requests.Course;
using Business.Dtos.Responses.Course;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CourseProfile : Profile
{
	public CourseProfile()
	{
		CreateMap<CreateCourseRequest, Course>().ReverseMap();
		CreateMap<Course, CreatedCourseResponse>().ReverseMap();

		CreateMap<DeleteCourseRequest, Course>().ReverseMap();
		CreateMap<Course, DeletedCourseResponse>().ReverseMap();

		CreateMap<Course,UpdateCourseRequest>()
			.ReverseMap()
			.ForMember(destinationMember: c => c.CategoryId, memberOptions: opt => opt.Condition(cr => cr.CategoryId!=null))
			.ForMember(destinationMember: cr => cr.LikeId, memberOptions: opt => opt.UseDestinationValue())
			;
		CreateMap<Course, UpdatedCourseResponse>().ReverseMap();

		CreateMap<GetCourseResponse, Course>().ReverseMap();
		CreateMap<GetCourseRequest, Course>().ReverseMap();

		CreateMap<Course, GetCourseResponse>()
			.ForMember(destinationMember: cr => cr.CategoryName, memberOptions: opt => opt.MapFrom(c => c.Category.Name))
			.ForMember(destinationMember: cr => cr.LikeCount, memberOptions: opt => opt.MapFrom(c => c.Like.Count))
			.ReverseMap();

		CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();

		CreateMap<Course, GetListCourseResponse>()
			.ForMember(destinationMember: lcr => lcr.CategoryName, memberOptions: c => c.MapFrom(c => c.Category.Name))
			.ForMember(destinationMember: lcr => lcr.LikeCount, memberOptions: c => c.MapFrom(c => c.Like.Count))
			.ReverseMap();
	}
}
