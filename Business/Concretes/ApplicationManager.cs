using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Application;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Requests.UserCourse;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.UserApplication;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ApplicationManager:IApplicationService
{
   IMapper _mapper;
   IApplicationDal _applicationDal;
    IUserApplicationService _userApplicationService;

    public ApplicationManager(IMapper mapper, IApplicationDal applicationDal, IUserApplicationService userApplicationService)
    {
        _mapper = mapper;
        _applicationDal = applicationDal;
        _userApplicationService = userApplicationService;
    }
    public async Task<CreatedApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest)
    {
        Application application = _mapper.Map<Application>(createApplicationRequest);
        var createdApplication = await _applicationDal.AddAsync(application);
        CreatedApplicationResponse result = _mapper.Map<CreatedApplicationResponse>(application);
        return result;
    }

    public async Task<CreatedUserApplicationResponse> AssignApplicationAsync(CreateUserApplicationRequest createUserApplicationRequest)
    {
        return await _userApplicationService.AddAsync(createUserApplicationRequest);
    }

    public async Task<DeletedApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest)
    {
        Application application = await _applicationDal.GetAsync(a => a.Id == deleteApplicationRequest.Id);
        var deletedApplication = await _applicationDal.DeleteAsync(application);
        DeletedApplicationResponse deletedApplicationResponse = _mapper.Map<DeletedApplicationResponse>(deletedApplication);
        return deletedApplicationResponse;
    }
    public async Task<GetApplicationResponse> GetByIdAsync(GetApplicationRequest getApplicationRequest)
    {
        var result = await _applicationDal.GetAsync(a => a.Id == getApplicationRequest.Id);
        return _mapper.Map<GetApplicationResponse>(result);
    }

    public async Task<IPaginate<GetListApplicationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        return await _userApplicationService.GetListByUserIdAsync(userId,pageRequest);
    }

    public async Task<IPaginate<GetListApplicationResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _applicationDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListApplicationResponse>>(result);
    }
    public async Task<UpdatedApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest)
    {
		Application application = await _applicationDal.GetAsync(a => a.Id == updateApplicationRequest.Id);
		_mapper.Map(updateApplicationRequest,application);
        var updatedApplication = await _applicationDal.UpdateAsync(application);
        UpdatedApplicationResponse updatedApplicationResponse = _mapper.Map<UpdatedApplicationResponse>(updatedApplication);
        return updatedApplicationResponse;
    }

}
