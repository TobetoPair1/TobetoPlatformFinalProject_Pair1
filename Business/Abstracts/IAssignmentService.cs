using Business.Dtos.Requests.Assignment;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Assignment;
using Business.Dtos.Responses.Category;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    internal interface IAssignmentService
    {
        Task<CreatedAssigmentResponse> AddAsync(CreateAssigmentRequest createAssigmentRequest);
        Task<IPaginate<GetListAssigmentResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedAssigmentResponse> DeleteAsync(DeleteAssigmentRequest deleteAssigmentRequest);
        Task<UpdatedAssigmentResponse> UpdateAsync(UpdateAssigmentRequest updateAssigmentRequest);
        Task<GetAssigmentResponse> GetByIdAsync(Guid id);
    }
}
