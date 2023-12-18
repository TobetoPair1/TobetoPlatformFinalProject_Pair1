using Business.Dtos.Requests.Certificate;
using Business.Dtos.Requests.Education;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Certificate;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.Experience;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEducationService
    {
        Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest);
        Task<IPaginate<GetListEducationResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deletEducationResquest);
        Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest);
        Task<GetEducationResponse> GetByIdAsync(GetEducationRequest getEducationRequest);
    }
}
