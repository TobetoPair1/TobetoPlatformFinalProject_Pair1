using AutoMapper;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.Survey;
using Business.Dtos.Responses.UserSurvey;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserSurveyProfile : Profile
{
    public UserSurveyProfile()
    {
        CreateMap<UserSurvey, CreateUserSurveyRequest>().ReverseMap();
        CreateMap<UserSurvey, CreatedUserSurveyResponse>().ReverseMap();

        CreateMap<UserSurvey, DeleteUserSurveyRequest>().ReverseMap();
        CreateMap<UserSurvey, DeletedUserSurveyResponse>().ReverseMap();

        CreateMap<Paginate<UserSurvey>, Paginate<GetListUserSurveyResponse>>().ReverseMap();

        CreateMap<UserSurvey, GetListUserSurveyResponse>()
            .ForMember(
            destinationMember: glus => glus.SurveyTitle,
            memberOptions: opt => opt.MapFrom(us => us.Survey.Title)
            )
            .ReverseMap();

        CreateMap<UserSurvey, GetUserSurveyRequest>().ReverseMap();
        CreateMap<UserSurvey, GetUserSurveyResponse>()
            .ForMember(
            destinationMember: gus => gus.SurveyTitle,
            memberOptions: opt => opt.MapFrom(us => us.Survey.Title)
            )
            .ReverseMap();

        CreateMap<UserSurvey, GetListSurveyResponse>()
            .IncludeMembers(us => us.Survey)
            .ForMember(destinationMember: lsr => lsr.Id, memberOptions: opt => opt.MapFrom(s => s.Survey.Id))
            .ReverseMap();

        CreateMap<Paginate<UserSurvey>, Paginate<GetListSurveyResponse>>().ReverseMap();
    }
}