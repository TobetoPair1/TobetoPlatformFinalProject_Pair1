namespace Business.Dtos.Responses.UserSkill
{
    public class GetListUserSkillResponse
    {       
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
        public string SkillName { get; set; }
    }
}
