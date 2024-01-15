
using AutoMapper;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.ExamQuestion;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTable;

namespace Business.Profiles
{
    public class ExamQuestionProfile:Profile
    {
        public ExamQuestionProfile()
        {
			CreateMap<ExamQuestion, CreateExamQuestionRequest>().ReverseMap();
			CreateMap<ExamQuestion, CreatedAnnouncementResponse>().ReverseMap();

			CreateMap<ExamQuestion, DeleteExamQuestionRequest>().ReverseMap();
			CreateMap<ExamQuestion, DeletedExamQuestionResponse>().ReverseMap();

			CreateMap<IPaginate<ExamQuestion>, Paginate<GetListExamQuestionResponse>>().ReverseMap();
			CreateMap<ExamQuestion, GetListExamQuestionResponse>().ReverseMap();
			
		}
    }
}
