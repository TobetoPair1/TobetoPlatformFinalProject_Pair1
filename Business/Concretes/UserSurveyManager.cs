using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.Survey;
using Business.Dtos.Responses.UserSurvey;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;
public class UserSurveyManager : IUserSurveyService
{
    IMapper _mapper;
    IUserSurveyDal _userSurveyDal;
    UserSurveyBusinessRules _userSurveyBusinessRules;
    public UserSurveyManager(IMapper mapper, IUserSurveyDal userSurveyDal,
        UserSurveyBusinessRules userSurveyBusinessRules)
    {
        _mapper = mapper;
        _userSurveyDal = userSurveyDal;
        _userSurveyBusinessRules = userSurveyBusinessRules;
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
        UserSurvey userSurvey = await _userSurveyBusinessRules.CheckIfExistsWithForeignKey(deleteUserSurveyRequest.UserId, deleteUserSurveyRequest.SurveyId);
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

     public async Task<IPaginate<GetListSurveyResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var userSurveys = await _userSurveyDal.GetListAsync(us => us.UserId == userId, include:us=>us.Include(us=>us.Survey), index: pageRequest.PageIndex, size: pageRequest.PageSize);

        var surveys = _mapper.Map<Paginate<GetListSurveyResponse>>(userSurveys);
        return surveys;
    }
}
