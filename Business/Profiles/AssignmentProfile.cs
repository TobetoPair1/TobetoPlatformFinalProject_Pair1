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
            .ReverseMap();

        CreateMap<DeleteAssigmentRequest, Assignment>().ReverseMap();
        CreateMap<Assignment, DeletedAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ReverseMap();

        CreateMap<Assignment, GetAssigmentResponse>()

			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ReverseMap();

        CreateMap<Assignment,UpdateAssigmentRequest>()
            .ReverseMap()
			.ForMember(destinationMember: a => a.CourseId, memberOptions: opt => opt.Condition(uar=>uar.CourseId!=null))
			;
		CreateMap<Assignment, UpdatedAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ReverseMap();

        CreateMap<Paginate<Assignment>, Paginate<GetListAssigmentResponse>>().ReverseMap();
        CreateMap<Assignment, GetListAssigmentResponse>()
			.ForMember(destinationMember: ca => ca.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
			.ReverseMap();

    }
}

