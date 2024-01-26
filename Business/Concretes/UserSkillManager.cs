using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class UserSkillManager : IUserSkillService
{
    IUserSkillDal _userSkillDal;
    IMapper _mapper;

    public UserSkillManager(IUserSkillDal userSkillDal, IMapper mapper)
    {
        _userSkillDal = userSkillDal;
        _mapper = mapper;
    }

    public async Task<CreatedUserSkillResponse> AddAsync(CreateUserSkillRequest createUserSkillRequest)
    {
        UserSkill userSkill = _mapper.Map<UserSkill>(createUserSkillRequest);
        var createdUserSkill = await _userSkillDal.AddAsync(userSkill);
        CreatedUserSkillResponse createdUserSkillResponse = _mapper.Map<CreatedUserSkillResponse>(createdUserSkill);
        return createdUserSkillResponse;
    }

    public async Task<DeletedUserSkillResponse> DeleteAsync(DeleteUserSkillRequest deleteUserSkillRequest)
    {
        UserSkill userSkill = await _userSkillDal.GetAsync(
            us =>
            us.UserId == deleteUserSkillRequest.UserId
            &&
            us.SkillId == deleteUserSkillRequest.SkillId);
        var deletedUserSkill = await _userSkillDal.DeleteAsync(userSkill, true);
        DeletedUserSkillResponse deletedUserSkillResponse = _mapper.Map<DeletedUserSkillResponse>(deletedUserSkill);
        return deletedUserSkillResponse;
    }

    public async Task<GetUserSkillResponse> GetByIdAsync(GetUserSkillRequest getUserSkillRequest)
    {
        var result = await _userSkillDal.GetAsync(
            us =>
            us.UserId == getUserSkillRequest.UserId
            &&
            us.SkillId == getUserSkillRequest.SkillId,
            include: us => us.Include(us => us.Skill)
            );
        return _mapper.Map<GetUserSkillResponse>(result);
    }

    public async Task<IPaginate<GetListUserSkillResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userSkillDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: us => us.Include(us => us.Skill));
        return _mapper.Map<Paginate<GetListUserSkillResponse>>(result);
    }

    public async Task<IPaginate<GetListSkillResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var userSkills = await _userSkillDal.GetListAsync(us => us.UserId == userId, include: us => us.Include(us => us.Skill), index: pageRequest.PageIndex, size: pageRequest.PageSize);

        var skills = _mapper.Map<Paginate<GetListSkillResponse>>(userSkills);
        return skills;
    }
}
