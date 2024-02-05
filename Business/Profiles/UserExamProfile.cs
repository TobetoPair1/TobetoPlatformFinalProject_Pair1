using AutoMapper;
using Business.Dtos.Requests.UserExam;
using Business.Dtos.Responses.Exam;
using Business.Dtos.Responses.UserExam;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserExamProfile : Profile
{
    public UserExamProfile()
    {
        CreateMap<UserExam, CreateUserExamRequest>().ReverseMap();
        CreateMap<UserExam, CreatedUserExamResponse>().ReverseMap();

        CreateMap<UserExam, DeleteUserExamRequest>().ReverseMap();
        CreateMap<UserExam, DeletedUserExamResponse>().ReverseMap();

        CreateMap<UserExam, GetUserExamRequest>().ReverseMap();
        CreateMap<UserExam, GetUserExamResponse>().ReverseMap();

        CreateMap<IPaginate<UserExam>, Paginate<GetListUserExamResponse>>().ReverseMap();
        CreateMap<UserExam, GetListUserExamResponse>().ForMember(destinationMember: ue => ue.ExamTitle, memberOptions: opt => opt.MapFrom(ue => ue.Exam.Title)).ReverseMap();
        CreateMap<IPaginate<UserExam>, Paginate<GetListExamResponse>>().ReverseMap();
        CreateMap<UserExam, GetListExamResponse>().IncludeMembers(ue => ue.Exam).ForMember(destinationMember:gler=> gler.Id,memberOptions:opt=> opt.MapFrom(ue=>ue.ExamId)).ReverseMap();
    }
}