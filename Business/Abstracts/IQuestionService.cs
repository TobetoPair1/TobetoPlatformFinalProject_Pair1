using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Requests.Question;
using Business.Dtos.Responses.ExamQuestion;
using Business.Dtos.Responses.Question;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IQuestionService
{
    Task<CreatedQuestionResponse> AddAsync(CreateQuestionRequest createQuestionRequest);
    Task<UpdatedQuestionResponse> UpdateAsync(UpdateQuestionRequest updateQuestionRequest);
    Task<DeletedQuestionResponse> DeleteAsync(DeleteQuestionRequest deleteQuestionRequest);
    Task<GetQuestionResponse> GetByIdAsync(GetQuestionRequest getQuestionRequest);
    Task<IPaginate<GetListQuestionResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListQuestionResponse>> GetListByExamIdAsync(Guid examId, PageRequest pageRequest);
    Task<CreatedExamQuestionResponse> AssignQuestionAsync(CreateExamQuestionRequest createExamQuestionRequest);
}
