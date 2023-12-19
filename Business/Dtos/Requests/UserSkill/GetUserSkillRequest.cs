namespace Business.Dtos.Requests.UserSkill
{
    public class GetUserSkillRequest
    {
		public Guid UserId { get; set; }
		public Guid SkillId { get; set; }
	}
}
