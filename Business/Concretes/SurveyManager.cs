using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Survey;
using Business.Dtos.Requests.UserSurvey;
using Business.Dtos.Responses.Survey;
using Business.Dtos.Responses.UserSurvey;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SurveyManager : ISurveyService
{
    IMapper _mapper;
    ISurveyDal _surveyDal;
    IUserSurveyService _userSurveyService;
    SurveyBusinessRules _surveyBusinessRules;
    public SurveyManager(IMapper mapper, ISurveyDal surveyDal, IUserSurveyService userSurveyService, SurveyBusinessRules surveyBusinessRules)
    {
        _mapper = mapper;
        _surveyDal = surveyDal;
        _userSurveyService = userSurveyService;
        _surveyBusinessRules = surveyBusinessRules;
    }
    public async Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest)
    {
        Survey survey = _mapper.Map<Survey>(createSurveyRequest);
        var createdSurvey = await _surveyDal.AddAsync(survey);
        CreatedSurveyResponse result = _mapper.Map<CreatedSurveyResponse>(survey);
        return result;
    }

    public async Task<CreatedUserSurveyResponse> AssignSurveyAsync(CreateUserSurveyRequest createUserSurveyRequest)
    {
        return await _userSurveyService.AddAsync(createUserSurveyRequest);
    }

    public async Task<DeletedSurveyResponse> DeleteAsync(DeleteSurveyRequest deleteSurveyRequest)
    {
        Survey survey = await _surveyBusinessRules.CheckIfExistsById(deleteSurveyRequest.Id);
        var deletedSurvey = await _surveyDal.DeleteAsync(survey);
        DeletedSurveyResponse result = _mapper.Map<DeletedSurveyResponse>(deletedSurvey);
        return result;
    }

    public async Task<GetSurveyResponse> GetByIdAsync(GetSurveyRequest getSurveyRequest)
    {
        var result = await _surveyDal.GetAsync(s => s.Id == getSurveyRequest.Id);
        return _mapper.Map<GetSurveyResponse>(result);
    }

    public async Task<IPaginate<GetListSurveyResponse>> GetByUserId(Guid userId, PageRequest pageRequest)
    {
        return await _userSurveyService.GetListByUserIdAsync(userId, pageRequest);
    }

    public async Task<IPaginate<GetListSurveyResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _surveyDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSurveyResponse>>(result);
    }

    public async Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyRequest)
    {
        Survey survey = await _surveyBusinessRules.CheckIfExistsById(updateSurveyRequest.Id);
        _mapper.Map(updateSurveyRequest, survey);
        var updatedSurvey = await _surveyDal.UpdateAsync(survey);
        UpdatedSurveyResponse updatedSurveyResponse = _mapper.Map<UpdatedSurveyResponse>(updatedSurvey);
        return updatedSurveyResponse;
    }
}
