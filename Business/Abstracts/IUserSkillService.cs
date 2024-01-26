using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.Skill;
using Business.Dtos.Responses.UserSkill;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IUserSkillService
	{
		Task<CreatedUserSkillResponse> AddAsync(CreateUserSkillRequest createUserSkillRequest);
		Task<IPaginate<GetListUserSkillResponse>> GetListAsync(PageRequest pageRequest);
		Task<DeletedUserSkillResponse> DeleteAsync(DeleteUserSkillRequest deleteUserSkillRequest);
		Task<GetUserSkillResponse> GetByIdAsync(GetUserSkillRequest getUserSkillRequest);
        Task<IPaginate<GetListSkillResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest);

    }
}
