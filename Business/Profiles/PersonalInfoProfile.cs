using AutoMapper;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Responses.PersonalInfo;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class PersonalInfoProfile : Profile
{
    public PersonalInfoProfile()
    {
        CreateMap<PersonalInfo, CreatePersonalInfoRequest>().ReverseMap();
        CreateMap<PersonalInfo, CreatedPersonalInfoResponse>().ReverseMap();

        CreateMap<PersonalInfo, UpdatePersonalInfoRequest>()
            .ReverseMap()
             .ForPath(destinationMember: p => p.User.FirstName, memberOptions: opt => opt.MapFrom(p => p.FirstName))
             .ForMember(destinationMember: p => p.UserId, memberOptions: opt => opt.UseDestinationValue())
             .ForPath(destinationMember: p => p.User.LastName, memberOptions: opt => opt.MapFrom(p => p.LastName))
             .ForPath(destinationMember: p => p.User.Email, memberOptions: opt => opt.MapFrom(p => p.Email));


        CreateMap<PersonalInfo, UpdatedPersonalInfoResponse>()
            .ForMember(destinationMember: p => p.FirstName, memberOptions: opt => opt.MapFrom(p => p.User.FirstName))
            .ForMember(destinationMember: p => p.LastName, memberOptions: opt => opt.MapFrom(p => p.User.LastName))
            .ForMember(destinationMember: p => p.Email, memberOptions: opt => opt.MapFrom(p => p.User.Email))
            .ReverseMap();

           

        CreateMap<PersonalInfo, DeletePersonalInfoRequest>().ReverseMap();
        CreateMap<PersonalInfo, DeletedPersonalInfoResponse>().ReverseMap();
        CreateMap<UpdatePersonalInfoRequest, User>().ReverseMap();

        CreateMap<PersonalInfo, GetPersonalInfoRequest>().ReverseMap();
        CreateMap<PersonalInfo, GetPersonalInfoResponse>()
            .ForMember(destinationMember: p => p.FirstName, memberOptions: opt => opt.MapFrom(p => p.User.FirstName))
            .ForMember(destinationMember: p => p.LastName, memberOptions: opt => opt.MapFrom(p => p.User.LastName))
            .ForMember(destinationMember: p => p.Email, memberOptions: opt => opt.MapFrom(p => p.User.Email))
            .ReverseMap();


        CreateMap<IPaginate<PersonalInfo>, Paginate<GetListPersonalInfoResponse>>();

        CreateMap<PersonalInfo, GetListPersonalInfoResponse>()
            .ForMember(destinationMember: glpir => glpir.Email, memberOptions: opt => opt.MapFrom(pi => pi.User.Email))
            .ReverseMap();

        CreateMap<PersonalInfo, GetListPersonalInfoResponse>().ReverseMap();
    }
}