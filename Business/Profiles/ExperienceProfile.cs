using AutoMapper;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Experience;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ExperienceProfile : Profile
{
    public ExperienceProfile()
    {
        CreateMap<Experience, CreateExperienceRequest>().ReverseMap();
        CreateMap<Experience, CreatedExperienceResponse>().ReverseMap();

        CreateMap<Experience, UpdateExperienceRequest>().ReverseMap()
            .ForMember(destinationMember: e => e.UserId, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<Experience, UpdatedExperienceResponse>().ReverseMap();

        CreateMap<Experience, DeleteExperienceRequest>().ReverseMap();
        CreateMap<Experience, DeletedExperienceResponse>().ReverseMap();

        CreateMap<IPaginate<Experience>, Paginate<GetListExperienceResponse>>();
        CreateMap<Experience, GetListExperienceResponse>();

        CreateMap<Experience, GetExperienceResponse>().ReverseMap();

    }
}
