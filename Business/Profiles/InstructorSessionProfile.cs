using AutoMapper;
using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Responses.Instructor;
using Business.Dtos.Responses.InstructorSession;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class InstructorSessionProfile : Profile
{
	public InstructorSessionProfile()
	{
		CreateMap<Instructor, CreateInstructorSessionRequest>().ReverseMap();
		CreateMap<Instructor, CreatedInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();

		CreateMap<Instructor, DeleteInstructorSessionRequest>().ReverseMap();
		CreateMap<Instructor, DeletedInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();

		CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>();
		CreateMap<Instructor, GetListInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();

		CreateMap<Instructor, GetInstructorSessionRequest>().ReverseMap();
        CreateMap<Instructor, GetInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();
	}
}
