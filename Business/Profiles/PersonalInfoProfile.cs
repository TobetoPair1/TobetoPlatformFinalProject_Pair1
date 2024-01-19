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
            .ForMember(destinationMember:p=>p.UserId,memberOptions:opt=>opt.UseDestinationValue());
        CreateMap<PersonalInfo, UpdatedPersonalInfoResponse>().ReverseMap();

        CreateMap<PersonalInfo, DeletePersonalInfoRequest>().ReverseMap();
        CreateMap<PersonalInfo, DeletedPersonalInfoResponse>().ReverseMap();

        CreateMap<PersonalInfo, GetPersonalInfoRequest>().ReverseMap();
        CreateMap<GetPersonalInfoResponse, PersonalInfo>().ReverseMap();


        CreateMap<IPaginate<PersonalInfo>, Paginate<GetListPersonalInfoResponse>>();

        CreateMap<PersonalInfo, GetListPersonalInfoResponse>()
            .ForMember(destinationMember: pi => pi.Name, memberOptions: opt => opt.MapFrom(pi => pi.User.FirstName))
            .ForMember(destinationMember: pi => pi.LastName, memberOptions: opt => opt.MapFrom(pi => pi.User.LastName))
            .ForMember(destinationMember: pi => pi.Email, memberOptions: opt => opt.MapFrom(pi => pi.User.Email))
            .ReverseMap();

        CreateMap<PersonalInfo, GetListPersonalInfoResponse>().ReverseMap();


    }
}
