using Business.Dtos.Requests.User;
using Business.Dtos.Requests.UserSkill;
using Business.Dtos.Responses.User;
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
	}
}
