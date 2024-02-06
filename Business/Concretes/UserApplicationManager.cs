using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.Application;
using Business.Dtos.Responses.UserApplication;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;
public class UserApplicationManager : IUserApplicationService
{
    IMapper _mapper;
    IUserApplicationDal _userApplicationDal;
    UserApplicationRules _userApplicationRules;

    public UserApplicationManager(IMapper mapper, IUserApplicationDal userApplicationDal, UserApplicationRules userApplicationRules)
    {
        _mapper = mapper;
        _userApplicationDal = userApplicationDal;
        _userApplicationRules = userApplicationRules;
    }

    public async Task<CreatedUserApplicationResponse> AddAsync(CreateUserApplicationRequest createUserApplicationRequest)
    {
        UserApplication userApplication = _mapper.Map<UserApplication>(createUserApplicationRequest);
        var createdUserApplication = await _userApplicationDal.AddAsync(userApplication);
        CreatedUserApplicationResponse createdUserApplicationResponse = _mapper.Map<CreatedUserApplicationResponse>(createdUserApplication);
        return createdUserApplicationResponse;
    }

    public async Task<DeletedUserApplicationResponse> DeleteAsync(DeleteUserApplicationRequest deleteUserApplicationRequest)
    {
        UserApplication userApplication = await _userApplicationRules.CheckIfExistsWithForeignKey(deleteUserApplicationRequest.UserId, deleteUserApplicationRequest.ApplicationId);
        var deletedUserApplication = await _userApplicationDal.DeleteAsync(userApplication, true);
        DeletedUserApplicationResponse deletedUserApplicationResponse = _mapper.Map<DeletedUserApplicationResponse>(deletedUserApplication);
        return deletedUserApplicationResponse;
    }

    public async Task<GetUserApplicationResponse> GetByIdAsync(GetUserApplicationRequest getUserApplicationRequest)
    {
        var result = await _userApplicationDal.GetAsync(ap => ap.UserId == getUserApplicationRequest.UserId && ap.ApplicationId == getUserApplicationRequest.ApplicationId, include: ap => ap.Include(ap => ap.Application));
        return _mapper.Map<GetUserApplicationResponse>(result);
    }

    public async Task<IPaginate<GetListUserApplicationResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userApplicationDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: ap => ap.Include(ap => ap.Application));
        return _mapper.Map<Paginate<GetListUserApplicationResponse>>(result);
    }

    public async Task<IPaginate<GetListApplicationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var userApp = await _userApplicationDal.GetListAsync(ua => ua.UserId == userId, include: ua => ua.Include(ua => ua.Application), index: pageRequest.PageIndex, size: pageRequest.PageSize);
        var apps = _mapper.Map<Paginate<GetListApplicationResponse>>(userApp);
        return apps;
    }
}
