using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.Education;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IAnnouncementService
    {
        Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest);
        Task<IPaginate<GetListAnnouncementResponse>> GetListAsync(PageRequest pageRequest);
        Task<DeletedAnnouncementResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest);
        Task<UpdatedAnnouncementResponse> UpdateAsync(UpdateAnnouncementRequest updateAnnouncementRequest);
        Task<GetAnnouncementResponse> GetByIdAsync(GetAnnouncementRequest getAnnouncementRequest);
    }
}
