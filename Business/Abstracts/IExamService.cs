using Business.Dtos.Requests.Exam;
using Business.Dtos.Responses.Exam;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IExamService
    {
        Task<CreatedExamResponse> AddAsync(CreateExamRequest createExamRequest);
        Task<IPaginate<GetListExamResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedExamResponse> DeleteAsync(DeleteExamRequest deleteExamRequest);
        Task<UpdatedExamResponse> UpdateAsync(UpdateExamRequest updateExamRequest);
        Task<GetExamResponse> GetByIdAsync(GetExamRequest getExamRequest);
    }
}
