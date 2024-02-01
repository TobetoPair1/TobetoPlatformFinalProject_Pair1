using AutoMapper;
using Business.Dtos.Requests.Exam;
using Business.Dtos.Responses.Exam;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ExamProfile : Profile
{
    public ExamProfile()
    {
        CreateMap<Exam, CreateExamRequest>().ReverseMap();
        CreateMap<Exam, CreatedExamResponse>().ReverseMap();

        CreateMap<Exam, UpdateExamRequest>().ReverseMap();
        CreateMap<Exam, UpdatedExamResponse>().ReverseMap();

        CreateMap<Exam, DeleteExamRequest>().ReverseMap();
        CreateMap<Exam, DeletedExamResponse>().ReverseMap();

        CreateMap<IPaginate<Exam>, Paginate<GetListExamResponse>>().ReverseMap();
        CreateMap<Exam, GetListExamResponse>().ReverseMap();

        CreateMap<Exam, GetExamResponse>().ReverseMap();
    }
}
