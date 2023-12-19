namespace Business.Dtos.Requests.UserSkill
{
    public class DeleteUserSkillRequest
    {
		public Guid UserId { get; set; }
		public Guid SkillId { get; set; }
	}
}
