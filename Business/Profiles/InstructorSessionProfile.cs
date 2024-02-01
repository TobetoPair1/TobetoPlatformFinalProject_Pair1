using AutoMapper;
using Business.Dtos.Requests.InstructorSession;
using Business.Dtos.Responses.Instructor;
using Business.Dtos.Responses.InstructorSession;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.Concretes.CrossTables;

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
		CreateMap<Instructor, UpdateInstructorSessionRequest>().ReverseMap();
		CreateMap<Instructor, UpdatedInstructorSessionResponse>().ReverseMap();

		CreateMap<Paginate<Instructor>, Paginate<GetListInstructorResponse>>();
		CreateMap<Instructor, GetListInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();

		CreateMap<Instructor, GetInstructorSessionRequest>().ReverseMap();
        CreateMap<Instructor, GetInstructorSessionResponse>()
			.ForMember(destinationMember: i => i.InstructorFullName, memberOptions: opt => opt.MapFrom(cisr => cisr.FullName))
			.ReverseMap();

        CreateMap<InstructorSession, GetListSessionResponse>()
           .IncludeMembers(ins => ins.Session)
           .ForMember(destinationMember: lsr => lsr.Id, memberOptions: opt => opt.MapFrom(s => s.SessionId))
           .ReverseMap();

        CreateMap<Paginate<InstructorSession>, Paginate<GetListSessionResponse>>().ReverseMap();

    }
}
