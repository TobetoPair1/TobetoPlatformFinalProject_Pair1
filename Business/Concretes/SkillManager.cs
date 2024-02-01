using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Skill;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class SkillManager : ISkillService
{
	ISkillDal _skillDal;
	IMapper _mapper;
	IUserSkillService _userSkillService;


    public SkillManager(ISkillDal skillDal, IMapper mapper)
	{
		_skillDal = skillDal;
		_mapper = mapper;
	}

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

    public async Task<DeletedSkillResponse> DeleteAsync(DeleteSkillRequest deleteSkillRequest)
	{
		Skill skill = await _skillDal.GetAsync(s => s.Id == deleteSkillRequest.Id);
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

    public async Task<IPaginate<GetListSkillResponse>> GetListAsync(PageRequest pageRequest)
	{			
		var result = await _skillDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
		return _mapper.Map<Paginate<GetListSkillResponse>>(result);
	}

	public async Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest UpdateSkillRequest)
	{
		Skill skill = await _skillDal.GetAsync(s => s.Id ==  UpdateSkillRequest.Id);
        _mapper.Map(UpdateSkillRequest, skill);
        var updatedUser = await _skillDal.UpdateAsync(skill);
		UpdatedSkillResponse UpdatedSkillResponse = _mapper.Map<UpdatedSkillResponse>(updatedUser);
		return UpdatedSkillResponse;
	}
}
