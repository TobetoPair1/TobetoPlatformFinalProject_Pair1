using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
        Task<IPaginate<GetListInstructorResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
        Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
        Task<GetInstructorResponse> GetByIdAsync(GetInstructorRequest getInstructorRequest);
    }
}
