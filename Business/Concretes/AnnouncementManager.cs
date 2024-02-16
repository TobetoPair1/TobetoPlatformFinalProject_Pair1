using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Responses.Announcement;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class AnnouncementManager : IAnnouncementService
{
    IMapper _mapper;
    IAnnouncementDal _announcementDal;
    AnnouncementBusinessRules _announcementBusinessRules;
	public AnnouncementManager(IMapper mapper, IAnnouncementDal announcementDal, AnnouncementBusinessRules announcementBusinessRules)
	{
		_mapper = mapper;
		_announcementDal = announcementDal;
		_announcementBusinessRules = announcementBusinessRules;
	}
	[SecuredOperation("admin")]
	public async Task<CreatedAnnouncementResponse> AddAsync(CreateAnnouncementRequest createAnnouncementRequest)
    {
        Announcement announcement = _mapper.Map<Announcement>(createAnnouncementRequest);
        var createdAnnouncement = await _announcementDal.AddAsync(announcement);
        CreatedAnnouncementResponse createdAnnouncementResponse = _mapper.Map<CreatedAnnouncementResponse>(createdAnnouncement);
        return createdAnnouncementResponse;
    }
	[SecuredOperation("admin")]
	public async Task<DeletedAnnouncementResponse> DeleteAsync(DeleteAnnouncementRequest deleteAnnouncementRequest)
    {
        Announcement announcement = await _announcementBusinessRules.CheckIfExistsById(deleteAnnouncementRequest.Id);
        var deletedAnnouncement = await _announcementDal.DeleteAsync(announcement);
        DeletedAnnouncementResponse deletedAnnouncementResponse = _mapper.Map<DeletedAnnouncementResponse>(deletedAnnouncement);
        return deletedAnnouncementResponse; 
    }

    public async Task<GetAnnouncementResponse> GetByIdAsync(GetAnnouncementRequest getAnnouncementRequest)
    {
        var result = await _announcementDal.GetAsync(a => a.Id == getAnnouncementRequest.Id);
        return _mapper.Map<GetAnnouncementResponse>(result);
    }
	[SecuredOperation("admin")]
	public async Task<IPaginate<GetListAnnouncementResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _announcementDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListAnnouncementResponse>>(result);
    }
	[SecuredOperation("admin")]
	public async Task<UpdatedAnnouncementResponse> UpdateAsync(UpdateAnnouncementRequest updateAnnouncementRequest)
    {
        Announcement announcement = await _announcementBusinessRules.CheckIfExistsById(updateAnnouncementRequest.Id);
		_mapper.Map(updateAnnouncementRequest,announcement);
        var updatedAnnouncement = await _announcementDal.UpdateAsync(announcement);
        UpdatedAnnouncementResponse updatedAnnouncementResponse = _mapper.Map<UpdatedAnnouncementResponse>(updatedAnnouncement);
        return updatedAnnouncementResponse;
    }
}
