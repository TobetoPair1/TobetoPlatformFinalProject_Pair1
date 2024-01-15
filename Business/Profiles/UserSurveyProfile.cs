using AutoMapper;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.UserSkill;
using Business.Dtos.Responses.UserSurvey;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTable;

namespace Business.Profiles
{
    public class UserSurveyProfile:Profile
    {
        public UserSurveyProfile()
        {
            CreateMap<UserSurvey, CreateUserSurveyRequest>().ReverseMap();
            CreateMap<UserSurvey, CreatedUserSurveyResponse>().ReverseMap();

            CreateMap<UserSurvey, DeleteUserSurveyRequest>().ReverseMap();
            CreateMap<UserSurvey, DeletedUserSurveyResponse>().ReverseMap();

            CreateMap<IPaginate<UserSurvey>, Paginate<GetListUserSurveyResponse>>();
            CreateMap<UserSurvey, GetListUserSurveyResponse>()
                .ForMember(destinationMember: us => us.SurveyTitle, memberOptions: opt => opt.MapFrom(us => us.Survey.Title))
                .ReverseMap();

            CreateMap<UserSurvey, GetUserSkillRequest>().ReverseMap();
            CreateMap<UserSurvey, GetUserSkillResponse>().ReverseMap();
        }
    }
}
