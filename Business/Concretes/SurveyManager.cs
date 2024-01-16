using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Survey;
using Business.Dtos.Responses.Survey;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SurveyManager : ISurveyService
{
    IMapper _mapper;
    ISurveyDal _surveyDal;
    public SurveyManager(IMapper mapper, ISurveyDal surveyDal)
    {
        _mapper = mapper;
        _surveyDal = surveyDal;
    }
    public async Task<CreatedSurveyResponse> AddAsync(CreateSurveyRequest createSurveyRequest)
    {
        Survey survey = _mapper.Map<Survey>(createSurveyRequest);
        var createdSurvey = await _surveyDal.AddAsync(survey);
        CreatedSurveyResponse result = _mapper.Map<CreatedSurveyResponse>(survey);
        return result;
    }

    public async Task<DeletedSurveyResponse> DeleteAsync(DeleteSurveyRequest deleteSurveyRequest)
    {
        Survey survey = await _surveyDal.GetAsync(s => s.Id == deleteSurveyRequest.Id);
        var deletedSurvey = await _surveyDal.DeleteAsync(survey);
        DeletedSurveyResponse result = _mapper.Map<DeletedSurveyResponse>(deletedSurvey);
        return result;
    }

    public async Task<GetSurveyResponse> GetByIdAsync(GetSurveyRequest getSurveyRequest)
    {
        var result = await _surveyDal.GetAsync(s => s.Id == getSurveyRequest.Id);
        return _mapper.Map<GetSurveyResponse>(result);
    }

    public async Task<IPaginate<GetListSurveyResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _surveyDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSurveyResponse>>(result);
    }

    public async Task<UpdatedSurveyResponse> UpdateAsync(UpdateSurveyRequest updateSurveyRequest)
    {
        Survey survey = _mapper.Map<Survey>(updateSurveyRequest);
        var updatedSurvey = await _surveyDal.UpdateAsync(survey);
        UpdatedSurveyResponse updatedSurveyResponse = _mapper.Map<UpdatedSurveyResponse>(updatedSurvey);
        return updatedSurveyResponse;
    }
}
