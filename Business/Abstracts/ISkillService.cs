using Business.Dtos.Requests.Skill;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ISkillService
{
	Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest);
	Task<IPaginate<GetListSkillResponse>> GetListAsync(PageRequest pageRequest);
	Task<DeletedSkillResponse> DeleteAsync(DeleteSkillRequest deleteSkillRequest);
	Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest);
	Task<GetSkillResponse> GetByIdAsync(GetSkillRequest getSkillRequest);
    Task<IPaginate<GetListSkillResponse>> GetByUserId(Guid userId, PageRequest pageRequest);

    Task<CreatedUserSkillResponse> AssignSkillAsync(CreateUserSkillRequest createUserSkillRequest);
}
