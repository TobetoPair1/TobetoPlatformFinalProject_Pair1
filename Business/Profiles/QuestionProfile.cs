using AutoMapper;
using Business.Dtos.Requests.Question;
using Business.Dtos.Responses.Question;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, CreateQuestionRequest>().ReverseMap();
        CreateMap<Question, CreatedQuestionResponse>().ReverseMap();

        CreateMap<Question, UpdateQuestionRequest>().ReverseMap();
        CreateMap<Question, UpdatedQuestionResponse>().ReverseMap();

        CreateMap<Question, DeleteQuestionRequest>().ReverseMap();
        CreateMap<Question, DeletedQuestionResponse>().ReverseMap();

        CreateMap<IPaginate<Question>, Paginate<GetListQuestionResponse>>().ReverseMap();
        CreateMap<Question, GetListQuestionResponse>().ReverseMap();

        CreateMap<Question, GetQuestionResponse>().ReverseMap();
        CreateMap<Question, GetQuestionRequest>().ReverseMap();
    }
}