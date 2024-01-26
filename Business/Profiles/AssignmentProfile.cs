using AutoMapper;
using Business.Dtos.Requests.Assignment;
using Business.Dtos.Responses.Assignment;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class AssignmentProfile : Profile
{
    public AssignmentProfile()
    {
        CreateMap<CreateAssigmentRequest, Assignment>().ReverseMap();
        CreateMap<Assignment, CreatedAssigmentResponse>()
            .ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
            .ForMember(destinationMember: ca => ca.CategoryName, memberOptions: opt => opt.MapFrom(a => a.Category.Name))
            .ForMember(destinationMember: ca => ca.LikeCount, memberOptions: opt => opt.MapFrom(a => a.Like.Count))
            .ReverseMap();

        CreateMap<DeleteAssigmentRequest, Assignment>().ReverseMap();
        CreateMap<Assignment, DeletedAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ForMember(destinationMember: ca => ca.CategoryName, memberOptions: opt => opt.MapFrom(a => a.Category.Name))
			.ForMember(destinationMember: ca => ca.LikeCount, memberOptions: opt => opt.MapFrom(a => a.Like.Count))
			.ReverseMap();

        CreateMap<Assignment, GetAssigmentResponse>()

			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ForMember(destinationMember: ca => ca.CategoryName, memberOptions: opt => opt.MapFrom(a => a.Category.Name))
			.ForMember(destinationMember: ca => ca.LikeCount, memberOptions: opt => opt.MapFrom(a => a.Like.Count))
			.ReverseMap();

        CreateMap<UpdateAssigmentRequest, Assignment>().ReverseMap();
        CreateMap<Assignment, UpdatedAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ForMember(destinationMember: ca => ca.CategoryName, memberOptions: opt => opt.MapFrom(a => a.Category.Name))
			.ForMember(destinationMember: ca => ca.LikeCount, memberOptions: opt => opt.MapFrom(a => a.Like.Count))
			.ReverseMap();

        CreateMap<Paginate<Assignment>, Paginate<GetListAssigmentResponse>>().ReverseMap();
        CreateMap<Assignment, GetListAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ForMember(destinationMember: ca => ca.CategoryName, memberOptions: opt => opt.MapFrom(a => a.Category.Name))
			.ForMember(destinationMember: ca => ca.LikeCount, memberOptions: opt => opt.MapFrom(a => a.Like.Count))
			.ReverseMap();

    }
}

