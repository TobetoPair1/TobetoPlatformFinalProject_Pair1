using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.UserSurvey;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTable;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;
public class UserSurveyManager : IUserSurveyService
{
    IMapper _mapper;
    IUserSurveyDal _userSurveyDal;

    public UserSurveyManager(IMapper mapper, IUserSurveyDal userSurveyDal)
    {
        _mapper = mapper;
        _userSurveyDal = userSurveyDal;
    }

    public async Task<CreatedUserSurveyResponse> AddAsync(CreateUserSurveyRequest createUserSurveyRequest)
    {
        UserSurvey userSurvey = _mapper.Map<UserSurvey>(createUserSurveyRequest);
        var createdUserSurvey = await _userSurveyDal.AddAsync(userSurvey);
        CreatedUserSurveyResponse createdUserSurveyResponse = _mapper.Map<CreatedUserSurveyResponse>(createdUserSurvey);
        return createdUserSurveyResponse;
    }

    public async Task<DeletedUserSurveyResponse> DeleteAsync(DeleteUserSurveyRequest deleteUserSurveyRequest)
    {
        UserSurvey userSurvey = await _userSurveyDal.GetAsync(us => us.UserId == deleteUserSurveyRequest.UserId && us.SurveyId == deleteUserSurveyRequest.SurveyId);
        var deletedUserSurvey = await _userSurveyDal.DeleteAsync(userSurvey, true);
        DeletedUserSurveyResponse deletedUserSurveyResponse = _mapper.Map<DeletedUserSurveyResponse>(deletedUserSurvey);
        return deletedUserSurveyResponse;
    }

    public async Task<GetUserSurveyResponse> GetByIdAsync(GetUserSurveyRequest getUserSurveyRequest)
    {
        var result = await _userSurveyDal.GetAsync(us => us.UserId == getUserSurveyRequest.UserId && us.SurveyId == getUserSurveyRequest.SurveyId, include: us => us.Include(us => us.Survey));
        return _mapper.Map<GetUserSurveyResponse>(result);
    }

    public async Task<IPaginate<GetListUserSurveyResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userSurveyDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: us => us.Include(us => us.Survey));
        return _mapper.Map<Paginate<GetListUserSurveyResponse>>(result);
    }
}
