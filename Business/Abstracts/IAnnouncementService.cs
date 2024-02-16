using Business.Dtos.Requests.Announcement;
using Business.Dtos.Responses.Announcement;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IAnnouncementService
{
    Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest);
    Task<IPaginate<GetListAnnouncementResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedAnnouncementResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest);
    Task<GetAnnouncementResponse> GetByIdAsync(GetAnnouncementRequest getAnnouncementRequest);
}