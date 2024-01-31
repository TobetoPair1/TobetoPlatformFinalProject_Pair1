using AutoMapper;
using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Education;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class EducationProfile : Profile
{
    public EducationProfile()
    {
        CreateMap<Education, CreateEducationRequest>().ReverseMap();
        CreateMap<Education, CreatedEducationResponse>().ReverseMap();

        CreateMap<Education, UpdateEducationRequest>().ReverseMap()
			.ForMember(destinationMember: a => a.UserId, memberOptions: opt => opt.UseDestinationValue());
		CreateMap<Education, UpdatedEducationResponse>().ReverseMap();

        CreateMap<Education, DeleteEducationRequest>().ReverseMap();
        CreateMap<Education, DeletedEducationResponse>().ReverseMap();

        CreateMap<IPaginate<Education>, Paginate<GetListEducationResponse>>();
        CreateMap<Education, GetListEducationResponse>().ReverseMap();

        CreateMap<Education, GetEducationResponse>().ReverseMap();
    }
}
