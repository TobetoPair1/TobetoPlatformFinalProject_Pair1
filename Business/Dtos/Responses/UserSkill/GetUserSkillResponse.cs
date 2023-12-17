namespace Business.Dtos.Responses.UserSkill
{
    public class GetUserSkillResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
        public string SkillName { get; set; }
    }
}
