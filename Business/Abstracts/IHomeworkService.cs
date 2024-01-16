using Business.Dtos.Requests.Education;
using Business.Dtos.Requests.Homework;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.Homework;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IHomeworkService
    {
        Task<CreatedHomeworkResponse> AddAsync(CreateHomeworkRequest createHomeworkRequest);
        Task<IPaginate<GetListHomeworkResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedHomeworkResponse> DeleteAsync(DeleteHomeworkRequest deleteHomeworkRequest);
        Task<UpdatedHomeworkResponse> UpdateAsync(UpdateHomeworkRequest updateHomeworkRequest);
        Task<GetHomeworkResponse> GetByIdAsync(GetHomeworkRequest getHomeworkRequest);
    }
}