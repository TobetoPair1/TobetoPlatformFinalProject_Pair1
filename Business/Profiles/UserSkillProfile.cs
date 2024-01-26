using AutoMapper;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserSkillProfile : Profile
{
    public UserSkillProfile()
    {
        CreateMap<UserSkill, CreateUserSkillRequest>().ReverseMap();
        CreateMap<UserSkill, CreatedUserSkillResponse>().ReverseMap();

        CreateMap<UserSkill, DeleteUserSkillRequest>().ReverseMap();
        CreateMap<UserSkill, DeletedUserSkillResponse>().ReverseMap();

        CreateMap<IPaginate<UserSkill>, Paginate<GetListUserSkillResponse>>();
        CreateMap<UserSkill, GetListUserSkillResponse>()
            .ForMember(destinationMember: us =>
                us.SkillName, memberOptions: opt =>
                opt.MapFrom(us => us.Skill.Name))
            .ReverseMap();

        CreateMap<UserSkill, GetUserSkillRequest>().ReverseMap();
        CreateMap<UserSkill, GetUserSkillResponse>().ReverseMap();

        CreateMap<IPaginate<UserSkill>, Paginate<GetListSkillResponse>>().ReverseMap();
        CreateMap<UserSkill, GetListSkillResponse>().IncludeMembers(us => us.Skill).ForMember(destinationMember: glsr => glsr.Id, memberOptions: opt => opt.MapFrom(us => us.SkillId)).ReverseMap();
    }
}

