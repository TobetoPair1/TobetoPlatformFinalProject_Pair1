﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Experience;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ExperienceManager : IExperienceService
{
    IMapper _mapper;
    IExperienceDal _experienceDal;
    ExperienceBusinessRules _experienceBusinessRules;


    public ExperienceManager(IMapper mapper, IExperienceDal experienceDal,
        ExperienceBusinessRules experienceBusinessRules)
    {
        _experienceDal = experienceDal;
        _mapper = mapper;
        _experienceBusinessRules = experienceBusinessRules;
    }
    [SecuredOperation("admin")]
    public async Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest)
    {
        Experience experience = _mapper.Map<Experience>(createExperienceRequest);
        var createdExperience = await _experienceDal.AddAsync(experience);
        CreatedExperienceResponse result = _mapper.Map<CreatedExperienceResponse>(createdExperience);
        return result;
    }
    [SecuredOperation("admin")]
    public async Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceRequest)
    {
        Experience experience = await _experienceBusinessRules.CheckIfExistsById(deleteExperienceRequest.Id);
        var deletedExperience = await _experienceDal.DeleteAsync(experience);
        DeletedExperienceResponse deletedExperienceResponse = _mapper.Map<DeletedExperienceResponse>(deletedExperience);
        return deletedExperienceResponse; 
    }


    public async Task<GetExperienceResponse> GetByIdAsync(GetExperienceRequest getExperienceRequest)
    {
        var result = await _experienceDal.GetAsync(i => i.Id == getExperienceRequest.Id);
        return _mapper.Map<GetExperienceResponse>(result);
    }
    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListExperienceResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _experienceDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListExperienceResponse>>(result);
    }

    public async Task<IPaginate<GetListExperienceResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var result = await _experienceDal.GetListAsync(e => e.UserId == userId, index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListExperienceResponse>>(result);
    }
    [SecuredOperation("admin")]
    public async Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest)
    {
        await _experienceBusinessRules.CheckUserIfExists(updateExperienceRequest.Id);
        Experience experience = await _experienceBusinessRules.CheckIfExistsById(updateExperienceRequest.Id);
        var updatedExperience = await _experienceDal.UpdateAsync(experience);
        UpdatedExperienceResponse updatedExperienceResponse = _mapper.Map<UpdatedExperienceResponse>(updatedExperience);
        return updatedExperienceResponse; 
    }
}