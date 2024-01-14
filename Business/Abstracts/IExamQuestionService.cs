
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.ExamQuestion;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface IExamQuestionService
    {
		Task<CreatedExamQuestionResponse> AddAsync(CreateExamQuestionRequest createExamQuestionRequest);
		Task<IPaginate<GetListExamQuestionResponse>> GetListAsync(PageRequest pageRequest);
		Task<DeletedExamQuestionResponse> DeleteAsync(DeleteExamQuestionRequest deleteExamQuestionRequest);
	}
}
