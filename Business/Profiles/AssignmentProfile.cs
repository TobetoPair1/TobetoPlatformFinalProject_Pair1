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
            .ForMember(destinationMember: da => da.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
            .ReverseMap();

        CreateMap<Assignment, GetAssigmentResponse>().
            ForMember(destinationMember: ga => ga.CourseName, memberOptions: a => a.MapFrom(a => a.Course.Name))
            .ReverseMap();

        CreateMap<UpdateAssigmentRequest, Assignment>().ReverseMap();
        CreateMap<Assignment, UpdatedAssigmentResponse>()
            .ForMember(destinationMember: ua => ua.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
            .ReverseMap();

        CreateMap<Paginate<Assignment>, Paginate<GetListAssigmentResponse>>().ReverseMap();
        CreateMap<Assignment, GetListAssigmentResponse>()
            .ForMember(destinationMember: ga => ga.CourseName, memberOptions: opt => opt.MapFrom(a => a.Course.Name))
            .ReverseMap();

    }
}

