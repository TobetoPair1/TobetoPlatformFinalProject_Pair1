using Business.Dtos.Requests.Skill;
using Business.Dtos.Responses.Skill;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

    public interface ISkillService
{
	Task<CreatedSkillResponse> AddAsync(CreateSkillRequest createSkillRequest);
	Task<IPaginate<GetListSkillResponse>> GetListAsync(PageRequest pageRequest);
	Task<DeletedSkillResponse> DeleteAsync(DeleteSkillRequest deleteSkillRequest);
	Task<UpdatedSkillResponse> UpdateAsync(UpdateSkillRequest updateSkillRequest);
	Task<GetSkillResponse> GetByIdAsync(GetSkillRequest getSkillRequest);
}
