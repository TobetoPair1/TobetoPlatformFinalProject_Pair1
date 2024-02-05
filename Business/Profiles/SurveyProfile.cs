using AutoMapper;
using Business.Dtos.Requests.Survey;
using Business.Dtos.Responses.Survey;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SurveyProfile:Profile
{
    public SurveyProfile()
    {
       CreateMap<Survey, CreateSurveyRequest>().ReverseMap();
       CreateMap<Survey, CreatedSurveyResponse>().ReverseMap();

        CreateMap<Survey, UpdateSurveyRequest>().ReverseMap();
       CreateMap<Survey, UpdatedSurveyResponse>().ReverseMap();

       CreateMap<Survey, DeleteSurveyRequest>().ReverseMap();
       CreateMap<Survey, DeletedSurveyResponse>().ReverseMap();

       CreateMap<IPaginate<Survey>, Paginate<GetListSurveyResponse>>();
       CreateMap<Survey, GetListSurveyResponse>().ReverseMap();

       CreateMap<Survey, GetSurveyRequest>().ReverseMap();
       CreateMap<Survey, GetSurveyResponse>().ReverseMap();
    }
}