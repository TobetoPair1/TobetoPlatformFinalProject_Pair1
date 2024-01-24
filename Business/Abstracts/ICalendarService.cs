using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.Calender;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICalendarService
    {
        Task<CreatedCalendarResponse> AddAsync(CreateCalendarRequest createCalenderRequest);
        Task<IPaginate<GetListCalendarResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedCalendarResponse> DeleteAsync(DeleteCalendarRequest deleteCalenderRequest);
        Task<UpdatedCalendarResponse> UpdateAsync(UpdateCalendarRequest updateCalenderRequest);
        Task<GetCalendarResponse> GetByIdAsync(GetCalendarRequest getCalenderRequest);
    }
}
