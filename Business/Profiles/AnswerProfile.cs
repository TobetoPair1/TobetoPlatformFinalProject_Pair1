using AutoMapper;
using Business.Dtos.Requests.Answer;
using Business.Dtos.Responses.Answer;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
	public class AnswerProfile:Profile
    {
        public AnswerProfile()
        {
			CreateMap<Answer, CreateAnswerRequest>().ReverseMap();
			CreateMap<Answer, CreatedAnswerResponse>().ReverseMap();

			CreateMap<Answer, UpdateAnswerRequest>().ReverseMap();
			CreateMap<Answer, UpdatedAnswerResponse>().ReverseMap();

			CreateMap<Answer, DeleteAnswerRequest>().ReverseMap();
			CreateMap<Answer, DeletedAnswerResponse>().ReverseMap();

			CreateMap<IPaginate<Answer>, Paginate<GetListAnswerResponse>>().ReverseMap();
			CreateMap<Answer, GetListAnswerResponse>().ForMember(
				destinationMember: a => a.QuestionDescription,
				memberOptions: opt => opt.MapFrom(ca => ca.Question.Description)
				)
				.ReverseMap();

			CreateMap<Answer, GetAnswerRequest>().ReverseMap();
			CreateMap<Answer, GetAnswerResponse>().ForMember(
				destinationMember: a => a.QuestionDescription,
				memberOptions: opt => opt.MapFrom(ca => ca.Question.Description)
				)
				.ReverseMap();
		}
    }
}
