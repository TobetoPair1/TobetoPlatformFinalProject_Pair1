using Business.Dtos.Requests.Answer;
using Business.Dtos.Responses.Answer;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAnswerService
{
    Task<CreatedAnswerResponse> AddAsync(CreateAnswerRequest createAnswerRequest);
    Task<IPaginate<GetListAnswerResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListAnswerResponse>> GetListByQuestionIdAsync(PageRequest pageRequest, Guid questionId);
    Task<GetAnswerResponse> GetByIdAsync(GetAnswerRequest getAnswerRequest);
    Task<DeletedAnswerResponse> DeleteAsync(DeleteAnswerRequest deleteAnswerRequest);
    Task<UpdatedAnswerResponse> UpdateAsync(UpdateAnswerRequest updateAnswerRequest);
}



