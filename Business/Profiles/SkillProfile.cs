using AutoMapper;
using Business.Dtos.Requests.Skill;
using Business.Dtos.Responses.Skill;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SkillProfile : Profile
{
    public SkillProfile()
    {
        CreateMap<Skill, CreateSkillRequest>().ReverseMap();
        CreateMap<Skill, CreatedSkillResponse>().ReverseMap();

        CreateMap<Skill, UpdateSkillRequest>().ReverseMap()
            .ForMember(destinationMember: s => s.Id, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<Skill, UpdatedSkillResponse>().ReverseMap();

        CreateMap<Skill, DeleteSkillRequest>().ReverseMap();
        CreateMap<Skill, DeletedSkillResponse>().ReverseMap();

        CreateMap<IPaginate<Skill>, Paginate<GetListSkillResponse>>();
        CreateMap<Skill, GetListSkillResponse>().ReverseMap();

        CreateMap<Skill, GetSkillRequest>().ReverseMap();
        CreateMap<Skill, GetSkillResponse>().ReverseMap();
    }
}
