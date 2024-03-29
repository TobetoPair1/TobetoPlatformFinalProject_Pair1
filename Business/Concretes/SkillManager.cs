﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Skill;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SkillManager : ISkillService
{
    ISkillDal _skillDal;
    IMapper _mapper;
    IUserSkillService _userSkillService;
    SkillBusinessRules _skillBusinessRules;

    public SkillManager(ISkillDal skillDal, IMapper mapper, IUserSkillService userSkillService, SkillBusinessRules skillBusinessRules)
    {
        _skillDal = skillDal;
        _mapper = mapper;
        _userSkillService = userSkillService;
        _skillBusinessRules = skillBusinessRules;
    }

    [SecuredOperation("admin")]
    public async Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest)
    {
        Skill skill = _mapper.Map<Skill>(createSkillRequest);
        var createdSkill = await _skillDal.AddAsync(skill);
        CreatedSkillResponse createdSkillResponse = _mapper.Map<CreatedSkillResponse>(createdSkill);
        return createdSkillResponse;
    }

    public async Task<CreatedUserSkillResponse> AssignSkillAsync(CreateUserSkillRequest createUserSkillRequest)
    {
        return await _userSkillService.AddAsync(createUserSkillRequest);
    }

    [SecuredOperation("admin")]
    public async Task<DeletedSkillResponse> DeleteAsync(DeleteSkillRequest deleteSkillRequest)
    {
        Skill skill = await _skillBusinessRules.CheckIfExistsById(deleteSkillRequest.Id);
        var deletedSkill = await _skillDal.DeleteAsync(skill);
        DeletedSkillResponse deletedSkillResponse = _mapper.Map<DeletedSkillResponse>(deletedSkill);
        return deletedSkillResponse;
    }

    public async Task<GetSkillResponse> GetByIdAsync(GetSkillRequest getSkillRequest)
    {
        var result = await _skillDal.GetAsync(s => s.Id == getSkillRequest.Id);
        return _mapper.Map<GetSkillResponse>(result);
    }

    public async Task<IPaginate<GetListSkillResponse>> GetByUserId(Guid userId, PageRequest pageRequest)
    {
        return await _userSkillService.GetListByUserIdAsync(userId, pageRequest);
    }

    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListSkillResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _skillDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListSkillResponse>>(result);
    }

    [SecuredOperation("admin")]
    public async Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest)
    {
        Skill skill = await _skillBusinessRules.CheckIfExistsById(updateSkillRequest.Id);
        _mapper.Map(updateSkillRequest, skill);
        var updatedUser = await _skillDal.UpdateAsync(skill);
        UpdatedSkillResponse updatedSkillResponse = _mapper.Map<UpdatedSkillResponse>(updatedUser);
        return updatedSkillResponse;
    }
}
