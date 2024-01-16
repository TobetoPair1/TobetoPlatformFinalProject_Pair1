using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserApplication;
using Business.Dtos.Responses.UserApplication;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTable;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;
public class UserApplicationManager : IUserApplicationService
{
    IMapper _mapper;
    IUserApplicationDal _userApplicationDal;

    public UserApplicationManager(IMapper mapper, IUserApplicationDal userApplicationDal)
    {
        _mapper = mapper;
        _userApplicationDal = userApplicationDal;
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
        UserApplication userApplication = await _userApplicationDal.GetAsync(ap => ap.UserId == deleteUserApplicationRequest.UserId && ap.ApplicationId == deleteUserApplicationRequest.ApplicationId);
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
}
