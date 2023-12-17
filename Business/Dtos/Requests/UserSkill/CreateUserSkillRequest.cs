namespace Business.Dtos.Requests.UserSkill
{
    public class CreateUserSkillRequest
    {
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
    }
}
